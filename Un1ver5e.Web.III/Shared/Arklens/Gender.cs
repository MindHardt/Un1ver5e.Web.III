namespace Un1ver5e.Web.III.Shared.Arklens
{
    public record Gender : CharacterElement
    {
        public Gender(string emoji, string name) : base(emoji, name) 
        { 
        }
        public static Gender Female => new("🚺", "Женский");
        public static Gender Male => new("🚹", "Мужской");
        public static IEnumerable<Gender> AllGenders
            => new[] { Male, Female };
    }
}
