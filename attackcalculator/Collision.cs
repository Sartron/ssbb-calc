using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;

namespace attackcalculator
{
    public class Collision
    {
        protected int int_id, int_bone, int_damage, int_angle, int_bkb, int_wdsk, int_kbg;

        public Collision(int id, int bone, int damage, int angle, int baseKnockback, int weightKnockback, int knockbackGrowth)
        {
            int_id = id;
            int_bone = bone;
            int_damage = damage;
            int_angle = angle;
            int_bkb = baseKnockback;
            int_wdsk = weightKnockback;
            int_kbg = knockbackGrowth;
        }

        /// <summary>Returns the Collision data as a string.
        /// </summary>
        public override string ToString() //Copy Text
        {
            return String.Format("Blank Collision: ID={0}", int_id);
        }

        public virtual string toPSA() { return String.Empty; }

        public virtual string toBrawlBox() { return String.Empty; }
    }

    public class OffensiveCollision : Collision //Offensive Collision
    {
        //Base Attributes
        private string eventID = "06000D00";
        protected int int_shieldDamage, int_flags;
        protected float float_size, float_zOffset, float_yOffset, float_xOffset, float_tripRate, float_hitlagMultiplier, float_sdiMultiplier;

        //Flag Attributes
        protected bool bool_clank;
        protected int int_element;
        protected string str_aerialgrounded;

        public OffensiveCollision(int id, int bone, int damage, int shieldDamage, int angle, int baseKnockback, int weightKnockback, int knockbackGrowth, float size, float zOffset,
            float yOffset, float xOffset, float tripRate, float hitlagMultiplier, float sdiMultiplier, int flags) : base(id, bone, damage, angle, baseKnockback, weightKnockback, knockbackGrowth)
        {
            int_shieldDamage = shieldDamage;
            int_flags = flags;
            float_size = size;
            float_zOffset = zOffset;
            float_yOffset = yOffset;
            float_xOffset = xOffset;
            float_tripRate = tripRate;
            float_hitlagMultiplier = hitlagMultiplier;
            float_sdiMultiplier = sdiMultiplier;

            str_aerialgrounded = flagAG(int_flags);
            bool_clank = Convert.ToBoolean(flagClank(int_flags));
            int_element = flagElement(int_flags);
        }

