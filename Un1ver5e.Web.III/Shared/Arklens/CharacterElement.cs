using System.ComponentModel;

namespace Un1ver5e.Web.III.Shared.Arklens
{
    /// <summary>
    /// Represents an element with name and emoji representations.
    /// </summary>
    public abstract class CharacterElement : IEquatable<CharacterElement>
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
        {
            return $"{Emoji} {Name}";
        }

        public override bool Equals(object? obj)
            => obj is CharacterElement other &&
            other.Name == Name && 
            other.Emoji == Emoji;

        public override int GetHashCode()
        {
            return HashCode.Combine(Emoji, Name);
        }

        public static bool operator ==(CharacterElement left, CharacterElement right)
            => left.Equals(right);

        public static bool operator !=(CharacterElement left, CharacterElement right)
            => !left.Equals(right);



        public bool Equals(CharacterElement? other) => Equals(other);
    }
}
