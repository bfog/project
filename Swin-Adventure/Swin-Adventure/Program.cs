using System;
using System.Collections.Generic;


namespace Swin_Adventure
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string name, desc, command = "";
            string[] aCommand;
            
            Console.WriteLine("Welcome to Swin-Adventure! Type 'Quit' or 'q' to quit the game\n***************************\n");
            Console.Write("Please enter your player name: ");
            name = Console.ReadLine();

            Console.Write("Please enter a player description: ");
            desc = Console.ReadLine();

            Player myPlayer = new Player(name, desc);

            Bag bag = new Bag(new string[] { "bag" }, "a bag", "a bag");
            Item gem = new Item(new string[] { "gem" }, "a gem", "a shiny ruby");
            Item sword = new Item(new string[] { "sword" }, "a sword", "a bronze sword");
            Item rock = new Item(new string[] { "rock" }, "a rock", "a small rock");
            Item shovel = new Item(new string[] { "shovel" }, "a shovel", "a rusty shovel");
            Location loc = new Location("Hallway", "This is a long well lit hallway.\nThere are exits to the south.\n");
            Inventory myInventory, bagInventory, locInventory;
            myInventory = myPlayer.Inventory;                       
            bagInventory = bag.Inventory;

            myInventory.Put(gem);
            myInventory.Put(bag);
            bagInventory.Put(rock);

            myPlayer.Location = loc;
            locInventory = loc.Inventory;
            locInventory.Put(shovel);
            locInventory.Put(sword);

            Console.WriteLine("\n"); //space between player description and commands.

            LookCommand look = new LookCommand(new string[] { "look"} );

            do
            {
                Console.Write("Command -> ");
                command = Console.ReadLine();

                aCommand = command.ToLower().Split();


                if (aCommand[0] == "look")
                {

                    Console.WriteLine(look.Execute(myPlayer, aCommand));
                }
                else if(command.ToLower() != "quit" && command.ToLower() != "q")
                    Console.WriteLine("I don't understand " + command);


            } while (command.ToLower() != "quit" && command.ToLower() != "q");

            Console.WriteLine("\nThanks for playing Swin-Adventure!");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
