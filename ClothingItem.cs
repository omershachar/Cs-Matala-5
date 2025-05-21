using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public enum Size { S, M, X, XXL, OS }
    public enum Status { NotInUse = 1, LowUsage = 2, HighUsage = 3 }
    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8
    }
    internal class ClothingItem
    {
        public static uint id_counter = 1;

        //Clothing item's fields
        uint id;
        string user_id;
        string name;
        string color_code;
        Size size;
        Status status;
        Seasons seasons;

        //Properties
        public uint Id {
            get => id;
            set {id = (value > 0) ? value : throw new ArgumentException("Invalid cloting item ID.");}
        }
        public string User_id { 
            get;
            private set;
        }
        public string Name { 
            get => name;
            set {name = (isStringValid(value)) ? value : throw new ArgumentException("Invalid clothing item name.");}
        }
        public string Color_code
        {
            get => color_code;
            set {color_code = (isColorCodeValid(value)) ? value : throw new ArgumentException("Invalid color code.");}
        }
        public Size Size
        {
            get => size;
            set {size = (Enum.IsDefined(typeof(Size), value)) ? value : throw new ArgumentException("Invalid size.");}
        }
        public Status Status
        {
            get => status;
            set {status = (Enum.IsDefined(typeof(Status), value)) ? value : throw new ArgumentException("Invalid status.");}
        }
        public Seasons Seasons
        {
            get => seasons;
            set {seasons = (Enum.IsDefined(typeof(Seasons), value)) ? value : throw new ArgumentException("Invalid season.");}
        }

        //Constructors
        public ClothingItem() { } // Default constructor
        public ClothingItem(string user_id, string name, string color_code, Seasons seasons, Size size, Status status)
        {
            this.Id = id_counter++;
            this.User_id = user_id;
            this.Name = name;
            this.Color_code = color_code;
            this.Seasons = seasons;
            this.Size = size;
            this.Status = status;
        }

        public void Print()
        {
            Console.WriteLine($"\nCloth ID: {Id}");
            Console.WriteLine($"User ID: {User_id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color (RGB): {Color_code}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Status: {Status}");

            if (Seasons.HasFlag(Seasons.Summer))
                Console.WriteLine("The cloth is good for summer.");
            if (Seasons.HasFlag(Seasons.Autumn))
                Console.WriteLine("The cloth is good for autumn.");
            if (Seasons.HasFlag(Seasons.Winter))
                Console.WriteLine("The cloth is good for winter.");
            if (Seasons.HasFlag(Seasons.Spring))
                Console.WriteLine("The cloth is good for spring.");
        }

        //Helper functions
        private Boolean isNumberValid(string num)
        { return !string.IsNullOrWhiteSpace(num) && num.All(char.IsDigit); }

        private Boolean isStringValid(String str)
        { return !string.IsNullOrWhiteSpace(str) && str.All(char.IsLetter); }

        private Boolean isDateValid(DateTime date)
        { return date.Year > 1900 && date.Year < DateTime.Now.Year; }

        private Boolean isColorCodeValid(string color_code)
        {
            if (color_code.Length != 7 || color_code[0] != '#')
                return false;
            for (int i = 1; i < color_code.Length; i++)
            {
                if (!char.IsDigit(color_code[i]) && (color_code[i] < 'A' || color_code[i] > 'F'))
                    return false;
            }
            return true;
        }
    }
}
