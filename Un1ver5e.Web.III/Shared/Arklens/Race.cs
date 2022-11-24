namespace Un1ver5e.Web.III.Shared.Arklens
{
    public class Race : CharacterElement
    {
        public Race(string emoji, string name) : base(emoji, name)
        {
        }
        public static Race Human => new("🧑", "Человек");
        public static Race Elf => new("🧝", "Эльф");
        public static Race Dwarf => new("🧔", "Дварф");
        public static Race Kitsune => new("🦊", "Кицуне");
        public static Race Minas => new("♉", "Минас");
        public static Race Serpent => new("🦎", "Серпент");

        /// <summary>
        /// Enumerates all basic races. They also can be accessed as public properties.
        /// </summary>
        /// <returns></returns>
        public static Race[] All
            => new[] { Human, Elf, Dwarf, Kitsune, Minas, Serpent };
    }
}
