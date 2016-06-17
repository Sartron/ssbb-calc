using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.Diagnostics;

namespace attackcalculator
{
    public class CollisionParser
    {
        public static float UnScalar(long value)
        {
            return (float)(value / 60000f);
        }

        public static long Scalar(float value)
        {
            if (value * 60000f < (float)(int.MaxValue))
            {
                return Convert.ToInt32(value * 60000f);
            }
            else
            {
                return int.MaxValue;
            }
        }

        public static string TruncateLeft(string strIn, int totalWidth)
        {
            if (totalWidth <= 0)
            {
                return String.Empty;
            }

            if (totalWidth > strIn.Length)
            {
                return strIn;
            }

            return strIn.Substring(strIn.Length - totalWidth);
        }

        public static string Hex(int val) { return TruncateLeft(val.ToString("X"), 8); }
        public static string Hex(long val) { return TruncateLeft(val.ToString("X"), 8); }
        public static string Hex8(int val) { return TruncateLeft(val.ToString("X"), 8).PadLeft(8, '0'); }
        public static string Hex8(long val) { return TruncateLeft(val.ToString("X"), 8).PadLeft(8, '0'); }
        public static int UnHex(string val) { return int.Parse(val, System.Globalization.NumberStyles.HexNumber); }

        public static OffensiveCollision deserializeOffensiveCollision(string line)
        {
            string[] str_attributes = line.Split('|');

            if (str_attributes[0].Length != 8)
                return null;

            int id = 0, bone = 0, damage = 0, shieldDamage = 0, angle = 0, baseKnockback = 0, weightKnockback = 0, knockbackGrowth = 0, flags = 0;
            float size = 0.0f, zOffset = 0.0f, yOffset = 0.0f, xOffset = 0.0f, tripRate = 0.0f, hitlagMultiplier = 0.0f, sdiMultiplier = 0.0f;

            //0-4, 12 = Value
            //5-11 = Scalar 

            //i < 13 (OffensiveCollision) || i < 15 (SpecialOffensiveCollision) || i < 17 (ThrowSpecifier)
            int int_attributeCount = byte.Parse(str_attributes[0].Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            for (int i = 0; i < int_attributeCount; i++)
            {
                string[] str_attribute = str_attributes[i + 1].Split('\\');
                int int_value = int.Parse(str_attribute[1]);

                switch (i)
                {
                    case 0:
                        bone = (short)((int_value >> 16) & 0xFFFF);
                        id = (short)((int_value) & 0xFFFF);
                        break;
                    case 1:
                        damage = int_value;
                        break;
                    case 2:
                        angle = int_value;
                        break;
                    case 3:
                        weightKnockback = (short)((int_value >> 16) & 0xFFFF);
                        knockbackGrowth = (short)((int_value) & 0xFFFF);
                        break;
                    case 4:
                        shieldDamage = (short)((int_value >> 16) & 0xFFFF);
                        baseKnockback = (short)((int_value) & 0xFFFF);
                        break;
                    case 5:
                        size = UnScalar(int_value);
                        break;
                    case 6:
                        zOffset = UnScalar(int_value);
                        break;
                    case 7:
                        yOffset = UnScalar(int_value);
                        break;
                    case 8:
                        xOffset = UnScalar(int_value);
                        break;
                    case 9:
                        tripRate = UnScalar(int_value);
                        break;
                    case 10:
                        hitlagMultiplier = UnScalar(int_value);
                        break;
                    case 11:
                        sdiMultiplier = UnScalar(int_value);
                        break;
                    case 12:
                        flags = int_value;
                        break;
                }
            }

            return new OffensiveCollision(id, bone, damage, shieldDamage, angle, baseKnockback, weightKnockback, knockbackGrowth, size, zOffset, yOffset, xOffset, tripRate, hitlagMultiplier, sdiMultiplier, flags);
        }

        public static SpecialOffensiveCollision deserializeSpecialOffensiveCollision(string line)
        {
            string[] str_attributes = line.Split('|');

            if (str_attributes[0].Length != 8)
                return null;

            int id = 0, bone = 0, damage = 0, shieldDamage = 0, angle = 0, baseKnockback = 0, weightKnockback = 0, knockbackGrowth = 0, flags = 0, rehitRate = 0, specialFlags = 0;
            float size = 0.0f, zOffset = 0.0f, yOffset = 0.0f, xOffset = 0.0f, tripRate = 0.0f, hitlagMultiplier = 0.0f, sdiMultiplier = 0.0f;

            //0-4, 12-14 = Value
            //5-11 = Scalar 

            int int_attributeCount = byte.Parse(str_attributes[0].Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            for (int i = 0; i < int_attributeCount; i++)
            {
                string[] str_attribute = str_attributes[i + 1].Split('\\');
                int int_value = int.Parse(str_attribute[1]);

                switch (i)
                {
                    case 0:
                        bone = (short)((int_value >> 16) & 0xFFFF);
                        id = (short)((int_value) & 0xFFFF);
                        break;
                    case 1:
                        damage = int_value;
                        break;
                    case 2:
                        angle = int_value;
                        break;
                    case 3:
                        weightKnockback = (short)((int_value >> 16) & 0xFFFF);
                        knockbackGrowth = (short)((int_value) & 0xFFFF);
                        break;
                    case 4:
                        shieldDamage = (short)((int_value >> 16) & 0xFFFF);
                        baseKnockback = (short)((int_value) & 0xFFFF);
                        break;
                    case 5:
                        size = UnScalar(int_value);
                        break;
                    case 6:
                        zOffset = UnScalar(int_value);
                        break;
                    case 7:
                        yOffset = UnScalar(int_value);
                        break;
                    case 8:
                        xOffset = UnScalar(int_value);
                        break;
                    case 9:
                        tripRate = UnScalar(int_value);
                        break;
                    case 10:
                        hitlagMultiplier = UnScalar(int_value);
                        break;
                    case 11:
                        sdiMultiplier = UnScalar(int_value);
                        break;
                    case 12:
                        flags = int_value;
                        break;
                    case 13:
                        rehitRate = int_value;
                        break;
                    case 14:
                        specialFlags = int_value;
                        break;
                }
            }

            return new SpecialOffensiveCollision(id, bone, damage, shieldDamage, angle, baseKnockback, weightKnockback, knockbackGrowth, size, zOffset, yOffset, xOffset, tripRate, hitlagMultiplier, sdiMultiplier, flags, rehitRate, specialFlags);
        }

        public static OffensiveCollision plainToOffensiveCollision(string line)
        {
            int curIntIndex = 0, curFloatIndex = 0;
            int[] int_attributes = new int[10];
            float[] float_attributes = new float[6];

            string[] str_attributes = line.Split(':')[1].Split(',');
            for (int i = 0; i < str_attributes.Length; i++)
            {
                if (i <= 7 || i == 12 || i == 15)
                {
                    int_attributes[curIntIndex] = Convert.ToInt32(Regex.Replace(str_attributes[i], @"[^\d\.]", String.Empty));
                    curIntIndex++;
                }
                else
                {
                    //Change it so that it converts the value to float.
                    float_attributes[curFloatIndex] = Convert.ToSingle(Regex.Replace(str_attributes[i], @"[^\d\.]", String.Empty));
                    curFloatIndex++;
                }
            }

            return new OffensiveCollision(int_attributes[0], int_attributes[1], int_attributes[2], int_attributes[3], int_attributes[4], int_attributes[5], int_attributes[6], int_attributes[7],
                float_attributes[0], float_attributes[1], float_attributes[2], float_attributes[3], int_attributes[8], float_attributes[4], float_attributes[5], int_attributes[9]);
        }

        public static SpecialOffensiveCollision plainToSpecialOffensiveCollision(string line)
        {
            int curIntIndex = 0, curFloatIndex = 0;
            int[] int_attributes = new int[12];
            float[] float_attributes = new float[6];

            string[] str_attributes = line.Split(':')[1].Split(',');
            for (int i = 0; i < str_attributes.Length; i++)
            {
                if (i <= 7 || i == 12 || i >= 15)
                {
                    int_attributes[curIntIndex] = Convert.ToInt32(Regex.Replace(str_attributes[i], @"[^\d\.]", String.Empty));
                    curIntIndex++;
                }
                else
                {
                    //Change it so that it converts the value to float.
                    float_attributes[curFloatIndex] = Convert.ToSingle(Regex.Replace(str_attributes[i], @"[^\d\.]", String.Empty));
                    curFloatIndex++;
                }
            }

            return new SpecialOffensiveCollision(int_attributes[0], int_attributes[1], int_attributes[2], int_attributes[3], int_attributes[4], int_attributes[5], int_attributes[6], int_attributes[7],
                float_attributes[0], float_attributes[1], float_attributes[2], float_attributes[3], int_attributes[8], float_attributes[4], float_attributes[5], int_attributes[9], int_attributes[10], int_attributes[11]);
        }

        public static ThrowSpecifier plainToThrowSpecifier(string line)
        {
            int curIntIndex = 0, curBoolIndex = 0;
            int[] int_attributes = new int[15];
            bool[] bool_attributes = new bool[2];

            string[] str_attributes = line.Split(':')[1].Split(',');
            for (int i = 0; i < str_attributes.Length; i++)
            {
                if (i <= 13 || i >= 16)
                {
                    int_attributes[curIntIndex] = Convert.ToInt16(Regex.Replace(str_attributes[i], @"[^\d\.]", String.Empty));
                    curIntIndex++;
                }
                else
                {
                    bool_attributes[curBoolIndex] = Convert.ToBoolean(Regex.Replace(str_attributes[i], @"\sUnknown.=", String.Empty));
                    curBoolIndex++;
                }
            }

            return new ThrowSpecifier(int_attributes[0], int_attributes[1], int_attributes[2], int_attributes[3], int_attributes[4], int_attributes[5], int_attributes[6], int_attributes[7],
                int_attributes[8], int_attributes[9], int_attributes[10], int_attributes[11], int_attributes[12], int_attributes[13], bool_attributes[0], bool_attributes[1], int_attributes[14]);
        }
    }
}