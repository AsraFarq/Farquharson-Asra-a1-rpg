//player wakes up in a forest

using System;

Console.WriteLine("You awaken in a cold and dreary forest. its dark and you begin to shiver the longer you stay in thus spot.");

// step 2: tell player options they have to proceef
Console.WriteLine("To the [left] there seems to be a path, it looks manmad as if its simply from the feet of those who have explored the forest before you.");
Console.WriteLine("You could also go [right] to where you hear the woosh of water. maybe it is a river?.");
Console.WriteLine("Which way do you choose to go?");

// step 3: get player input
string input = Console.ReadLine();

// step 4 check players response, go in different directions
if (input.ToLower() == "left")
{
    //step 5: town path
    Console.WriteLine("You decide to go down the path! You can feel the hairs on your neck rise as you push through. bushes and branches scratch you as you walk forward. you hear a snap behind you, like someone.. or soemthing stepping on a twig and you run with all your might. you only stop running once your lungs burn and you can't anymore..");
    Console.WriteLine("You look around at the already unfamiliar forest to only feel more scared. You're lost! You feel the hairs on your neck rise again as you shake in your spot.. before you can even turn you're attacked")
        Console.WriteLine("Scream or say your final words! it's your last chance too!!")

    string message;
    message = Console.ReadLine();
    
    Console.Write(message);
    Console.Write(" ");
    Console.Write(message);
    Console.Write(" ");
    Console.Write(message);
    Console.Write(" ");
    
    Console.WriteLine("Your scream echo's out into the forrest as whatever monster found you... eats you alive.")
    
}
else if (input == "right")
{
    // step 6: mountain path
    Console.WriteLine("You choose the mountain. enjoy your hike up!");
}
else
{
    // step 7: invalid option
    Console.WriteLine("you did not choose [right] or [left]... bye!");
}