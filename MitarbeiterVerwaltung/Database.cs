using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Xml;

namespace MitarbeiterVerwaltung
{
    class Database
    {
        private MySqlConnection dbConnection;
        private Random gen = new Random();

        public Database()
        {
            connect();
        }

        public void connect()
        {
            try
            {
                dbConnection = new MySqlConnection("SERVER=localhost; DATABASE=mitarbeiter; UID=root; PASSWORD=root; SSLMODE=NONE");
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void disconnect()
        {
            dbConnection.Close();
        }

        public void Insert<T>(string table, T obj)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            int length = properties.Length;
            int i = 1;
            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {table} SET ";
            foreach (PropertyInfo property in properties)
            {
                string propertyName = property.Name;
                object propertyValue = property.GetValue(obj, null);
                string propertyType = property.PropertyType.Name;

                if (propertyName == "Id")
                {
                    cmd.CommandText += (int)propertyValue == 0 ? $"{propertyName} = NULL, " : $"{propertyName} = {propertyValue}, ";
                    i++;
                    continue;
                }
                if (typeof(T).GetProperty(property.Name) != null)
                {

                    switch (propertyType)
                    {
                        case "Int32":
                            cmd.CommandText += $"{propertyName} = {propertyValue}";
                            break;
                        case "String":
                            cmd.CommandText += $"{propertyName} = '{propertyValue}'";
                            break;
                        case "Boolean":
                            cmd.CommandText += $"{propertyName} = {propertyValue}";
                            break;
                    }
                    cmd.CommandText += (length == i) ? " " : ", ";
                    // MessageBox.Show("(" + propertyType + ")" + propertyName + ": " + propertyValue,"INFO", MessageBoxButtons.YesNo);
                    i++;
                }
            }
            cmd.CommandText += ";";
            // MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
        }

        public void Update<T>(string table, int id, T obj)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            int length = properties.Length;
            int i = 1;

            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = $"UPDATE {table} SET ";
            foreach (PropertyInfo property in properties)
            {
                string propertyName = property.Name;
                object propertyValue = property.GetValue(obj, null);
                string propertyType = property.PropertyType.Name;

                if (propertyName == "Id")
                {
                    i++;
                    continue;
                }

                switch (propertyType)
                {
                    case "Int32":
                        cmd.CommandText += $"{propertyName} = {propertyValue}";
                        break;
                    case "String":
                        cmd.CommandText += $"{propertyName} = '{propertyValue}'";
                        break;
                    case "Boolean":
                        cmd.CommandText += $"{propertyName} = {propertyValue}";
                        break;
                }
                cmd.CommandText += (length == i) ? " " : ", ";
                // MessageBox.Show("(" + propertyType + ")" + propertyName + ": " + propertyValue,"INFO", MessageBoxButtons.YesNo);
                i++;

            }
            cmd.CommandText += $" WHERE id={id};";
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

        }

        public List<Mitarbeiter> getPersonalList()
        {
            List<Mitarbeiter> list = new List<Mitarbeiter>();
            MySqlDataReader reader = sooperDooperMysqlFuncyWunky("SELECT * FROM mitarbeiter ORDER BY nachname ASC");

            while (reader.Read())
            {
                list.Add(new Mitarbeiter(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.IsDBNull(0) ? 0 : reader.GetInt32(4),
                    reader.IsDBNull(0) ? 0 : reader.GetInt32(5)
                    ));
            }

            reader.Close();

            return list;
        }

        public List<Fehlgrund> getFehlgrund()
        {
            List<Fehlgrund> list = new List<Fehlgrund>();
            MySqlDataReader reader = sooperDooperMysqlFuncyWunky("SELECT * FROM fehlgrund ORDER BY grund ASC");

            while (reader.Read())
            {
                list.Add(new Fehlgrund(
                    reader.GetInt32(0),
                    reader.GetString(1)
                    ));
            }
            reader.Close();

            return list;
        }

