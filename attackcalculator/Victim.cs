using System;
using System.Diagnostics;
using System.IO;

namespace attackcalculator
{
    public class Victim
    {
        private int int_percent, int_characterId, int_weight;
        private bool bool_charging, bool_crouching;

        public int ID
        {
            get
            {
                return int_characterId;
            }
            set
            {
                int_characterId = value;
            }
        }

        public int Weight
        {
            get
            {
                return int_weight;
            }
            set
            {
                int_weight = value;
            }
        }

        public int Percent
        {
            get
            {
                return int_percent;
            }
            set
            {
                int_percent = value;
            }
        }

        public bool Charging
        {
            get
            {
                return bool_charging;
            }
            set
            {
                bool_charging = value;
            }
        }

        public bool Crouching
        {
            get
            {
                return bool_crouching;
            }
            set
            {
                bool_crouching = value;
            }
        }

        public double doubleCharging
        {
            get
            {
                return (bool_charging) ? 1.2 : 1.0;
            }
        }

        public double doubleCrouching
        {
            get
            {
                return bool_crouching ? 0.66 : 1.0;
            }
        }

        public Victim(int charId, bool charging, bool crouching) // Default
        {
            int_characterId = charId;
            int_weight = getWeight(charId);
            bool_charging = charging;
            bool_crouching = crouching;
        }

        public Victim(int charId, bool charging, bool crouching, int weight) // Custom
        {
            int_characterId = charId; // 41
            int_weight = weight;
            bool_charging = charging;
            bool_crouching = crouching;
        }

        private static int getWeight(int charId)
        {
            return Convert.ToInt16(attackcalculator.Properties.Resources.weights.Split('\n')[charId]);
        }
    }
}