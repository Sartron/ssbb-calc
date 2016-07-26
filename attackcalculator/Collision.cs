using System;

namespace attackcalculator
{
    public class Collision : object
    {
        public int ID { get; set; }
        public int Bone { get; set; }
        public int Damage { get; set; }
        public int Angle { get; set; }
        public int BaseKnockback { get; set; }
        public int WeightKnockback { get; set; }
        public int KnockbackGrowth { get; set; }
        public Victim Victim { get; set; }

        public Collision(int id, int bone, int damage, int angle, int baseKnockback, int weightKnockback, int knockbackGrowth)
        {
            ID = id;
            Bone = bone;
            Damage = damage;
            Angle = angle;
            BaseKnockback = baseKnockback;
            WeightKnockback = weightKnockback;
            KnockbackGrowth = knockbackGrowth;
        }

        /// <summary>Returns the Collision's shieldstun.
        /// Formula: Floor((Damage + 4.45) / 2.235)
        /// </summary>
        public int Shieldstun => Convert.ToInt16(Math.Floor((Damage + 4.45) / 2.235));

        /// <summary>Returns the Collision's knockback.
        /// </summary>
        public double Knockback
        {
            get
            {
                if (Victim == null)
                    return -1;
                
                return WeightKnockback == 0 ?
                    Victim.ChargingValue * Victim.CrouchingValue * (BaseKnockback + 0.01 * KnockbackGrowth * (18 + 200 / Convert.ToDouble(Victim.Weight + 100) * 1.4 * 1 * (Damage * (Damage + Victim.Percent) * 0.05 + (Damage + Victim.Percent) * 0.1))) : // Normal Knockback
                    Victim.ChargingValue * Victim.CrouchingValue * (BaseKnockback + 0.01 * KnockbackGrowth * (18 + 200 / Convert.ToDouble(Victim.Weight + 100) * 1.4 * 1 * Convert.ToDouble(WeightKnockback * 10 * 0.05 + 1))); //Weight Dependent Knockback
            }
        }

        /// <summary>Returns the Collision's hitstun.
        /// </summary>
        public int Hitstun
        {
            get
            {
                if (Victim == null)
                    return -1;

                //Floor(Knockback * 0.4)
                return Convert.ToInt16(Math.Floor(Knockback * 0.4));
            }
        }

        /// <summary>Returns the Collision's launch speed.
        /// Formula: Knockback * 0.03
        /// </summary>
        public double launchSpeed => Knockback * 0.03;

        /// <summary>Returns the Collision data as a string.
        /// </summary>
        public override string ToString() => String.Format("Blank Collision: ID={0}", ID);

        /// <summary>Virtual Placeholder
        /// </summary>
        public virtual string ToBrawlBox() => String.Empty;

        /// <summary>Virtual Placeholder
        /// </summary>
        public virtual string ToPSA() => String.Empty;
    }

    public class OffensiveCollision : Collision //Offensive Collision
    {
        private const string eventID = "06000D00";

        public float Size { get; set; }
        public float ZOffset { get; set; }
        public float YOffset { get; set; }
        public float XOffset { get; set; }
        public float TripRate { get; set; }
        public float HitlagMultiplier { get; set; }
        public float SdiMultiplier { get; set; }
        public int ShieldDamage { get; set; }
        public int Flags { get; set; }

        public OffensiveCollision(int id, int bone, int damage, int shieldDamage, int angle, int baseKnockback, int weightKnockback, int knockbackGrowth, float size, float zOffset,
            float yOffset, float xOffset, float tripRate, float hitlagMultiplier, float sdiMultiplier, int flags) : base(id, bone, damage, angle, baseKnockback, weightKnockback, knockbackGrowth)
        {
            ShieldDamage = shieldDamage;
            Flags = flags;
            Size = size;
            ZOffset = zOffset;
            YOffset = yOffset;
            XOffset = xOffset;
            TripRate = tripRate;
            HitlagMultiplier = hitlagMultiplier;
            SdiMultiplier = sdiMultiplier;
        }

