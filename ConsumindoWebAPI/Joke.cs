using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumindoWebAPI
{
    public class Flags
    {
        public bool nsfw { get; set; }
        public bool religious { get; set; }
        public bool political { get; set; }
        public bool racist { get; set; }
        public bool sexist { get; set; }

        public string getflags()
        {
            string flags = "";
            if (nsfw)
            {
                flags += "nsfw/";
            }
            if (religious)
            {
                flags += "religious/";
            }
            if (political)
            {
                flags += "political/";
            }
            if (racist)
            {
                flags += "racist/";
            }
            if (sexist)
            {
                flags += "sexist/";
            }
            return flags;
        }
    }
    public class Joke
    {
        public bool error { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string joke { get; set; }
        public string setup { get; set; }
        public string delivery { get; set; }
        public Flags flags { get; set; }
        public int id { get; set; }
        public string lang { get; set; }

        public void printJoke()
        {
            if(flags.getflags() == "")
            {
                Console.WriteLine("No Flags");
            }
            else
            {

                Console.WriteLine($"Flags: {flags.getflags()}");
            }
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Category: {category}");
            if (type == "single")
            {
                Console.WriteLine($"Joke: {joke}");
            }
            if (type == "twopart")
            {
                Console.WriteLine($"Setup: {setup}");
                Console.WriteLine($"Delivery: {delivery}");
            }
        }
    }
}
