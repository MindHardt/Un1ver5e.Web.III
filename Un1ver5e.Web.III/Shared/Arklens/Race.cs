namespace Un1ver5e.Web.III.Shared.Arklens
{
    public record Race
    {
        public string Name { get; }
        public string Emoji { get; }
        public Race(string name, string emoji)
        {
            Name = name;
            Emoji = emoji;
        }
        /// <summary>
        /// Formats this <see cref="Race"/> as a <see langword="string"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => $"{Emoji} {Name}";

        public static Race Human => new("Человек", "🧑");
        public static Race Elf => new("Эльф", "🧝");
        public static Race Dwarf => new("Дварф", "🧔");
        public static Race Kitsune => new("Кицуне", "🦊");
        public static Race Minas => new("Минас", "♉");
        public static Race Serpent => new("Серпент", "🦎");

        /// <summary>
        /// Enumerates all basic races. They also can be accessed as public properties.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Race> BasicRaces
            => new[] { Human, Elf, Dwarf, Kitsune, Minas, Serpent };
    }
}
