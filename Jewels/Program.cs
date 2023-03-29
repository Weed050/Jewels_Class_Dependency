//Console.WriteLine("Hello, World!");
using Jewels;

static void Main()
{
    Owner owner = new Owner(); 
    Safe safe = new Safe();
    JewelThief jewelThief = new JewelThief();    
    jewelThief.OpenSafe(safe,owner);
    Console.ReadKey();
}