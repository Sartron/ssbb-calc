using System;
using System.Text.RegularExpressions;

using System.Diagnostics; //Debug

namespace attackcalculator
{
    public class CollisionParser
    {
        public class PlainText
        {
            public static OffensiveCollision plainToOffensiveCollision(string line)
            {
                int curIntIndex = 0, curFloatIndex = 0;
                int[] int_attributes = new int[10];
                float[] float_attributes = new float[6];

                string[] strAttributes = line.Split(':')[1].Split(',');
                for (int i = 0; i < strAttributes.Length; i++)
                {
                    if (i <= 7 || i == 12 || i == 15)
                    {
                        int_attributes[curIntIndex] = Convert.ToInt32(Regex.Replace(strAttributes[i], @"[^\d\.]", String.Empty));
                        curIntIndex++;
                    }
                    else
                    {
                        //Change it so that it converts the value to float.
                        float_attributes[curFloatIndex] = Convert.ToSingle(Regex.Replace(strAttributes[i], @"[^\d\.]", String.Empty));
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
                        int_attributes[curIntIndex] = Convert.ToInt32(Regex.Replace(str_attributes[i], @"[^\d\.]", String.Empty));
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

        public class BrawlBox
        {
            public static OffensiveCollision deserializeOffensiveCollision(string line)
            {
                string[] str_attributes = line.Split('|');

                if (str_attributes[0].Length != 8)
                    return null;

                int id = 0, bone = 0, damage = 0, shieldDamage = 0, angle = 0, baseKnockback = 0, weightKnockback = 0, knockbackGrowth = 0, flags = 0;
                float size = 0.0f, zOffset = 0.0f, yOffset = 0.0f, xOffset = 0.0f, tripRate = 0.0f, hitlagMultiplier = 0.0f, sdiMultiplier = 0.0f;

                //0-4, 12 = Value
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
                            size = Math.UnScalar(int_value);
                            break;
                        case 6:
                            zOffset = Math.UnScalar(int_value);
                            break;
                        case 7:
                            yOffset = Math.UnScalar(int_value);
                            break;
                        case 8:
                            xOffset = Math.UnScalar(int_value);
                            break;
                        case 9:
                            tripRate = Math.UnScalar(int_value);
                            break;
                        case 10:
                            hitlagMultiplier = Math.UnScalar(int_value);
                            break;
                        case 11:
                            sdiMultiplier = Math.UnScalar(int_value);
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
                            size = Math.UnScalar(int_value);
                            break;
                        case 6:
                            zOffset = Math.UnScalar(int_value);
                            break;
                        case 7:
                            yOffset = Math.UnScalar(int_value);
                            break;
                        case 8:
                            xOffset = Math.UnScalar(int_value);
                            break;
                        case 9:
                            tripRate = Math.UnScalar(int_value);
                            break;
                        case 10:
                            hitlagMultiplier = Math.UnScalar(int_value);
                            break;
                        case 11:
                            sdiMultiplier = Math.UnScalar(int_value);
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

            public static ThrowSpecifier deserializeThrowSpecifier(string line)
            {
                string[] str_attributes = line.Split('|');

                if (str_attributes[0].Length != 8)
                    return null;

                bool bool_unknownE = false, bool_unknownF = false;
                float float_unknownA = 0.0f, float_unknownB = 0.0f, float_unknownC = 0.0f;
                int int_id = 0, int_bone = 0, int_damage = 0, int_angle = 0, int_bkb = 0, int_wdsk = 0, int_kbg = 0, int_element = 0, int_unknownD = 0, int_sfx = 0, int__direction = 0, int_unknownG = 0;

                //0-7, 11-13, 16 = Value
                //8-10 = Scalar
                //14-15 = Boolean

                int int_attributeCount = byte.Parse(str_attributes[0].Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                for (int i = 0; i < int_attributeCount; i++)
                {
                    string[] str_attribute = str_attributes[i + 1].Split('\\');
                    int int_value = int.Parse(str_attribute[1]);

                    switch (i)
                    {
                        case 0:
                            int_id = int_value;
                            break;
                        case 1:
                            int_bone = int_value;
                            break;
                        case 2:
                            int_damage = int_value;
                            break;
                        case 3:
                            int_angle = int_value;
                            break;
                        case 4:
                            int_kbg = int_value;
                            break;
                        case 5:
                            int_wdsk = int_value;
                            break;
                        case 6:
                            int_bkb = int_value;
                            break;
                        case 7:
                            int_element = int_value;
                            break;
                        case 8:
                            float_unknownA = Math.UnScalar(int_value);
                            break;
                        case 9:
                            float_unknownB = Math.UnScalar(int_value);
                            break;
                        case 10:
                            float_unknownC = Math.UnScalar(int_value);
                            break;
                        case 11:
                            int_unknownD = int_value;
                            break;
                        case 12:
                            int_sfx = int_value;
                            break;
                        case 13:
                            int__direction = int_value;
                            break;
                        case 14:
                            bool_unknownE = Convert.ToBoolean(int_value);
                            break;
                        case 15:
                            bool_unknownF = Convert.ToBoolean(int_value);
                            break;
                        case 16:
                            int_unknownG = int_value;
                            break;
                    }
                }

                return new ThrowSpecifier(int_id, int_bone, int_damage, int_angle, int_kbg, int_wdsk, int_bkb, int_element, float_unknownA, float_unknownB, float_unknownC, int_unknownD, int_sfx, 
                    int__direction, bool_unknownE, bool_unknownF, int_unknownG);
            }
        }

        public class PSA
        {
            public static OffensiveCollision deserializeOffensiveCollision(string line)
            {
                string[] str_attributes = line.Split('|');

                if (str_attributes[0].Length != 8)
                    return null;

                int id = 0, bone = 0, damage = 0, shieldDamage = 0, angle = 0, baseKnockback = 0, weightKnockback = 0, knockbackGrowth = 0, flags = 0;
                float size = 0.0f, zOffset = 0.0f, yOffset = 0.0f, xOffset = 0.0f, tripRate = 0.0f, hitlagMultiplier = 0.0f, sdiMultiplier = 0.0f;

                //0-4, 12 = Value
                //5-11 = Scalar

                int int_attributeCount = byte.Parse(str_attributes[0].Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                for (int i = 0; i < int_attributeCount; i++)
                {
                    string[] str_attribute = str_attributes[i + 1].Split('\\');
                    string str_value = str_attribute[1];

                    switch (i)
                    {
                        case 0:
                            bone = Math.UnHex(Math.WordH(str_value, 0));
                            id = Math.UnHex(Math.WordH(str_value, 1));
                            break;
                        case 1:
                            damage = Math.UnHex(str_value);
                            break;
                        case 2:
                            angle = Math.UnHex(str_value);
                            break;
                        case 3:
                            weightKnockback = Math.UnHex(Math.WordH(str_value, 0));
                            knockbackGrowth = Math.UnHex(Math.WordH(str_value, 1));
                            break;
                        case 4:
                            shieldDamage = Math.UnHex(Math.WordH(str_value, 0));
                            baseKnockback = Math.UnHex(Math.WordH(str_value, 1));
                            break;
                        case 5:
                            size = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 6:
                            zOffset = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 7:
                            yOffset = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 8:
                            xOffset = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 9:
                            tripRate = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 10:
                            hitlagMultiplier = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 11:
                            sdiMultiplier = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 12:
                            flags = Convert.ToInt32(Math.UnHex(str_value));
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
                    string str_value = str_attribute[1];

                    switch (i)
                    {
                        case 0:
                            bone = Math.UnHex(Math.WordH(str_value, 0));
                            id = Math.UnHex(Math.WordH(str_value, 1));
                            break;
                        case 1:
                            damage = Math.UnHex(str_value);
                            break;
                        case 2:
                            angle = Math.UnHex(str_value);
                            break;
                        case 3:
                            weightKnockback = Math.UnHex(Math.WordH(str_value, 0));
                            knockbackGrowth = Math.UnHex(Math.WordH(str_value, 1));
                            break;
                        case 4:
                            shieldDamage = Math.UnHex(Math.WordH(str_value, 0));
                            baseKnockback = Math.UnHex(Math.WordH(str_value, 1));
                            break;
                        case 5:
                            size = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 6:
                            zOffset = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 7:
                            yOffset = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 8:
                            xOffset = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 9:
                            tripRate = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 10:
                            hitlagMultiplier = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 11:
                            sdiMultiplier = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 12:
                            flags = Convert.ToInt32(str_value);
                            break;
                        case 13:
                            rehitRate = Convert.ToInt32(str_value);
                            break;
                        case 14:
                            specialFlags = Convert.ToInt32(Math.UnHex(str_value));
                            break;
                    }
                }

                return new SpecialOffensiveCollision(id, bone, damage, shieldDamage, angle, baseKnockback, weightKnockback, knockbackGrowth, size, zOffset, yOffset, xOffset, tripRate, hitlagMultiplier, sdiMultiplier, flags, rehitRate, specialFlags);
            }

            public static ThrowSpecifier deserializeThrowSpecifier(string line)
            {
                string[] str_attributes = line.Split('|');

                if (str_attributes[0].Length != 8)
                    return null;

                bool bool_unknownE = false, bool_unknownF = false;
                float float_unknownA = 0.0f, float_unknownB = 0.0f, float_unknownC = 0.0f;
                int int_id = 0, int_bone = 0, int_damage = 0, int_angle = 0, int_bkb = 0, int_wdsk = 0, int_kbg = 0, int_element = 0, int_unknownD = 0, int_sfx = 0, int__direction = 0, int_unknownG = 0;

                //0-7, 11-13, 16 = Value
                //8-10 = Scalar
                //14-15 = Boolean

                int int_attributeCount = byte.Parse(str_attributes[0].Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                for (int i = 0; i < int_attributeCount; i++)
                {
                    string[] str_attribute = str_attributes[i + 1].Split('\\');
                    string str_value = str_attribute[1];

                    switch (i)
                    {
                        case 0:
                            int_id = Convert.ToInt16(str_value);
                            break;
                        case 1:
                            int_bone = Convert.ToInt16(str_value);
                            break;
                        case 2:
                            int_damage = Math.UnHex(str_value);
                            break;
                        case 3:
                            int_angle = Math.UnHex(str_value);
                            break;
                        case 4:
                            int_kbg = Math.UnHex(str_value);
                            break;
                        case 5:
                            int_wdsk = Math.UnHex(str_value);
                            break;
                        case 6:
                            int_bkb = Math.UnHex(str_value);
                            break;
                        case 7:
                            int_element = Convert.ToInt16(str_value);
                            break;
                        case 8:
                            float_unknownA = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 9:
                            float_unknownB = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 10:
                            float_unknownC = Math.UnScalar(Math.UnHex(str_value));
                            break;
                        case 11:
                            int_unknownD = Math.UnHex(str_value);
                            break;
                        case 12:
                            int_sfx = Math.UnHex(str_value);
                            break;
                        case 13:
                            int__direction = Math.UnHex(str_value);
                            break;
                        case 14:
                            bool_unknownE = Convert.ToBoolean(Math.UnHex(str_value));
                            break;
                        case 15:
                            bool_unknownF = Convert.ToBoolean(Math.UnHex(str_value));
                            break;
                        case 16:
                            int_unknownG = Math.UnHex(str_value);
                            break;
                    }
                }

                return new ThrowSpecifier(int_id, int_bone, int_damage, int_angle, int_kbg, int_wdsk, int_bkb, int_element, float_unknownA, float_unknownB, float_unknownC, int_unknownD, int_sfx,
                    int__direction, bool_unknownE, bool_unknownF, int_unknownG);
            }
        }

        public class Math
        {
            public static float UnScalar(long value) => (float)(value / 60000f);

            public static long Scalar(float value) => value * 60000f < (float)(int.MaxValue) ? Convert.ToInt32(value * 60000f) : int.MaxValue;

            public static string TruncateLeft(string strIn, int totalWidth)
            {
                if (totalWidth <= 0)
                    return String.Empty;

                if (totalWidth > strIn.Length)
                    return strIn;

                return strIn.Substring(strIn.Length - totalWidth);
            }

            public static string Hex(int val) => TruncateLeft(val.ToString("X"), 8);

            public static string Hex(long val) => TruncateLeft(val.ToString("X"), 8);

            public static string Hex8(int val) => TruncateLeft(val.ToString("X"), 8).PadLeft(8, '0');

            public static string Hex8(long val) => TruncateLeft(val.ToString("X"), 8).PadLeft(8, '0');

            public static int UnHex(string val) => int.Parse(val, System.Globalization.NumberStyles.HexNumber);

            public static string WordH(string val, int wordNum)
            {
                if (wordNum >= 2)
                    return String.Empty;

                return TruncateLeft(val, 8).PadLeft(8, '0').Substring(wordNum * 4, 4);
            }
        }
    }
}