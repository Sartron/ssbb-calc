using System;

using System.Diagnostics; //Debug

namespace attackcalculator
{
    public class Victim
    {
        public int Percent { get; set; }
        public int CharacterID { get; set; }
        public int Weight { get; set; }
        public bool Charging { get; set; }
        public bool Crouching { get; set; }

        public double ChargingValue => Charging ? 1.2 : 1.0;
        public double CrouchingValue => Crouching ? 0.66 : 1.0;

        public Victim(int charId, bool charging, bool crouching) // Default
        {
            CharacterID = charId;
            Weight = getWeight(charId);
            this.Charging = charging;
            this.Crouching = crouching;
        }

        public Victim(int charId, bool charging, bool crouching, int weight) // Custom
        {
            CharacterID = charId; // 41
            this.Weight = weight;
            this.Charging = charging;
            this.Crouching = crouching;
        }

        private static int getWeight(int charId)
        {
            //Debug.WriteLine("getWeight({0}) returned {1}", charId, Convert.ToInt16(attackcalculator.Properties.Resources.weights.Split('\n')[charId]));
            return Convert.ToInt16(attackcalculator.Properties.Resources.weights.Split('\n')[charId]);
        }
    }
}