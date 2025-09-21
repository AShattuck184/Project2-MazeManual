namespace ShattuckProject2.Models
{
    /// <summary>
    /// initializes the Item's name, type, description, image, and stats
    /// </summary>
    public class Item
    {
        public string Name { get; set; } // Item's name
        public string Type { get; set; } // Item's type (Weapon, Potion, etc.)
        public string Description { get; set; } // Item's description
        public string ImageUrl { get; set; } // Item's image
        public Dictionary<string, int> Stats { get; set; } // Item's stats
    }
}
