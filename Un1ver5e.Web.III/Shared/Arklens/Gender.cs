namespace Un1ver5e.Web.III.Shared.Arklens
{
    public class Gender
    {
        public string Emoji { get; }
        public string Name { get; }

        public override string? ToString()
            => $"{Emoji} {Name}";

        public static Gender Female => new("🚺", "Женский");
        public static Gender Male => new("🚹", "Мужской");
        public static IEnumerable<Gender> AllGenders
            => new[] { Male, Female };

        private Gender(string emoji, string name)
        {
            Emoji = emoji;
            Name = name;
        }
    }
}
