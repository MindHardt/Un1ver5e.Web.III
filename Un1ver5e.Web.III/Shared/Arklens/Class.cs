namespace Un1ver5e.Web.III.Shared.Arklens
{
    public record Class : CharacterElement
    {
        public Class(string emoji, string name) : base(emoji, name)
        {
        }

        public static Class Barbarian => new("😡", "Варвар");
        public static Class Bard => new("🪕", "Бард");
        public static Class BookWorm => new("🎓", "Книгочей");
        public static Class Druid => new("🍀", "Друид");
        public static Class Kineticist => new("☄", "Кинетик");
        public static Class Monk => new("🧘‍", "Монах");
        public static Class Paladin => new("🛡", "Паладин");
        public static Class Priest => new("📜", "Жрец");
        public static Class Ranger => new("🦅", "Следопыт");
        public static Class Rogue => new("🗡", "Разбойник");
        public static Class Warrior => new("⚔", "Воин");
        public static Class Wizard => new("📚", "Волшебник");


        public static IEnumerable<Class> AllClasses
            => new[] { Barbarian, Bard, BookWorm, Druid, Kineticist, Monk, Paladin, Priest, Ranger, Rogue, Warrior, Wizard };
    }
}
