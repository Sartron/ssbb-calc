﻿using attackcalculator.Properties;
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
        public static int[] int_damage;
        public static int int_character;
        public static bool bool_charging, bool_crouching;
    }
    public class Hitbox
    {
        public static int int_damage, int_shielddamage, int_angle, int_bkb, int_wdsk, int_kbg, int_hitlagmultiplier, int_sdimultiplier, int_flags, int_rehitrate, int_specialflags;
        public static double double_size;
        public static string int_aerialgrounded(int flags)
        {
            //Bit 15 = Aerial
            //Bit 16 = Grounded
            int int_aerialbit = Convert.ToInt16(Conversions.HexToBin(Conversions.IntToHex(flags)).Substring(14, 1));
            int int_groundedbit = Convert.ToInt16(Conversions.HexToBin(Conversions.IntToHex(flags)).Substring(15, 1));
            if (!((int_aerialbit == 1) && (int_groundedbit == 1)))
            {
                //Return both bits if they aren't both 0
                return String.Empty + int_aerialbit + int_groundedbit;
            }
            //Exit function, return nothing as both bits are 1
            return "11";
        }
        public static bool bool_clank(int flags)
        {
            //Convert bit 5 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Conversions.HexToBin(Conversions.IntToHex(flags)).Substring(4, 1)));
        }
        public static int int_element(int flags)
        {
            //Convert bits 28-32 from binary to integer
            return Conversions.HexToInt(Conversions.BinToHex(Conversions.HexToBin(Conversions.IntToHex(flags)).Substring(27, 5)));
        }
        public static bool bool_absorb(int specialflags)
        {
            //Convert bit 8 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Conversions.HexToBin(Conversions.IntToHex(specialflags)).Substring(7, 1)));
        }
        public static bool bool_reflect(int specialflags)
        {
            //Convert bit 9 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Conversions.HexToBin(Conversions.IntToHex(specialflags)).Substring(8, 1)));
        }
        public static bool bool_hitplayer(int specialflags)
        {
            //Convert bit 26 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Conversions.HexToBin(Conversions.IntToHex(specialflags)).Substring(25, 1)));
        }
    }
    public static class Calculations
    {

    }
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
            public static void writevariable(int index, bool enabled, string name)
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
                    if ((attribute_id != null) && !(Convert.ToInt16(attribute_id.Value) > 19))
                    {
                        ////Debug
                        //Console.WriteLine("ID: " + attribute_id.Value + "\nEnabled: " + attribute_enabled.Value + "\nName: " + var.InnerText + "\n");

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
                            attribute_enabled.Value = enabled.ToString().ToLower();
                            var.InnerText = name;
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
                    if ((attribute_id != null) && !(Convert.ToInt16(attribute_id.Value) > 19))
                    {
                        ////Debug
                        //Console.WriteLine("ID: " + attribute_id.Value + "\nEnabled: " + attribute_enabled.Value + "\nName: " + var.InnerText + "\n");

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
                            //Return enabled state and name
                            return attribute_enabled.Value + "/" + var.InnerText;
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
                        break;
                    case 1:
                        //character
                        return xml_settings.SelectSingleNode("/settings/victim/character").InnerText;
                        break;
                    case 2:
                        //charging
                        return xml_settings.SelectSingleNode("/settings/victim/charging").InnerText;
                        break;
                    case 3:
                        //crouching
                        return xml_settings.SelectSingleNode("/settings/victim/crouching").InnerText;
                        break;
                }
                xml_settings.Save(str_xmlpath);
                return "error";
            }
        }
    }

}
