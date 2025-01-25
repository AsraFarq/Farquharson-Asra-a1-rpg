//Forest Game !!

using System;

{
        // Initial player stats
        int health = 100;
        int stamina = 100;
        bool hasTotem = false; // Tracks if the player collects the totem

        // Opening narrative
        Console.WriteLine("You awaken in a cold and dreary forest. It's dark, and you begin to shiver the longer you stay in this spot.");
        Console.WriteLine($"Your current stats: Health = {health}, Stamina = {stamina}");

        // Player's choices
        Console.WriteLine("To the [left], there seems to be a man-made path, worn by the feet of those who explored the forest before you.");
        Console.WriteLine("To the [right], you hear the whoosh of water—perhaps a river?");
        Console.WriteLine("Which way do you choose to go?");

        // Player input
        string input = Console.ReadLine().ToLower();

        if (input == "left")
        {
            // Forest path
            Console.WriteLine("You decide to go down the path! Bushes and branches scratch you as you push forward.");
            health -= 10; // Taking damage from the environment
            Console.WriteLine($"The journey is rough, and your health decreases to {health}.");

            Console.WriteLine("Suddenly, you hear a snap behind you. Something stepped on a twig. Panicked, you run with all your might!");
            stamina -= 30; // Losing stamina from running
            Console.WriteLine($"After running until your lungs burn, your stamina decreases to {stamina}.");

            Console.WriteLine("Before you can recover, a monster lunges at you!");
            Console.WriteLine("Scream or say your final words!");

            string message = Console.ReadLine();
            Console.WriteLine($"{message}! {message}! {message}!");
            Console.WriteLine("Your screams echo through the forest as the monster attacks you... You did not survive.");
        }
        else if (input == "right")
        {
            // River path
            Console.WriteLine("You choose the river path. The sound of water grows louder as you approach.");

            Console.WriteLine("You find a strange totem near the riverbank. Do you pick it up? [yes/no]");
            string totemChoice = Console.ReadLine().ToLower();

            if (totemChoice == "yes")
            {
                hasTotem = true;
                Console.WriteLine("You picked up the totem. It glows faintly in your hand.");
            }
            else
            {
                Console.WriteLine("You decide to leave the totem behind.");
            }

            Console.WriteLine("As you drink water to replenish your energy, you feel a little better.");
            health += 20;
            stamina += 20;
            Console.WriteLine($"Your current stats: Health = {health}, Stamina = {stamina}");

            if (hasTotem)
            {
                Console.WriteLine("The totem starts vibrating and a faint light guides you to safety. You survive the forest!");
            }
            else
            {
                Console.WriteLine("Without the totem, you wander the forest aimlessly, unsure of how to escape.");
            }
        }
        else
        {
            // Invalid choice
            Console.WriteLine("You did not choose [left] or [right]. The forest consumes you as you stand indecisively.");
        }

        // Game over message
        Console.WriteLine("Game Over. Thanks for playing!");
    }
