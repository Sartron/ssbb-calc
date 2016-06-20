using System;
using System.Diagnostics;

namespace attackcalculator
{
    public class Collision
    {
        protected int int_id, int_bone, int_damage, int_angle, int_bkb, int_wdsk, int_kbg;
        protected Victim _victim;

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

        public void loadVictim(Victim victim)
        {
            _victim = victim;
        }

        /// <summary>Returns the Collision's shieldstun.
        /// </summary>
        public int Shieldstun
        {
            get
            {
                //Floor((Damage + 4.45) / 2.235)
                return Convert.ToInt16(Math.Floor((int_damage + 4.45) / 2.235));
            }
        }

        /// <summary>Returns the Collision's knockback.
        /// </summary>
        public double Knockback
        {
            get
            {
                return (int_wdsk == 0) ? _victim.doubleCharging * _victim.doubleCrouching * (int_bkb + 0.01 * int_kbg * (18 + ((200 / Convert.ToDouble(_victim.Weight + 100)) * 1.4 * 1 * ((int_damage * (int_damage + _victim.Percent) * 0.05) + (int_damage + _victim.Percent) * 0.1)))) : 56;
            }
        }

        /// <summary>Returns the Collision's hitstun.
        /// </summary>
        public int Hitstun
        {
            get
            {
                //Floor(Knockback * 0.4)
                return Convert.ToInt16(Math.Floor(Knockback * 0.4));
            }
        }

        /// <summary>Returns the Collision's launch speed.
        /// </summary>
        public double launchSpeed
        {
            get
            {
                return Knockback * 0.03;
            }
        }

        /// <summary>Returns the Collision data as a string.
        /// </summary>
        public override string ToString() //Copy Text
        {
            return String.Format("Blank Collision: ID={0}", int_id);
        }

        public virtual string ToPSA() { return String.Empty; }

        public virtual string ToBrawlBox() { return String.Empty; }
    }

    public class OffensiveCollision : Collision //Offensive Collision
    {
        //Base Attributes
        private string eventID = "06000D00";
        protected float float_size, float_zOffset, float_yOffset, float_xOffset, float_tripRate, float_hitlagMultiplier, float_sdiMultiplier;
        protected int int_shieldDamage, int_flags;

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
        }

        /// <summary>Returns the hitbox's victim hitlag.
        /// </summary>
        public int hitlag_victim()
        {
            //Floor((Floor(Damage * 0.3333334 + 3) * Electric) * Hitlag Multiplier)
            return Convert.ToInt16(Math.Floor((Math.Floor(int_damage * 0.3333334 + 3) * /*Electric*/(Element == 3 ? 1.5 : 1)) * float_hitlagMultiplier));
        }

        /// <summary>Returns the hitbox's attacker hitlag.
        /// </summary>
        public int hitlag_attacker()
        {
            //Floor(Damage * 0.3333334 + 3) * Hitlag Multiplier
            return Convert.ToInt16(Math.Floor(int_damage * 0.3333334 + 3) * float_hitlagMultiplier);
        }

        #region Flag Calculations
        /// <summary>Returns the hitbox's element.
        /// </summary>
        private int Element
        { get { return int_flags & 0x1F; } }

        /// <summary>Returns whether or not the hitbox can hit grounded opponents.
        /// </summary>
        private bool Grounded
        { get { return Convert.ToBoolean((int_flags >> 16) & 1); } }

        /// <summary>Returns whether or not the hitbox can hit aerial opponents.
        /// </summary>
        private bool Aerial
        { get { return Convert.ToBoolean((int_flags >> 17) & 1); } }

        /// <summary>Returns whether or not the hitbox can clank with other hitboxes.
        /// </summary>
        public bool Clang
        { get { return Convert.ToBoolean((int_flags >> 27) & 1); } }
        #endregion
        #region Copy Functions
        /// <summary>Returns the Hitbox data as a string.
        /// </summary>
        public override string ToString() //Copy Text
        {
            return String.Format("Hitbox: ID={0}, Damage={1}, ShieldDamage={2}, Angle={3}, BaseKnockback={4}, WeightKnockback={5}, KnockbackGrowth={6}, Size={7}, HitlagMultiplier={8}x, SDIMultiplier={9}x, Flags={10}", 
                int_id, int_damage, int_shieldDamage, int_angle, int_bkb, int_wdsk, int_kbg, float_size, float_hitlagMultiplier, float_sdiMultiplier, int_flags);
        }