        /// <summary>Returns the hitbox's victim hitlag.
        /// Formula: Floor((Floor(Damage * 0.3333334 + 3) * Electric) * Hitlag Multiplier)
        /// </summary>
        public int HitlagVictim => Convert.ToInt16(Math.Floor(Math.Floor(Damage * 0.3333334 + 3) * (EffectID == 3 ? 1.5 : 1) * HitlagMultiplier));

        /// <summary>Returns the hitbox's attacker hitlag.
        /// Formula: Floor(Damage * 0.3333334 + 3) * Hitlag Multiplier
        /// </summary>
        public int HitlagAttacker => Convert.ToInt16(Math.Floor(Damage * 0.3333334 + 3) * HitlagMultiplier);

        #region Flag Calculations
        /// <summary>String representation of EffectID
        /// </summary>
        public enum HitboxEffect { Normal, None, Slash, Electric, Freezing, Flame, Coin, Reverse, Slip, Sleep, Effect10, Bury, Stun, Light/*Effect13*/, Flower, GreenFlame/*Effect15*/, Effect16, Grass, Water, Darkness, Paralyze, Aura, Plunge, Down, Flinchless, Effect25, Effect26, Effect27, Effect28, Effect29, Effect30, Effect31 }

        /// <summary>Returns the hitbox's effect ID.
        /// </summary>
        private int EffectID => Flags & 0x1F;

        /// <summary>Returns the hitbox's element.
        /// </summary>
        public HitboxEffect Effect => (HitboxEffect)EffectID;

        /// <summary>String representation of Grounded/Aerial flags
        /// </summary>
        public enum HitboxTarget { All, Aerial, Grounded, None }

        /// <summary>Returns the hitbox's target, taking into account normal Hitbox flags.
        /// </summary>
        public HitboxTarget Target
        {
            get
            {
                if (Aerial && Grounded)
                {
                    return 0;
                }
                if (Aerial && !Grounded)
                {
                    return (HitboxTarget)1;
                }
                if (!Aerial && Grounded)
                {
                    return (HitboxTarget)2;
                }
                return (HitboxTarget)3;
            }
        }

        /// <summary>Returns whether or not the hitbox can hit grounded opponents.
        /// </summary>
        private bool Grounded => Convert.ToBoolean((Flags >> 16) & 1);

        /// <summary>Returns whether or not the hitbox can hit aerial opponents.
        /// </summary>
        private bool Aerial => Convert.ToBoolean((Flags >> 17) & 1);

        /// <summary>Returns whether or not the hitbox can clank with other hitboxes.
        /// </summary>
        public bool Clang => Convert.ToBoolean((Flags >> 27) & 1);
        #endregion
        #region Copy Functions
        /// <summary>Returns the Hitbox data as a string.
        /// </summary>
        public override string ToString() => String.Format("Hitbox: ID={0}, Damage={1}, ShieldDamage={2}, Angle={3}, BaseKnockback={4}, WeightKnockback={5}, KnockbackGrowth={6}, Size={7}, HitlagMultiplier={8}x, SDIMultiplier={9}x, Flags={10}", 
                ID, Damage, ShieldDamage, Angle, BaseKnockback, WeightKnockback, KnockbackGrowth, Size, HitlagMultiplier, SdiMultiplier, Flags);

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
                        serializedCode += "0\\" + (((Bone & 0xFFFF) << 16) + (ID & 0xFFFF));
                        break;
                    case 1:
                        serializedCode += "0\\" + Damage;
                        break;
                    case 2:
                        serializedCode += "0\\" + Angle;
                        break;
                    case 3:
                        serializedCode += "0\\" + (((WeightKnockback & 0xFFFF) << 16) + (KnockbackGrowth & 0xFFFF));
                        break;
                    case 4:
                        serializedCode += "0\\" + (((ShieldDamage & 0xFFFF) << 16) + (BaseKnockback & 0xFFFF));
                        break;
                    case 5:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(Size);
                        break;
                    case 6:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(ZOffset);
                        break;
                    case 7:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(YOffset);
                        break;
                    case 8:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(XOffset);
                        break;
                    case 9:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(TripRate);
                        break;
                    case 10:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(HitlagMultiplier);
                        break;
                    case 11:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(SdiMultiplier);
                        break;
                    case 12:
                        serializedCode += "0\\" + Flags;
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
            return String.Empty; //Dead Code

