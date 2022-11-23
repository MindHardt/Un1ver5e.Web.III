namespace Un1ver5e.Web.III.Shared.Arklens
{
    public record Class : CharacterElement
    {
        public Class(string emoji, string name) : base(emoji, name)
        {
        }

        public static IEnumerable<Class> AllClasses
            => throw new NotImplementedException();
    }
}
