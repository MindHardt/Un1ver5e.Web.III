namespace Un1ver5e.Web.III.Shared.Arklens
{
    /// <summary>
    /// Represents an element with name and emoji representations.
    /// </summary>
    public abstract record CharacterElement
    {
        public string Emoji { get; }
        public string Name { get; }

        protected CharacterElement(string emoji, string name)
        {
            Emoji = emoji;
            Name = name;
        }

        /// <summary>
        /// Formats this <see cref="CharacterElement"/> with its 
        /// <see cref="Emoji"/> and <see cref="Name"/> displayed.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => $"{Emoji} {Name}";
    }
}
