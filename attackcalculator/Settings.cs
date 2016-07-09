using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

using System.Diagnostics; //Debug

namespace attackcalculator
{
    public static class Settings
    {
        private static XmlDocument xml_settings;
        private static string str_xmlpath = Application.StartupPath + "\\settings.xml";

        public static bool Exists => File.Exists(str_xmlpath);

        public static void Load()
        {
            XmlDocument tempLoad = new XmlDocument();
            tempLoad.Load(str_xmlpath);
            xml_settings = tempLoad;
        }

        public static void Create()
        {
            XmlDocument tempCreate = new XmlDocument();
            tempCreate.LoadXml(Properties.Resources.settings);
            tempCreate.Save(str_xmlpath);
        }

        public static class Output
        {
            public static int varCount => xml_settings.SelectNodes("/settings/output/variables/var").Count - 1;

            public struct outputVar
            {
                public int ID { get; set; }
                public bool Enabled { get; set; }
                public string Name { get; set; }
                public int DataType { get; set; }
                public int PrintMode { get; set; }

                public outputVar(int id, bool enabled, string name, int dataType, int printMode)
                {
                    ID = id;
                    Enabled = enabled;
                    Name = name;
                    DataType = dataType;
                    PrintMode = printMode;
                }
            }

            public static outputVar Read(int id)
            {
                outputVar tempVar;
                XmlNodeList nodesVar = xml_settings.SelectNodes("/settings/output/variables/var");

                //Error Check
                if (id < 0 || id > nodesVar.Count - 1)
                    return new outputVar(-1, false, "incorrect id error!", -1, -1);

                XmlNode nodeVar = nodesVar[id];

                bool bool_enabled = false;
                int int_id = 0, int_dataType = -1, int_printMode = -1;
                string str_name = String.Empty;

                for (int i = 0; i < nodeVar.Attributes.Count; i++)
                {
                    switch (nodeVar.Attributes[i].LocalName)
                    {
                        case "id":
                            int_id = Convert.ToInt16(nodeVar.Attributes[i].InnerText);
                            break;
                        case "enabled":
                            bool_enabled = Convert.ToBoolean(nodeVar.Attributes[i].InnerText);
                            break;
                    }
                }

                for (int i = 0; i < nodeVar.ChildNodes.Count; i++)
                {
                    switch (nodeVar.ChildNodes[i].LocalName)
                    {
                        case "name":
                            str_name = nodeVar.ChildNodes[i].InnerText;
                            break;
                        case "datatype":
                            int_dataType = Convert.ToInt16(nodeVar.ChildNodes[i].InnerText);
                            break;
                        case "print":
                            int_printMode = Convert.ToInt16(nodeVar.ChildNodes[i].InnerText);
                            break;
                    }
                }

                tempVar = new outputVar(int_id, bool_enabled, str_name, int_dataType, int_printMode);

                return tempVar;
            }

            public static void Write(outputVar var)
            {
                XmlNodeList nodesVar = xml_settings.SelectNodes("/settings/output/variables/var");
                XmlNode nodeVar = nodesVar[var.ID];

                for (int i = 0; i < nodeVar.Attributes.Count; i++)
                {
                    switch (nodeVar.Attributes[i].LocalName)
                    {
                        case "id":
                            nodeVar.Attributes[i].InnerText = var.ID.ToString();
                            break;
                        case "enabled":
                            nodeVar.Attributes[i].InnerText = var.Enabled.ToString().ToLower();
                            break;
                    }
                }

                for (int i = 0; i < nodeVar.ChildNodes.Count; i++)
                {
                    switch (nodeVar.ChildNodes[i].LocalName)
                    {
                        case "name":
                            nodeVar.ChildNodes[i].InnerText = var.Name;
                            break;
                        case "datatype":
                            nodeVar.ChildNodes[i].InnerText = var.DataType.ToString();
                            break;
                        case "print":
                            nodeVar.ChildNodes[i].InnerText = var.PrintMode.ToString();
                            break;
                    }
                }

                xml_settings.Save(str_xmlpath);
            }

            public static string miscRead(int index)
            {
                if (index < 0 || index > 3)
                    return "incorrect id error!";

                switch (index)
                {
                    case 0:
                        return xml_settings.SelectSingleNode("/settings/output/format/OffensiveCollision").InnerText;
                    case 1:
                        return xml_settings.SelectSingleNode("/settings/output/format/SpecialOffensiveCollision").InnerText;
                    case 2:
                        return xml_settings.SelectSingleNode("/settings/output/format/ThrowSpecifier").InnerText;
                    case 3:
                        return xml_settings.SelectSingleNode("/settings/output/copymode").InnerText;
                }

                return String.Empty; //LET ME COMPILE VS!!!
            }

            public static void miscWrite(int index, string write)
            {
                if (index < 0 || index > 3)
                    return;

                switch (index)
                {
                    case 0:
                        xml_settings.SelectSingleNode("/settings/output/format/OffensiveCollision").InnerText = write;
                        break;
                    case 1:
                        xml_settings.SelectSingleNode("/settings/output/format/SpecialOffensiveCollision").InnerText = write;
                        break;
                    case 2:
                        xml_settings.SelectSingleNode("/settings/output/format/ThrowSpecifier").InnerText = write;
                        break;
                    case 3:
                        xml_settings.SelectSingleNode("/settings/output/copymode").InnerText = write;
                        break;
                }

                xml_settings.Save(str_xmlpath);
            }
        }

        public static class Victim
        {
            public static attackcalculator.Victim Read()
            {
                int int_characterId, int_weight;
                bool bool_charging, bool_crouching;

                int_characterId = Convert.ToInt16(xml_settings.SelectSingleNode("/settings/victim/id").InnerText);
                int_weight = Convert.ToInt16(xml_settings.SelectSingleNode("/settings/victim/weight").InnerText);
                bool_charging = Convert.ToBoolean(xml_settings.SelectSingleNode("/settings/victim/charging").InnerText);
                bool_crouching = Convert.ToBoolean(xml_settings.SelectSingleNode("/settings/victim/crouching").InnerText);

                if (int_characterId == 41) // Custom
                    return new attackcalculator.Victim(int_characterId, bool_charging, bool_crouching, int_weight);
                else
                    return new attackcalculator.Victim(int_characterId, bool_charging, bool_crouching);
            }

            public static string returnPercent() => xml_settings.SelectSingleNode("/settings/victim/percent").InnerText;

            public static void Write(attackcalculator.Victim victim, string percent)
            {
                xml_settings.SelectSingleNode("/settings/victim/id").InnerText = victim.CharacterID.ToString();
                if (victim.CharacterID == 41)
                    xml_settings.SelectSingleNode("/settings/victim/weight").InnerText = victim.Weight.ToString();
                xml_settings.SelectSingleNode("/settings/victim/percent").InnerText = percent;
                xml_settings.SelectSingleNode("/settings/victim/charging").InnerText = victim.Charging.ToString().ToLower();
                xml_settings.SelectSingleNode("/settings/victim/crouching").InnerText = victim.Crouching.ToString().ToLower();

                xml_settings.Save(str_xmlpath);
            }
        }
    }
}