            string serializedCode = eventID + "|";
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            for (int i = 0; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 0:
                        serializedCode += String.Format("0\\{0}{1}", Bone == 0 ? String.Empty : CollisionParser.Math.Hex(Bone), Bone == 0 ? String.Empty : CollisionParser.Math.Hex(ID));
                        break;
                    case 1:
                        serializedCode += "0\\" + CollisionParser.Math.Hex(Damage);
                        break;
                    case 2:
                        serializedCode += "0\\" + CollisionParser.Math.Hex(Angle);
                        break;
                    case 3:
                        serializedCode += String.Format("0\\{0}{1}", CollisionParser.Math.Hex(WeightKnockback), CollisionParser.Math.Hex(KnockbackGrowth));
                        break;
                    case 4:
                        serializedCode += String.Format("0\\{0}{1}", CollisionParser.Math.Hex(ShieldDamage), CollisionParser.Math.Hex(BaseKnockback));
                        break;
                    case 5:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(Size));
                        break;
                    case 6:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(ZOffset));
                        break;
                    case 7:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(YOffset));
                        break;
                    case 8:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(XOffset));
                        break;
                    case 9:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(TripRate));
                        break;
                    case 10:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(HitlagMultiplier));
                        break;
                    case 11:
                        serializedCode += "1\\" + CollisionParser.Math.Hex(CollisionParser.Math.Scalar(SdiMultiplier));
                        break;
                    case 12:
                        serializedCode += "0\\" + Flags;
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            OffensiveCollision comparison = (OffensiveCollision)obj;

            return (ID == comparison.ID) && (Bone == comparison.Bone) && (Damage == comparison.Damage) && (ShieldDamage == comparison.ShieldDamage) &&
                (Angle == comparison.Angle) && (BaseKnockback == comparison.BaseKnockback) && (WeightKnockback == comparison.WeightKnockback) && (KnockbackGrowth == comparison.KnockbackGrowth) && (Size == comparison.Size) &&
                (ZOffset == comparison.ZOffset) && (YOffset == comparison.YOffset) && (XOffset == comparison.XOffset) && (TripRate == comparison.TripRate) &&
                (HitlagMultiplier == comparison.HitlagMultiplier) && (SdiMultiplier == comparison.SdiMultiplier) && (Flags == comparison.Flags);
        }
    }

    public class SpecialOffensiveCollision : OffensiveCollision //Special Offensive Collision
    {
        private const string eventID = "06150F00";

        public int RehitRate { get; set; }
        public int SpecialFlags { get; set; }

        public SpecialOffensiveCollision(int id, int bone, int damage, int shieldDamage, int angle, int baseKnockback, int weightKnockback, int knockbackGrowth, float size, float zOffset,
            float yOffset, float xOffset, float tripRate, float hitlagMultiplier, float sdiMultiplier, int flags, int rehitRate, int specialFlags) : base(id, bone, damage, shieldDamage, angle, 
                baseKnockback, weightKnockback, knockbackGrowth, size, zOffset, yOffset, xOffset, tripRate, hitlagMultiplier, sdiMultiplier, flags)
        {
            RehitRate = rehitRate;
            SpecialFlags = specialFlags;
        }

        #region Special Flag Calculations
        /// <summary>Returns whether or not the hitbox stretches.
        /// </summary>
        public int Stretches => (SpecialFlags >> 4) & 1;

        /// <summary>String representation of Grounded/Aerial flags
        /// </summary>
        public new enum HitboxTarget { All, Aerial, Grounded, None, SSE }

        /// <summary>Returns the hitbox's target, taking into account special Hit Flags.
        /// </summary>
        public new HitboxTarget Target
        {
            get
            {
                if (!CanHitMultiplayerCharacters)
                {
                    if (CanHitSSEenemies)
                        return (HitboxTarget)4;
                    else
                        return (HitboxTarget)3;
                }
                else
                {
                    return (HitboxTarget)base.Target;
                }
            }
        }

        /// <summary>Returns the hitbit specified by index, ranging from 0-13 (14 total.)
        /// Max index is 13, starting with 0
        /// </summary>
        private int GetHitBit(int index) => (SpecialFlags >> (6 + index)) & 1;

        /// <summary>Returns whether or not the hitbox can hit players.
        /// </summary>
        public bool CanHitMultiplayerCharacters => Convert.ToBoolean(GetHitBit(0));

        /// <summary>Returns whether or not the hitbox can SSE enemies.
        /// </summary>
        public bool CanHitSSEenemies => Convert.ToBoolean(GetHitBit(1));

        /// <summary>Returns whether or not the hitbox is shieldable.
        /// </summary>
        public bool Shieldable => Convert.ToBoolean((SpecialFlags >> 22) & 1);

        /// <summary>Returns whether or not the hitbox is reflectable.
        /// </summary>
        public bool Reflectable => Convert.ToBoolean((SpecialFlags >> 23) & 1);

        /// <summary>Returns whether or not the hitbox is absorbable.
        /// </summary>
        public bool Absorbable => Convert.ToBoolean((SpecialFlags >> 24) & 1);

        /// <summary>Returns whether or not the hitbox ignores invincibility.
        /// </summary>
        public bool IgnoreInvincibility => Convert.ToBoolean((SpecialFlags >> 28) & 1);

        /// <summary>Returns whether or not the hitbox has hitlag.
        /// </summary>
        public bool NoHitlag => Convert.ToBoolean((SpecialFlags >> 29) & 1);

        /// <summary>Returns whether or not the hitbox places the victim asleep.
        /// </summary>
        public bool Sleep => Convert.ToBoolean((SpecialFlags >> 30) & 1);

        /// <summary>Returns whether or not the hitbox is flinchless.
        /// </summary>
        public bool Flinchless => Convert.ToBoolean((SpecialFlags >> 31) & 1);
        #endregion
        #region Copy Functions
        /// <summary>Returns the Hitbox data as a string.
        /// </summary>
        public override string ToString() => String.Format(base.ToString() + ", RehitRate={0}, SpecialFlags={1}", RehitRate, SpecialFlags);

        /// <summary>Returns the Hitbox data as a serialized string for input into BrawlBox.
        /// </summary>
        public override string ToBrawlBox() //Decimal
        {
            string serializedCode = eventID + "|" + base.ToBrawlBox().Substring(9);
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            for (int i = 13; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 13:
                        serializedCode += "0\\" + RehitRate;
                        break;
                    case 14:
                        serializedCode += "0\\" + SpecialFlags;
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
            return String.Empty; //Dead Code

            string serializedCode = eventID + "|" + base.ToPSA().Substring(9);
            int int_attributeCount = byte.Parse(eventID.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            for (int i = 13; i < int_attributeCount; i++)
            {
                switch (i)
                {
                    case 13:
                        serializedCode += "0\\" + RehitRate;
                        break;
                    case 14:
                        serializedCode += "0\\" + CollisionParser.Math.Hex(SpecialFlags);
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            SpecialOffensiveCollision comparison = (SpecialOffensiveCollision)obj;

            return (ID == comparison.ID) && (Bone == comparison.Bone) && (Damage == comparison.Damage) && (ShieldDamage == comparison.ShieldDamage) &&
                (Angle == comparison.Angle) && (BaseKnockback == comparison.BaseKnockback) && (WeightKnockback == comparison.WeightKnockback) && (KnockbackGrowth == comparison.KnockbackGrowth) && (Size == comparison.Size) &&
                (ZOffset == comparison.ZOffset) && (YOffset == comparison.YOffset) && (XOffset == comparison.XOffset) && (TripRate == comparison.TripRate) &&
                (HitlagMultiplier == comparison.HitlagMultiplier) && (SdiMultiplier == comparison.SdiMultiplier) && (Flags == comparison.Flags) && (RehitRate == comparison.RehitRate) &&
                (SpecialFlags == comparison.SpecialFlags);
        }
    }

    public class ThrowSpecifier : Collision //Throw
    {
        private string eventID = "060E1100";

        public bool UnknownE { get; set; }
        public bool UnknownF { get; set; }
        public float UnknownA { get; set; }
        public float UnknownB { get; set; }
        public float UnknownC { get; set; }
        public int Element { get; set; }
        public int UnknownD { get; set; }
        public int SFX { get; set; }
        public int Direction { get; set; }
        public int UnknownG { get; set; }

        public ThrowSpecifier(int id, int bone, int damage, int angle, int knockbackGrowth, int weightKnockback, int baseKnockback, int element, float unknownA, float unknownB, float unknownC, 
            int unknownD, int sfx, int direction, bool unknownE, bool unknownF, int unknownG) : base(id, bone, damage, angle, baseKnockback, weightKnockback, knockbackGrowth)
        {
            Element = element;
            UnknownA = unknownA;
            UnknownB = unknownB;
            UnknownC = unknownC;
            UnknownD = unknownD;
            SFX = sfx;
            Direction = direction;
            UnknownE = unknownE;
            UnknownF = unknownF;
            UnknownG = unknownG;
        }

        /// <summary>Returns the Throw data as a string.
        /// </summary>
        public override string ToString() => String.Format("Throw: ID={0}, Damage={1}, Angle={2}, BaseKnockback={3}, WeightKnockback={4}, KnockbackGrowth={5}", ID, Damage, Angle, BaseKnockback, WeightKnockback, KnockbackGrowth);

        /// <summary>Returns the Hitbox data as a serialized string for input into BrawlBox.
        /// </summary>
        public override string ToBrawlBox()
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
                        serializedCode += "0\\" + ID;
                        break;
                    case 1:
                        serializedCode += "0\\" + Bone;
                        break;
                    case 2:
                        serializedCode += "0\\" + Damage;
                        break;
                    case 3:
                        serializedCode += "0\\" + Angle;
                        break;
                    case 4:
                        serializedCode += "0\\" + KnockbackGrowth;
                        break;
                    case 5:
                        serializedCode += "0\\" + WeightKnockback;
                        break;
                    case 6:
                        serializedCode += "0\\" + BaseKnockback;
                        break;
                    case 7:
                        serializedCode += "0\\" + Element;
                        break;
                    case 8:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(UnknownA);
                        break;
                    case 9:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(UnknownB);
                        break;
                    case 10:
                        serializedCode += "1\\" + CollisionParser.Math.Scalar(UnknownC);
                        break;
                    case 11:
                        serializedCode += "0\\" + UnknownD;
                        break;
                    case 12:
                        serializedCode += "0\\" + SFX;
                        break;
                    case 13:
                        serializedCode += "0\\" + Direction;
                        break;
                    case 14:
                        serializedCode += "3\\" + Convert.ToInt16(UnknownE);
                        break;
                    case 15:
                        serializedCode += "3\\" + Convert.ToInt16(UnknownF);
                        break;
                    case 16:
                        serializedCode += "0\\" + UnknownG;
                        break;
                }
                serializedCode += '|';
            }

            return serializedCode;
        }

        /// <summary>Returns the Hitbox data as a serialized string for input into PSA.
        /// </summary>
        public override string ToPSA()
        {
            return String.Empty; //Dead Code
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ThrowSpecifier comparison = (ThrowSpecifier)obj;

            return (ID == comparison.ID) && (Bone == comparison.Bone) && (Damage == comparison.Damage) && (Angle == comparison.Angle) &&
                (KnockbackGrowth == comparison.KnockbackGrowth) && (WeightKnockback == comparison.WeightKnockback) && (BaseKnockback == comparison.BaseKnockback) && (Element == comparison.Element) &&
                (UnknownA == comparison.UnknownA) && (UnknownB == comparison.UnknownB) && (UnknownC == comparison.UnknownC) &&
                (UnknownD == comparison.UnknownD) && (SFX == comparison.SFX) && (Direction == comparison.Direction) && (UnknownE == comparison.UnknownE) &&
                (UnknownF == comparison.UnknownF) && (UnknownG == comparison.UnknownG);
        }
    }
}