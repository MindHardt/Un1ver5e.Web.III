﻿namespace Un1ver5e.Web.III.Shared.Arklens
{
    public class Race : CharacterElement
    {
        /// <summary>
        /// Gets stats that get amplified for the character and a stat that gets reduced
        /// or <see langword="null"/> if other behaviour is expected.
        /// </summary>
        public Func<Character, (Stat amp1, Stat amp2, Stat red)?> StatImpact { get; }
        public Race(
            string emoji, 
            string name,
            Func<Character, (Stat amp1, Stat amp2, Stat red)?> statImpact) 
            : base(emoji, name)
        {
            StatImpact = statImpact;
        }

        public static Race Human => new("🧑", "Человек", _ => null);
        public static Race Elf => new("🧝", "Эльф", c => (c.Dex, c.Int, c.Con));
        public static Race Dwarf => new("🧔", "Дварф", c => (c.Con, c.Wis, c.Cha));
        public static Race Kitsune => new("🦊", "Кицуне", c => (c.Dex, c.Cha, c.Str));
        public static Race Minas => new("♉", "Минас", c => (c.Str, c.Con, c.Int));
        public static Race Serpent => new("🦎", "Серпент", c => (c.Con, c.Int, c.Wis));

        /// <summary>
        /// Enumerates all basic races. They also can be accessed as public properties.
        /// </summary>
        /// <returns></returns>
        public static Race[] All
            => new[] { Human, Elf, Dwarf, Kitsune, Minas, Serpent };
    }
}
