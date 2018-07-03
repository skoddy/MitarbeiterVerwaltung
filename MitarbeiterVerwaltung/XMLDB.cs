using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MitarbeiterVerwaltung
{
    class XMLDB
    {
        XmlTextReader reader;
        private const string file = "db.xml";

        public XMLDB()
        {
            connect();
        }

        private void connect()
        {
            reader = new XmlTextReader(file);
        }

        public List<Mitarbeiter> getPersonalList()
        {
            List<Mitarbeiter> list = new List<Mitarbeiter>();
            int id = 1;
            string vorname;
            string nachname;
            string gebdat = "12.09.1974";
            int az = 0;
            int uz = 0;

            try
            {
                while (reader.Read())
                {
                    if (reader.Name != "")
                    {
                        for (int i = 0; i < reader.AttributeCount; i++)
                        {
                            if (reader.Name == "Mitarbeiter")
                            {
                                if (reader.AttributeCount == 2)
                                {
                                    reader.MoveToAttribute("vorname");
                                    vorname = reader.Value;
                                    reader.MoveToAttribute("nachname");
                                    nachname = reader.Value;

                                    list.Add(new Mitarbeiter(id, vorname, nachname, gebdat, az, uz));
                                    id++;
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }
        public void export(List<Mitarbeiter> list)
        {
            try
            {
                // XML-Datei erzeugen
                XmlTextWriter myXmlTextWriter = new XmlTextWriter("db.xml", System.Text.Encoding.UTF8);
                myXmlTextWriter.Formatting = Formatting.Indented;
                myXmlTextWriter.WriteStartDocument(false);

                // Haupttag Init
                myXmlTextWriter.WriteStartElement("Personal");

                // Attribute schreiben 
                //foreach (Mitarbeiter mitarbeiter in list)
                //{
                //    myXmlTextWriter.WriteStartElement("Mitarbeiter", null);
                //    myXmlTextWriter.WriteElementString("Nachname", mitarbeiter.Nachname);
                //    myXmlTextWriter.WriteElementString("Vorname", mitarbeiter.Vorname);
                //    myXmlTextWriter.WriteEndElement();
                //}

                foreach (Mitarbeiter mitarbeiter in list)
                {
                    myXmlTextWriter.WriteStartElement("Mitarbeiter", null);
                    myXmlTextWriter.WriteAttributeString("Nachname", mitarbeiter.Nachname);
                    myXmlTextWriter.WriteAttributeString("Vorname", mitarbeiter.Vorname);
                    myXmlTextWriter.WriteEndElement();
                }


                myXmlTextWriter.WriteEndElement(); // Init
                myXmlTextWriter.Flush();
                myXmlTextWriter.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AusnahmeFehler XML-Schreiben. Bitte notieren. " + ex.Message);

            }

        }


    }
}