        public List<Einsatz> getEinsatzList(int id)
        {
            List<Einsatz> list = new List<Einsatz>();
            MySqlDataReader reader = sooperDooperMysqlFuncyWunky($"SELECT * FROM einsatz WHERE Ma_id={id}");

            while (reader.Read())
            {
                list.Add(new Einsatz(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                    ));
            }
            reader.Close();

            return list;
        }

        public List<Fehlzeit> getFehlzeitList(int id)
        {
            List<Fehlzeit> list = new List<Fehlzeit>();

            MySqlDataReader reader = sooperDooperMysqlFuncyWunky($"SELECT * FROM fehlzeit WHERE Ma_id={id}");

            while (reader.Read())
            {
                list.Add(new Fehlzeit(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    reader.GetInt32(5)
                    ));
            }

            reader.Close();

            return list;
        }

        public List<AuswertungFehlzeit> getAuswertungFehlzeiten(bool insgesamt)
        {
            List<AuswertungFehlzeit> list = new List<AuswertungFehlzeit>();
            string q;
            if(insgesamt)
            {
                q = "SELECT mitarbeiter.Vorname, mitarbeiter.Nachname, SUM(fehlzeit.Fehltage) " +
                "FROM mitarbeiter, fehlzeit, fehlgrund " +
                "WHERE fehlzeit.Ma_id = mitarbeiter.Id AND fehlgrund.Id=fehlzeit.Grund_id GROUP BY mitarbeiter.Id ORDER BY mitarbeiter.Nachname";
                MySqlDataReader reader = sooperDooperMysqlFuncyWunky(q);
 
                while (reader.Read())
                {
                    list.Add(new AuswertungFehlzeit(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetInt32(2)
                        ));
                }

                reader.Close();
            }
            else
            {
                q = "SELECT mitarbeiter.Vorname, mitarbeiter.Nachname, fehlgrund.Grund, SUM(fehlzeit.Fehltage) " +
                    "FROM mitarbeiter, fehlzeit, fehlgrund " +
                    "WHERE fehlzeit.Ma_id = mitarbeiter.Id AND fehlgrund.Id=fehlzeit.Grund_id GROUP BY mitarbeiter.Id, fehlgrund.Id ORDER BY mitarbeiter.Nachname";
                MySqlDataReader reader = sooperDooperMysqlFuncyWunky(q);

                while (reader.Read())
                {
                    list.Add(new AuswertungFehlzeit(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3)
                        ));
                }

                reader.Close();
            }

            return list;
        }

        private MySqlDataReader sooperDooperMysqlFuncyWunky(string q)
        {
            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = q;
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void generateDB()
        {
            
            for (int i = 1; i < 1000; i++)
            {
                int arbeitszeit = gen.Next(5, 9);
                int urlaub = gen.Next(20, 29);
                string gebdat = BirthDay().ToString("yyyy-MM-dd");
                Insert("mitarbeiter", new Mitarbeiter(i, Faker.Name.First(), Faker.Name.Last(), gebdat, arbeitszeit, urlaub));
                int randomFehlzeiten = gen.Next(1, 5);

                for (int j = 0; j < randomFehlzeiten; j++)
                {
                    DateTime vonT = RandomDay();
                    string von = vonT.ToString("yyyy-MM-dd");
                    int days = gen.Next(1, 14);
                    DateTime bisT = vonT.AddDays(days);
                    string bis = bisT.ToString("yyyy-MM-dd");

                    int grund_id = gen.Next(1, 4);

                    DateTime d1 = vonT;
                    DateTime d2 = bisT;

                    int fehltage = Convert.ToInt32((d1 - d2).TotalDays);

                    fehltage = (fehltage * -1) + 1;
                    Insert("fehlzeit", new Fehlzeit(0, i, von, bis, grund_id, fehltage));
                }

            }
        }
        private DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        private DateTime BirthDay()
        {
            DateTime start = new DateTime(1960, 1, 1);
            int range = (new DateTime(2000, 1, 1) - start).Days;
            return start.AddDays(gen.Next(range));
        }
        ~Database()
        {
            disconnect();
        }
    }
}