        #region Flag Calculations
        /// <summary>Returns what state (aerial/grounded) targets can be hit in from flag data.
        /// </summary>
        private static string flagAG(int flags)
        {
            //Bit 15 = Aerial
            //Bit 16 = Grounded
            int int_aerialbit = Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(flags)).Substring(14, 1));
            int int_groundedbit = Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(flags)).Substring(15, 1));
            if (!(int_aerialbit == 1 && int_groundedbit == 1))
            {
                //Return both bits if they aren't both 0
                return String.Empty + int_aerialbit + int_groundedbit;
            }
            //Exit function, return nothing as both bits are 1
            return "11";
        }

        /// <summary>Returns whether clank is true or false from flag data.
        /// </summary>
        private bool flagClank(int flags)
        {
            //Convert bit 5 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(flags)).Substring(4, 1)));
        }

        /// <summary>Returns the element index from flag data.
        /// </summary>
        private int flagElement(int flags)
        {
            //Convert bits 28-32 from binary to integer
            return Calculator.Conversions.HexToInt(Calculator.Conversions.BinToHex(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(flags)).Substring(27, 5)));
        }
        #endregion

        /// <summary>Returns the Hitbox data as a string.
        /// </summary>
        public override string ToString() //Copy Text
        {
            return String.Format("Hitbox: ID={0}, Damage={1}, ShieldDamage={2}, Angle={3}, BaseKnockback={4}, WeightKnockback={5}, KnockbackGrowth={6}, Size={7}, HitlagMultiplier={8}x, SDIMultiplier={9}x, Flags={10}", 
                int_id, int_damage, int_shieldDamage, int_angle, int_bkb, int_wdsk, int_kbg, float_size, float_hitlagMultiplier, float_sdiMultiplier, int_flags);
        }

        public override string toBrawlBox() //Decimal
        {
            string serializedCode = eventID + "|";
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            //Opposite of >> 16 is << 32
            //Opposite of & 0xFFFF is ???
            for (int i = 0; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 0:
                        serializedCode += "0\\" + (int_bone << 32);
                        break;
                    case 1:
                        serializedCode += "0\\" + int_damage;
                        break;
                    case 2:
                        serializedCode += "0\\" + int_angle;
                        break;
                    case 3:
                        serializedCode += "0\\" + (int_wdsk << 32);
                        break;
                    case 4:
                        serializedCode += "0\\" + (int_shieldDamage << 32);
                        break;
                    case 5:
                        serializedCode += "1\\" + CollisionParser.Scalar(float_size);
                        break;
                    case 6:
                        serializedCode += "1\\" + CollisionParser.Scalar(float_zOffset);
                        break;
                    case 7:
                        serializedCode += "1\\" + CollisionParser.Scalar(float_yOffset);
                        break;
                    case 8:
                        serializedCode += "1\\" + CollisionParser.Scalar(float_xOffset);
                        break;
                    case 9:
                        serializedCode += "1\\" + CollisionParser.Scalar(float_tripRate);
                        break;
                    case 10:
                        serializedCode += "1\\" + CollisionParser.Scalar(float_hitlagMultiplier);
                        break;
                    case 11:
                        serializedCode += "1\\" + CollisionParser.Scalar(float_sdiMultiplier);
                        break;
                    case 12:
                        serializedCode += "0\\" + int_flags;
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }

        public override string toPSA() //Hex
        {

            return String.Empty;
        }
    }

    public class SpecialOffensiveCollision : OffensiveCollision //Special Offensive Collision
    {
        private string eventID = "06150F00";
        private int int_rehitRate, int_specialFlags;

        public SpecialOffensiveCollision(int id, int bone, int damage, int shieldDamage, int angle, int baseKnockback, int weightKnockback, int knockbackGrowth, float size, float zOffset,
            float yOffset, float xOffset, float tripRate, float hitlagMultiplier, float sdiMultiplier, int flags, int rehitRate, int specialFlags) : base(id, bone, damage, shieldDamage, angle, 
                baseKnockback, weightKnockback, knockbackGrowth, size, zOffset, yOffset, xOffset, tripRate, hitlagMultiplier, sdiMultiplier, flags)
        {
            int_rehitRate = rehitRate;
            int_specialFlags = specialFlags;
        }

        #region Special Flag Calculations
        /// <summary>Returns whether flinchless is true or false from special flag data.
        /// </summary>
        private bool bool_flinch(int specialflags)
        {
            //Convert bit 1 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(specialflags)).Substring(0, 1)));
        }
        /// <summary>Returns whether hitlag is disabled or not from special flag data.
        /// </summary>
        private bool bool_hitlagdisabled(int specialflags)
        {
            //Convert bit 3 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(specialflags)).Substring(2, 1)));
        }
        /// <summary>Returns whether the hitbox is absorbable or not from special flag data.
        /// </summary>
        private bool bool_absorb(int specialflags)
        {
            //Convert bit 8 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(specialflags)).Substring(7, 1)));
        }
        /// <summary>Returns whether the hitbox is reflectable or not from special flag data.
        /// </summary>
        private bool bool_reflect(int specialflags)
        {
            //Convert bit 9 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(specialflags)).Substring(8, 1)));
        }
        /// <summary>Returns whether the hitbox can hit players or not from special flag data.
        /// </summary>
        private bool bool_hitplayer(int specialflags)
        {
            //Convert bit 26 from binary to boolean/integer
            return Convert.ToBoolean(Convert.ToInt16(Calculator.Conversions.HexToBin(Calculator.Conversions.IntToHex(specialflags)).Substring(25, 1)));
        }
        #endregion

        /// <summary>Returns the Hitbox data as a string.
        /// </summary>
        public override string ToString() //Copy Text
        {
            return String.Format(base.ToString() + ", RehitRate={0}, SpecialFlags={1}", int_rehitRate, int_specialFlags);
        }

        public override string toBrawlBox() //Decimal
        {
            string serializedCode = eventID + "|";

            return serializedCode;
        }

        public override string toPSA() //Hex
        {

            return String.Empty;
        }
    }

    public class ThrowSpecifier : Collision //Throw
    {
        private string eventID = "060E1100";
        bool bool_unknownE, bool_unknownF;
        int int_element, int_unknownA, int_unknownB, int_unknownC, int_unknownD, int_sfx, int__direction, int_unknownG;

        public ThrowSpecifier(int id, int bone, int damage, int angle, int knockbackGrowth, int weightKnockback, int baseKnockback, int element, int unknownA, int unknownB, int unknownC, 
            int unknownD, int sfx, int _direction, bool unknownE, bool unknownF, int unknownG) : base(id, bone, damage, angle, baseKnockback, weightKnockback, knockbackGrowth)
        {
            int_element = element;
            int_unknownA = unknownA;
            int_unknownB = unknownB;
            int_unknownC = unknownC;
            int_unknownD = unknownD;
            int_sfx = sfx;
            int__direction = _direction;
            bool_unknownE = unknownE;
            bool_unknownF = unknownF;
            int_unknownG = unknownG;
        }

        /// <summary>Returns the Throw data as a string.
        /// </summary>
        public override string ToString() //Copy Text
        {
            return String.Format("Throw: ID={0}, Damage={1}, Angle={2}, BaseKnockback={3}, WeightKnockback={4}, KnockbackGrowth={5}", int_id, int_damage, int_angle, int_bkb, int_wdsk, int_kbg);
        }

        public override string toBrawlBox() //Decimal
        {
            string serializedCode = eventID + "|";

            return serializedCode;
        }

        public override string toPSA() //Hex
        {

            return String.Empty;
        }
    }
}