        /// <summary>Returns the Hitbox data as a serialized string for input into BrawlBox.
        /// </summary>
        public override string ToBrawlBox() //Decimal
        {
            string serializedCode = eventID + "|";
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            for (int i = 0; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 0:
                        serializedCode += "0\\" + (((int_bone & 0xFFFF) << 16) + (int_id & 0xFFFF));
                        break;
                    case 1:
                        serializedCode += "0\\" + int_damage;
                        break;
                    case 2:
                        serializedCode += "0\\" + int_angle;
                        break;
                    case 3:
                        serializedCode += "0\\" + (((int_wdsk & 0xFFFF) << 16) + (int_kbg & 0xFFFF));
                        break;
                    case 4:
                        serializedCode += "0\\" + (((int_shieldDamage & 0xFFFF) << 16) + (int_bkb & 0xFFFF));
                        break;
                    case 5:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_size);
                        break;
                    case 6:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_zOffset);
                        break;
                    case 7:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_yOffset);
                        break;
                    case 8:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_xOffset);
                        break;
                    case 9:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_tripRate);
                        break;
                    case 10:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_hitlagMultiplier);
                        break;
                    case 11:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_sdiMultiplier);
                        break;
                    case 12:
                        serializedCode += "0\\" + int_flags;
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }

        /// <summary>Returns the Hitbox data as a serialized string for input into PSA.
        /// </summary>
        public override string ToPSA() //Hex
        {
            string serializedCode = eventID + "|";
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            for (int i = 0; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 0:
                        serializedCode += String.Format("0\\{0}{1}", int_bone == 0 ? String.Empty : CollisionParser.Math.Hex(int_bone), int_bone == 0 ? String.Empty : CollisionParser.Math.Hex(int_id));
                        break;
                    case 1:
                        serializedCode += "0\\" + CollisionParser.Math.Hex(int_damage);
                        break;
                    case 2:
                        serializedCode += "0\\" + CollisionParser.Math.Hex(int_angle);
                        break;
                    case 3:
                        serializedCode += String.Format("0\\{0}{1}", CollisionParser.Math.Hex(int_wdsk), CollisionParser.Math.Hex(int_kbg));
                        break;
                    case 4:
                        serializedCode += String.Format("0\\{0}{1}", CollisionParser.Math.Hex(int_shieldDamage), CollisionParser.Math.Hex(int_bkb));
                        break;
                    case 5:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(float_size));
                        break;
                    case 6:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(float_zOffset));
                        break;
                    case 7:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(float_yOffset));
                        break;
                    case 8:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(float_xOffset));
                        break;
                    case 9:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(float_tripRate));
                        break;
                    case 10:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(float_hitlagMultiplier));
                        break;
                    case 11:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(float_sdiMultiplier));
                        break;
                    case 12:
                        serializedCode += "0\\" + int_flags;
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }
        #endregion
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
        /// <summary>Returns whether or not the hitbox stretches.
        /// </summary>
        public int Stretches
        { get { return ((int_specialFlags >> 4) & 1); } }

        /// <summary>Returns the hitbit specified by index, ranging from 0-13 (14 total.)
        /// </summary>
        private int GetHitBit(int index)
        { return ((int_specialFlags >> (6 + index)) & 1); } //Max index is 13, starting with 0  CanHitMultiplayerCharacters = 0

        /// <summary>Returns whether or not the hitbox can hit players.
        /// </summary>
        public bool CanHitMultiplayerCharacters
        { get { return Convert.ToBoolean(GetHitBit(0)); } }

        /// <summary>Returns whether or not the hitbox is shieldable.
        /// </summary>
        public int Shieldable
        { get { return ((int_specialFlags >> 22) & 1); } }

        /// <summary>Returns whether or not the hitbox is reflectable.
        /// </summary>
        public int Reflectable
        { get { return ((int_specialFlags >> 23) & 1); } }

        /// <summary>Returns whether or not the hitbox is absorbable.
        /// </summary>
        public int Absorbable
        { get { return ((int_specialFlags >> 24) & 1); } }

        /// <summary>Returns whether or not the hitbox ignores invincibility.
        /// </summary>
        public int IgnoreInvincibility
        { get { return ((int_specialFlags >> 28) & 1); } }

        /// <summary>Returns whether or not the hitbox has hitlag.
        /// </summary>
        public int NoHitlag
        { get { return ((int_specialFlags >> 29) & 1); } }

        /// <summary>Returns whether or not the hitbox places the victim asleep.
        /// </summary>
        public int Sleep
        { get { return ((int_specialFlags >> 30) & 1); } }

        /// <summary>Returns whether or not the hitbox is flinchless.
        /// </summary>
        public int Flinchless
        { get { return ((int_specialFlags >> 31) & 1); } }
        #endregion

        /// <summary>Returns the Hitbox data as a string.
        /// </summary>
        public override string ToString() //Copy Text
        {
            return String.Format(base.ToString() + ", RehitRate={0}, SpecialFlags={1}", int_rehitRate, int_specialFlags);
        }

        /// <summary>Returns the Hitbox data as a serialized string for input into BrawlBox.
        /// </summary>
        public override string ToBrawlBox() //Decimal
        {
            string serializedCode = eventID + "|" + base.ToBrawlBox().Substring(9);
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            Debug.WriteLine(serializedCode);

            for (int i = 13; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 13:
                        serializedCode += "0\\" + int_rehitRate;
                        break;
                    case 14:
                        serializedCode += "0\\" + int_specialFlags;
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }

        /// <summary>Returns the Hitbox data as a serialized string for input into PSA.
        /// </summary>
        public override string ToPSA() //Hex
        {
            string serializedCode = eventID + "|" + base.ToPSA().Substring(9);
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            for (int i = 13; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 13:
                        serializedCode += "0\\" + int_rehitRate;
                        break;
                    case 14:
                        serializedCode += "0\\" + CollisionParser.Math.Hex(int_specialFlags);
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }
    }

    public class ThrowSpecifier : Collision //Throw
    {
        private string eventID = "060E1100";
        private bool bool_unknownE, bool_unknownF;
        private float float_unknownA, float_unknownB, float_unknownC;
        private int int_element, int_unknownD, int_sfx, int__direction, int_unknownG;

        public ThrowSpecifier(int id, int bone, int damage, int angle, int knockbackGrowth, int weightKnockback, int baseKnockback, int element, float unknownA, float unknownB, float unknownC, 
            int unknownD, int sfx, int _direction, bool unknownE, bool unknownF, int unknownG) : base(id, bone, damage, angle, baseKnockback, weightKnockback, knockbackGrowth)
        {
            int_element = element;
            float_unknownA = unknownA;
            float_unknownB = unknownB;
            float_unknownC = unknownC;
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

        /// <summary>Returns the Hitbox data as a serialized string for input into BrawlBox.
        /// </summary>
        public override string ToBrawlBox() //Decimal
        {
            string serializedCode = eventID + "|";
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            //0-7, 11-13, 16-17 = Value
            //8-10 = Scalar
            //14-15 = Boolean

            for (int i = 0; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 0:
                        serializedCode += "0\\" + int_id;
                        break;
                    case 1:
                        serializedCode += "0\\" + int_bone;
                        break;
                    case 2:
                        serializedCode += "0\\" + int_damage;
                        break;
                    case 3:
                        serializedCode += "0\\" + int_angle;
                        break;
                    case 4:
                        serializedCode += "0\\" + int_kbg;
                        break;
                    case 5:
                        serializedCode += "0\\" + int_wdsk;
                        break;
                    case 6:
                        serializedCode += "0\\" + int_bkb;
                        break;
                    case 7:
                        serializedCode += "0\\" + int_element;
                        break;
                    case 8:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_unknownA);
                        break;
                    case 9:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_unknownB);
                        break;
                    case 10:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(float_unknownC);
                        break;
                    case 11:
                        serializedCode += "0\\" + int_unknownD;
                        break;
                    case 12:
                        serializedCode += "0\\" + int_sfx;
                        break;
                    case 13:
                        serializedCode += "0\\" + int__direction;
                        break;
                    case 14:
                        serializedCode += "3\\" + Convert.ToInt16(bool_unknownE);
                        break;
                    case 15:
                        serializedCode += "3\\" + Convert.ToInt16(bool_unknownF);
                        break;
                    case 16:
                        serializedCode += "0\\" + int_unknownG;
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }

        /// <summary>Returns the Hitbox data as a serialized string for input into PSA.
        /// </summary>
        public override string ToPSA() //Hex
        {

            return String.Empty;
        }
    }
}