using System.Collections.Generic;
using ShattuckProject2.Models;

namespace ShattuckProject2.Services
{
    /// <summary>
    /// Creates/Stores all of the characters and items
    /// </summary>
    public class GameDataService
    {
        public List<Character> Characters { get; set; } // List of Characters
        public List<Item> Items { get; set; } // List of Items

        /// <summary>
        /// Creates/Stores the characters and items
        /// </summary>
        public GameDataService()
        {
            // Stores the characters with a name, type, description, image, and stats
            Characters = new List<Character>
            {
                new Character { Name = "Hero", Type = "Player", Description = "The character the user plays.", ImageUrl = "./images/hero.png", Stats = new Dictionary<string, int> { { "Health", 50 }, { "Damage", 5 } } },
                new Character { Name = "Goblin", Type = "Monsters", Description = "A little green guy.", ImageUrl = "./images/goblin.gif", Stats = new Dictionary<string, int> { { "Health", 30 }, { "Damage", 3 } } },
                new Character { Name = "Mummy", Type = "Monsters", Description = "A zombie-like monster that is wrapped in bandages.", ImageUrl = "./images/mummy.png", Stats = new Dictionary<string, int> { { "Health", 30 }, { "Damage", 4 } } },
                new Character { Name = "Mimic", Type = "Monsters", Description = "A monster that can disguise themself.", ImageUrl = "./images/mimic.png", Stats = new Dictionary<string, int> { { "Health", 30 }, { "Damage", 5 } } }
            };

            // Stores the items with a name, type, description, image, and stats
            Items = new List<Item>
            {
                new Item { Name = "Wooden Sword", Type = "Weapons", Description = "A wooden blade.", ImageUrl = "./images/woodSword.png", Stats = new Dictionary<string, int> { { "Damage", 6 } } },
                new Item { Name = "Stone Sword", Type = "Weapons", Description = "A stone blade.", ImageUrl = "./images/stoneSword.png", Stats = new Dictionary<string, int> { { "Damage", 7 } } },
                new Item { Name = "Iron Sword", Type = "Weapons", Description = "An iron blade.", ImageUrl = "./images/ironSword.png", Stats = new Dictionary<string, int> { { "Damage", 8 } } },
                new Item { Name = "Basic Health Potion", Type = "Potions", Description = "A potion that heals the player.", ImageUrl = "./images/basichealth.png", Stats = new Dictionary<string, int> { { "Heals", 3 } } },
                new Item { Name = "Better Health Potion", Type = "Potions", Description = "A potion that heals the player more than the Basic Health Potion.", ImageUrl = "./images/healthPotion.png", Stats = new Dictionary<string, int> { { "Heals", 5 } } },
                new Item { Name = "Harming Potion", Type = "Potions", Description = "A potion that hurts the player.", ImageUrl = "./images/harmPotion.png", Stats = new Dictionary<string, int> { { "Hurts", 3 } } }
            };
        }
    }
}
