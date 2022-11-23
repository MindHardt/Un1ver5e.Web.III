namespace Un1ver5e.Web.III.Shared.Arklens
{
    public class Stat
    {
        public string Name { get; }
        public string Emoji { get; }
        /// <summary>
        /// The raw 8..15 value for the stat.
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// The -2..+2 modifyer of the stat.
        /// </summary>
        public int Modifyer => Value / 2 - 5;
        /// <summary>
        /// The point cost of the stat.
        /// </summary>
        public int TotalCost => s_upgradeCosts[Value - minValue];
        /// <summary>
        /// Defines whether a point can be added to this stat.
        /// </summary>
        public bool CanIncrease => Value < maxValue;
        /// <summary>
        /// Attempts to inrease <see cref="Value"/>.
        /// </summary>
        /// <returns><see langword="true"/> if <see cref="Value"/> is increased, 
        /// otherwise <see langword="false"/>.</returns>
        public bool TryIncrease()
        {
            if (CanIncrease)
            {
                Value++;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Attempts to decrease <see cref="Value"/>.
        /// </summary>
        /// <returns><see langword="true"/> if <see cref="Value"/> is decreased, 
        /// otherwise <see langword="false"/>.</returns>
        public bool TryDecrease()
        {
            if (CanDecrease)
            {
                Value--;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Defines whether a point can be removed from the stat.
        /// </summary>
        public bool CanDecrease => Value > minValue;

        public Stat(int value, string name, string emoji)
        {
            if (value < minValue || value > maxValue)
                throw new ArgumentOutOfRangeException($"Value must be in range {minValue}..{maxValue}.");
            Value = value;
            Name = name;
            Emoji = emoji;
        }

        private const int minValue = 8;
        private const int maxValue = 15;
        private static readonly int[] s_upgradeCosts = { 0, 1, 2, 3, 4, 5, 7, 9 };
    }
}
