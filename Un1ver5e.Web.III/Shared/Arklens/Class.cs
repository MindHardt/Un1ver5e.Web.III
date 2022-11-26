namespace Un1ver5e.Web.III.Shared.Arklens
{
    public class Class : CharacterElement
    {
        public int HpGain { get; }
        public int SkillPoints { get; }
        public Class(string emoji, string name, int hpGain, int skillPoints) : base(emoji, name)
        {
            HpGain = hpGain;
            SkillPoints = skillPoints;
        }

        public static Class Barbarian => new("😡", "Варвар", 12, 4);
        public static Class Bard => new("🪕", "Бард", 8, 5);
        public static Class BookWorm => new("🎓", "Книгочей", 6, 6);
        public static Class Druid => new("🍀", "Друид", 8, 3);
        public static Class Kineticist => new("☄", "Кинетик", 10, 3);
        public static Class Monk => new("🧘‍", "Монах", 10, 4);
        public static Class Paladin => new("🛡", "Паладин", 10, 3);
        public static Class Priest => new("📜", "Жрец", 8, 4);
        public static Class Ranger => new("🦅", "Следопыт", 8, 5);
        public static Class Rogue => new("🗡", "Разбойник", 8, 5);
        public static Class Warrior => new("⚔", "Воин", 10, 3);
        public static Class Wizard => new("📚", "Волшебник", 6, 6);


        public static Class[] All
            => new[] { Barbarian, Bard, BookWorm, Druid, Kineticist, Monk, Paladin, Priest, Ranger, Rogue, Warrior, Wizard };
    }
}
