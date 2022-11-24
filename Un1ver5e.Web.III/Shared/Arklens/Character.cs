using System.Text;

namespace Un1ver5e.Web.III.Shared.Arklens
{
    public record Character
    {
        public Stat Str { get; } = new(8, "💪", "СИЛ");
        public Stat Dex { get; } = new(8, "🏃‍", "ЛВК");
        public Stat Con { get; } = new(8, "🩸", "ВЫН");
        public Stat Int { get; } = new(8, "🧠", "ИНТ");
        public Stat Wis { get; } = new(8, "🦉", "МДР");
        public Stat Cha { get; } = new(8, "👄", "ХАР");
        public Race? Race { get; set; }
        public string? Name { get; set; }
        public Gender? Gender { get; set; }
        public Class? Class { get; set; }

        /// <summary>
        /// Gets all six character stats.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Stat> EnumerateStats()
            => new[] { Str, Dex, Con, Int, Wis, Cha };

        /// <summary>
        /// Sets this <see cref="Character"/>s property with <paramref name="element"/>
        /// according to its type.
        /// </summary>
        /// <param name="element"></param>
        public void Set(CharacterElement? element)
        {
            Action action = element switch
            {
                Gender gender => () => Gender = gender,
                Race race => () => Race = race,
                Class @class => () => Class = @class,
                _ => () => { },
            };
            action();
        }

        public string FillSvgFile(string rawSvg)
            => new StringBuilder(rawSvg)
            .Replace("%STR%", Str.Value.ToString())
            .Replace("%DEX%", Dex.Value.ToString())
            .Replace("%CON%", Con.Value.ToString())
            .Replace("%INT%", Int.Value.ToString())
            .Replace("%WIS%", Wis.Value.ToString())
            .Replace("%CHA%", Cha.Value.ToString())

            .Replace("%STR+%", Str.Modifyer.ToString())
            .Replace("%DEX+%", Dex.Modifyer.ToString())
            .Replace("%CON+%", Con.Modifyer.ToString())
            .Replace("%INT+%", Int.Modifyer.ToString())
            .Replace("%WIS+%", Wis.Modifyer.ToString())
            .Replace("%CHA+%", Cha.Modifyer.ToString())

            .Replace("%RACE%", Race?.ToString())
            .Replace("%GENDER%", Gender?.ToString())
            .Replace("%CLASS%", Class?.ToString())
            .Replace("%NAME%", Name)

            .ToString();
    }
}
