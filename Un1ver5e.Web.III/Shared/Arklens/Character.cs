using System.Text;

namespace Un1ver5e.Web.III.Shared.Arklens
{
    public record Character
    {
        public Stat Str { get; } = new(Stat.MinValue, "💪", "СИЛ");
        public Stat Dex { get; } = new(Stat.MinValue, "🏃‍", "ЛВК");
        public Stat Con { get; } = new(Stat.MinValue, "🩸", "ВЫН");
        public Stat Int { get; } = new(Stat.MinValue, "🧠", "ИНТ");
        public Stat Wis { get; } = new(Stat.MinValue, "🦉", "МДР");
        public Stat Cha { get; } = new(Stat.MinValue, "👄", "ХАР");
        public Race? Race { get; set; }
        public string? Name { get; set; }
        public Gender? Gender { get; set; }
        public Class? Class { get; set; }
        public Alignment? Alignment { get; set; }
        public string? SubClass { get; set; }

        /// <summary>
        /// Gets all six character stats.
        /// </summary>
        /// <returns></returns>
        public Stat[] AllStats
            => new[] { Str, Dex, Con, Int, Wis, Cha };

        private void ApplyRaceImpact()
        {
            ClearRaceImpact();
            var impact = Race?.StatImpact(this);
            if (impact is null) return;
            impact.Value.amp1.RaceAmplified = true;
            impact.Value.amp2.RaceAmplified = true;
            impact.Value.red.RaceAmplified = false;
        }
        public void ClearRaceImpact()
        {
            foreach (Stat stat in AllStats) stat.RaceAmplified = null;
        }

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
                Race race => () => { Race = race; ApplyRaceImpact(); },
                Class @class => () => Class = @class,
                Alignment alignment => () => Alignment = alignment,
                Stat stat => () => AllStats.First(s => s == stat).RaceAmplified = true,
                _ => () => { }
                ,
            };
            action();
        }

        public string FillSvgFile(string rawSvg)
            => new StringBuilder(rawSvg)
            .Replace("%STR%", Str.DisplayValue.ToString())
            .Replace("%DEX%", Dex.DisplayValue.ToString())
            .Replace("%CON%", Con.DisplayValue.ToString())
            .Replace("%INT%", Int.DisplayValue.ToString())
            .Replace("%WIS%", Wis.DisplayValue.ToString())
            .Replace("%CHA%", Cha.DisplayValue.ToString())

            .Replace("%STR+%", Str.DisplayMod.AsMod())
            .Replace("%DEX+%", Dex.DisplayMod.AsMod())
            .Replace("%CON+%", Con.DisplayMod.AsMod())
            .Replace("%INT+%", Int.DisplayMod.AsMod())
            .Replace("%WIS+%", Wis.DisplayMod.AsMod())
            .Replace("%CHA+%", Cha.DisplayMod.AsMod())

            .Replace("%RACE%", Race?.ToString())
            .Replace("%RACETRAIT1%", Race?.Traits?[0])
            .Replace("%RACETRAIT2%", Race?.Traits?[1])

            .Replace("%CLASS%", Class?.ToString())
            .Replace("%SUBCLASS%", SubClass)
            .Replace("%HPGAIN%", (Class?.HpGain + Con.DisplayMod)?.ToString())
            .Replace("%SKILLS%", (Class?.SkillPoints + Int.DisplayMod + (Race == Race.Human ? 1 : 0))?.ToString())
            
            .Replace("%GENDER%", Gender?.ToString())
            .Replace("%NAME%", Name)

            .Replace("%ALIGNMENT%", Alignment?.ToString())

            .ToString();
    }
}
