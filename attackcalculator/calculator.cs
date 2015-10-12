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
        public static bool bool_xmlexists()
        {
            if (File.Exists(Application.StartupPath + "\\settings.xml"))
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
            xml_settings.Save(Application.StartupPath + "\\settings.xml");
        }
    }
}
