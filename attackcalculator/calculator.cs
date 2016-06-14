using attackcalculator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Calculator
{
    public static class Character
    {
        public static int int_damage;
        public static int int_character, int_weight;
        public static bool bool_charging, bool_crouching;
        private static string ReadLine(string text, int lineNumber)
        {
            //Code by Paul Ruane
            var reader = new StringReader(text);
            string line;
            int currentLineNumber = 0;
            do
            {
                currentLineNumber += 1;
                line = reader.ReadLine();
            }
            while (line != null && currentLineNumber < lineNumber);
            return (currentLineNumber == lineNumber) ? line :
                                                       string.Empty;
        }
        public static void initvictim(int charid, bool charging, bool crouching)
        {
            int_character = charid;
            int_weight = Convert.ToInt16(ReadLine(attackcalculator.Properties.Resources.weights, charid + 1));
            bool_charging = charging;
            bool_crouching = crouching;
        }
    }
    public class Hitbox
    {
        public int int_id, int_damage, int_shielddamage, int_angle, int_bkb, int_wdsk, int_kbg, int_flags, int_rehitrate, int_specialflags;
        public double double_size, double_hitlagmultiplier, double_sdimultiplier;

        public Hitbox(int id, int damage, int shielddamage, int angle, int bkb, int wdsk, int kbg, int flags, int rehitrate, int specialflags, double size, double hitlagmultiplier, double sdimultiplier)
        {
            int_id = id;
            int_damage = damage;
            int_shielddamage = shielddamage;
            int_angle = angle;
            int_bkb = bkb;
            int_wdsk = wdsk;
            int_kbg = kbg;
            int_flags = flags;
            int_rehitrate = rehitrate;
            int_specialflags = specialflags;
            double_size = size;
            double_hitlagmultiplier = hitlagmultiplier;
            double_sdimultiplier = sdimultiplier;
        }

    }
    /*
    public static class Calculations
    {
        #region Calculations
        private static double dec_charging()
        {
            if (Character.bool_charging)
            {
                return 1.2;
            }
            else
            {
                return 1;
            }
        }
        private static double dec_crouching()
        {
            return Character.bool_crouching ? 0.66 : 1;
        }
        private static double dec_electric()
        {
            return Hitbox.int_element(int_flags) == 3 ? 1.5 : 1;
        }
        public static double kb_normal(int int_chardmg)
        {
            return dec_charging() * dec_crouching() * (Hitbox.int_bkb + 0.01 * Hitbox.int_kbg * (18 + ((200 / Convert.ToDouble(Character.int_weight + 100)) * 1.4 * 1 * ((Hitbox.int_damage * (Hitbox.int_damage + int_chardmg) * 0.05) + (Hitbox.int_damage + int_chardmg) * 0.1))));
        }
        public static double kb_wdsk()
        {
            return dec_charging() * dec_crouching() * (Hitbox.int_bkb + 0.01 * Hitbox.int_kbg * (18 + ((200 / Convert.ToDouble(Character.int_weight + 100)) * 1.4 * 1 * (Hitbox.int_wdsk * 10 * 0.05 + 1))));
        }
        public static double kb_weightless(int int_chardmg)
        {
            //Knockback formula that does not factor in character weight.
            //I wrote it in case I wanted to create true minimum hitstun advantages across the entire cast, but this is extremely inaccurate.
            //It might be better to just use Bowsers's weight as a baseline since he has the highest weight in the game, so hitstun can only be higher from his weight.
            //Hitstun advantages overall are kind of pointless, however as they fluctuate extremely quickly.
            //The program isn't even coded to use this formula yet, although it is present in the settings.xml as <weight></weight>.
            return dec_charging() * dec_crouching() * (Hitbox.int_bkb + 0.01 * Hitbox.int_kbg * (18 + (2 * 1.4 * 1 * ((Hitbox.int_damage * (Hitbox.int_damage + int_chardmg) * 0.05) + (Hitbox.int_damage + int_chardmg) * 0.1))));
        }
        public static double launchspeed(double knockback)
        {
            //Knockback * 0.03
            return knockback * 0.03;
        }
        public static int hitstun(double knockback)
        {
            //Floor(Knockback * 0.4)
            return Convert.ToInt16(Math.Floor(knockback * 0.4));
        }
        public static int shieldstun()
        {
            //Floor((Damage + 4.45) / 2.235)
            return Convert.ToInt16(Math.Floor((Hitbox.int_damage + 4.45) / 2.235));
        }
        public static int hitlag_victim()
        {
            //Floor((Floor(Damage * 0.3333334 + 3) * Electric) * Hitlag Multiplier)
            return Convert.ToInt16(Math.Floor((Math.Floor(int_damage * 0.3333334 + 3) * dec_electric()) * Hitbox.double_hitlagmultiplier));
        }
        public static int hitlag_attacker()
        {
            //Floor(Damage * 0.3333334 + 3) * Hitlag Multiplier
            return Convert.ToInt16(Math.Floor(int_damage * 0.3333334 + 3) * double_hitlagmultiplier);
        }
        #endregion

    }
    */
    public static class Conversions
    {
        public static string IntToHex(int number)
        {
            return number.ToString("X");
        }
        public static int HexToInt(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }
        public static string HexToBin(string hex)
        {
            //Hexadecimal to Binary
            if (String.IsNullOrEmpty(hex))
            {
                return String.Empty;
            }
            else
            {
                switch (hex.Length)
                {
                    //Do nothing if length is 8
                    case 7:
                        hex = "0" + hex;
                        break;
                    case 6:
                        hex = "00" + hex;
                        break;
                    case 5:
                        hex = "000" + hex;
                        break;
                    case 4:
                        hex = "0000" + hex;
                        break;
                    case 3:
                        hex = "00000" + hex;
                        break;
                    case 2:
                        hex = "000000" + hex;
                        break;
                    case 1:
                        hex = "0000000" + hex;
                        break;
                }
                string output = String.Empty;
                for (int int_curchar = 0; int_curchar < hex.Length; int_curchar++)
                {
                    string x = hex[int_curchar].ToString();
                    switch (x)
                    {
                        case "0":
                            output = output + "0000";
                            break;
                        case "1":
                            output = output + "0001";
                            break;
                        case "2":
                            output = output + "0010";
                            break;
                        case "3":
                            output = output + "0011";
                            break;
                        case "4":
                            output = output + "0100";
                            break;
                        case "5":
                            output = output + "0101";
                            break;
                        case "6":
                            output = output + "0110";
                            break;
                        case "7":
                            output = output + "0111";
                            break;
                        case "8":
                            output = output + "1000";
                            break;
                        case "9":
                            output = output + "1001";
                            break;
                        case "A":
                            output = output + "1010";
                            break;
                        case "B":
                            output = output + "1011";
                            break;
                        case "C":
                            output = output + "1100";
                            break;
                        case "D":
                            output = output + "1101";
                            break;
                        case "E":
                            output = output + "1110";
                            break;
                        case "F":
                            output = output + "1111";
                            break;
                    }
                }
                return output;
            }
        }
        public static string BinToHex(string bin)
        {
            //Binary to Hexadecimal
            if (String.IsNullOrEmpty(bin))
            {
                return string.Empty;
            }
            else
            {
                return Convert.ToString(Convert.ToInt32(bin, 2), 16).ToUpper();
            }
        }
    }
    public static class Settings
    {
        public static string str_xmlpath = Application.StartupPath + "\\settings.xml";
        public static bool bool_xmlexists()
        {
            if (File.Exists(str_xmlpath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void createxml()
        {
            XmlDocument xml_settings = new XmlDocument();
            xml_settings.LoadXml(attackcalculator.Properties.Resources.settings);
            xml_settings.Save(str_xmlpath);
        }
        public static class Output
        {
            public static void writevariable(int index, bool enabled, string name, int datatype, int print)
            {
                XmlDocument xml_settings = new XmlDocument();
                xml_settings.Load(str_xmlpath);

                XmlNodeList nodes_var = xml_settings.SelectNodes("/settings/output/variables/var");
                int int_curnode = 0;

                foreach (XmlNode var in nodes_var)
                {
                    XmlAttribute attribute_id = var.Attributes["id"];
                    XmlAttribute attribute_enabled = var.Attributes["enabled"];
                    //Run checks to make sure the variables are filled
                    if ((attribute_id != null) && !(Convert.ToInt16(attribute_id.Value) > 22)) //Not null or greater than 22
                    {
                        //Checks to make sure the attributes on var aren't empty/corrupt
                        if ((String.IsNullOrEmpty(attribute_id.Value)) || (Convert.ToInt16(attribute_id.Value) != int_curnode))
                        {
                            //If empty or not equal to int_curnode
                            attribute_id.Value = int_curnode.ToString();
                        }
                        if ((String.IsNullOrEmpty(attribute_enabled.Value)) || !(attribute_enabled.Value == "true" || attribute_enabled.Value == "false"))
                        {
                            //If empty or not equal to true/false then auto set to false
                            attribute_enabled.Value = "false";
                        }

                        //Check if the current variable is equal to index
                        if (int_curnode == index)
                        {
                            //Change the variable on index
                            if (index == 21 || index == 20 || index == 19)
                            {
                                attribute_enabled.Value = enabled.ToString().ToLower();
                                var.SelectSingleNode("name").InnerText = name;
                                var.SelectSingleNode("datatype").InnerText = datatype.ToString();
                                var.SelectSingleNode("print").InnerText = print.ToString();
                            }
                            else if (index == 18 || index == 17 || index == 12)
                            {
                                attribute_enabled.Value = enabled.ToString().ToLower();
                                var.SelectSingleNode("name").InnerText = name;
                                var.SelectSingleNode("print").InnerText = print.ToString();
                            }
                            else if (index == 11)
                            {
                                attribute_enabled.Value = enabled.ToString().ToLower();
                                var.SelectSingleNode("name").InnerText = name;
                                var.SelectSingleNode("datatype").InnerText = datatype.ToString();
                            }
                            else if (index == 5)
                            {
                                attribute_enabled.Value = enabled.ToString().ToLower();
                                var.SelectSingleNode("name").InnerText = name;
                            }
                            else
                            {
                                attribute_enabled.Value = enabled.ToString().ToLower();
                                var.InnerText = name;
                            }
                        }
                    }
                    //Escalate up one variable
                    int_curnode++;
                }

                xml_settings.Save(str_xmlpath);
            }
            public static string readvariable(int index)
            {
                XmlDocument xml_settings = new XmlDocument();
                xml_settings.Load(str_xmlpath);

                XmlNodeList nodes_var = xml_settings.SelectNodes("/settings/output/variables/var");
                int int_curnode = 0;

                foreach (XmlNode var in nodes_var)
                {
                    XmlAttribute attribute_id = var.Attributes["id"];
                    XmlAttribute attribute_enabled = var.Attributes["enabled"];
                    //Run checks to make sure the variables are filled
                    if ((attribute_id != null) && !(Convert.ToInt16(attribute_id.Value) > 22)) //Not null or greater than 22
                    {
                        //Checks to make sure the attributes on var aren't empty/corrupt
                        if ((String.IsNullOrEmpty(attribute_id.Value)) || (Convert.ToInt16(attribute_id.Value) != int_curnode))
                        {
                            //If empty or not equal to int_curnode
                            attribute_id.Value = int_curnode.ToString();
                        }
                        if ((String.IsNullOrEmpty(attribute_enabled.Value)) || !(attribute_enabled.Value == "true" || attribute_enabled.Value == "false"))
                        {
                            //If empty or not equal to true/false then auto set to false
                            attribute_enabled.Value = "false";
                        }

                        //Check if the current variable is equal to index
                        if (int_curnode == index)
                        {
                            //Check if the variables has any extra parameters and then return data
                            switch (index)
                            {
                                case 5:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/-1/-1";
                                case 11:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/" + var.SelectSingleNode("datatype").InnerText + "/-1";
                                case 12:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/-1/" + var.SelectSingleNode("print").InnerText;
                                case 17:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/-1/" + var.SelectSingleNode("print").InnerText;
                                case 18:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/-1/" + var.SelectSingleNode("print").InnerText;
                                case 19:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/" + var.SelectSingleNode("datatype").InnerText + "/" + var.SelectSingleNode("print").InnerText;
                                case 20:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/" + var.SelectSingleNode("datatype").InnerText + "/" + var.SelectSingleNode("print").InnerText;
                                case 21:
                                    return attribute_enabled.Value + "/" + var.SelectSingleNode("name").InnerText + "/" + var.SelectSingleNode("datatype").InnerText + "/" + var.SelectSingleNode("print").InnerText;
                                default:
                                    return attribute_enabled.Value + "/" + var.InnerText + "/-1/-1";
                            }
                        }
                    }
                    //Escalate up one variable
                    int_curnode++;
                }
                xml_settings.Save(str_xmlpath);
                return "error";
            }
            public static void writeformat(string value)
            {
                XmlDocument xml_settings = new XmlDocument();
                xml_settings.Load(str_xmlpath);
                xml_settings.SelectSingleNode("/settings/output/format").InnerText = value;
                xml_settings.Save(str_xmlpath);
            }
            public static string readformat()
            {
                XmlDocument xml_settings = new XmlDocument();
                xml_settings.Load(str_xmlpath);
                return xml_settings.SelectSingleNode("/settings/output/format").InnerText;
            }
        }
        public static class Victim
        {
            public static void writesetting(int setting, string value)
            {
                //Error Check: Make sure I don't put in a stupid setting value
                if (setting > 3)
                {
                    return;
                }
                XmlDocument xml_settings = new XmlDocument();
                xml_settings.Load(str_xmlpath);
                switch (setting)
                {
                    case 0:
                        //damage
                        xml_settings.SelectSingleNode("/settings/victim/damage").InnerText = value;
                        break;
                    case 1:
                        //character
                        xml_settings.SelectSingleNode("/settings/victim/character").InnerText = value;
                        break;
                    case 2:
                        //charging
                        xml_settings.SelectSingleNode("/settings/victim/charging").InnerText = value;
                        break;
                    case 3:
                        //crouching
                        xml_settings.SelectSingleNode("/settings/victim/crouching").InnerText = value;
                        break;
                }
                xml_settings.Save(str_xmlpath);
            }
            public static string readsetting(int setting)
            {
                //Error Check: Make sure I don't put in a stupid setting value
                if (setting > 3)
                {
                    return "error";
                }
                XmlDocument xml_settings = new XmlDocument();
                xml_settings.Load(str_xmlpath);
                switch (setting)
                {
                    case 0:
                        //damage
                        return xml_settings.SelectSingleNode("/settings/victim/damage").InnerText;
                    case 1:
                        //character
                        return xml_settings.SelectSingleNode("/settings/victim/character").InnerText;
                    case 2:
                        //charging
                        return xml_settings.SelectSingleNode("/settings/victim/charging").InnerText;
                    case 3:
                        //crouching
                        return xml_settings.SelectSingleNode("/settings/victim/crouching").InnerText;
                }
                xml_settings.Save(str_xmlpath);
                return "error";
            }
        }
    }
}
