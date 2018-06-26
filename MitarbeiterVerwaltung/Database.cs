using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitarbeiterVerwaltung
{
    class Database
    {
        private MySqlConnection dbConnection;
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
            Mitarbeiter m;

            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM mitarbeiter ORDER BY nachname ASC";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                m = new Mitarbeiter(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.IsDBNull(0) ? 0 : reader.GetInt32(4),
                    reader.IsDBNull(0) ? 0 : reader.GetInt32(5)
                    );
                list.Add(m);
            }

            reader.Close();

            return list;
        }

        public List<Fehlgrund> getFehlgrund()
        {
            List<Fehlgrund> list = new List<Fehlgrund>();
            Fehlgrund f;

            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM fehlgrund ORDER BY grund ASC";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                f = new Fehlgrund(
                    reader.GetInt32(0),
                    reader.GetString(1)
                    );
                list.Add(f);
            }

            reader.Close();

            return list;
        }

        public List<Einsatz> getEinsatzList(int id)
        {
            List<Einsatz> list = new List<Einsatz>();
            Einsatz e;

            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM einsatz WHERE Ma_id={id}";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                e = new Einsatz(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                    );
                list.Add(e);
            }

            reader.Close();

            return list;
        }
        public List<Fehlzeit> getFehlzeitList(int id)
        {
            List<Fehlzeit> list = new List<Fehlzeit>();
            Fehlzeit f;

            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM fehlzeit WHERE Ma_id={id}";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                f = new Fehlzeit(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    reader.GetInt32(5)
                    );
                list.Add(f);
            }

            reader.Close();

            return list;
        }
        public Mitarbeiter getPersonal(int id)
        {

            Mitarbeiter m;

            MySqlCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM mitarbeiter WHERE id={id}";

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                m = new Mitarbeiter(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.IsDBNull(0) ? 0 : reader.GetInt32(4),
                    reader.IsDBNull(0) ? 0 : reader.GetInt32(5)
                    );
                reader.Close();
                return m;
            }
            return null;
        }



        ~Database()
        {
            disconnect();
        }
    }
}
