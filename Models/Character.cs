namespace ShattuckProject2.Models
{
    /// <summary>
    /// initializes the Character's name, type, description, image, and stats
    /// </summary>
    public class Character
    {
        public string Name { get; set; } // Character's name
        public string Type { get; set; } // Character's type (Player, Monster, etc.)
        public string Description { get; set; } // Character's description
        public string ImageUrl { get; set; } // Character's image
        public Dictionary<string, int> Stats { get; set; } // Character's stats
    }
}
