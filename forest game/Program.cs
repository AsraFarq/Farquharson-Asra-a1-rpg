//player wakes up in a forest

using System;

Console.WriteLine("You awaken in a cold and dreary forest. its dark and you begin to shiver the longer you stay in thus spot.");

// player options they have to proceed
// add health bar (assignment operators) add stamina bar
Console.WriteLine("To the [left] there seems to be a path, it looks man made as if its simply from the feet of those who have explored the forest before you.");
Console.WriteLine("You could also go [right] to where you hear the woosh of water. maybe it is a river?.");
Console.WriteLine("Which way do you choose to go?");

// player input
string input = Console.ReadLine();

// players response, go in different directions
if (input.ToLower() == "left")
{
    //forest path
    Console.WriteLine("You decide to go down the path! You can feel the hairs on your neck rise as you push through. bushes and branches scratch you as you walk forward. You hear a snap behind you, as if someone.. or SOMETHING stepped on a twig.. and opon hearing it you run with all your might. You only stop running once your lungs burn and you can't anymore..");
    Console.WriteLine("You look around at the already unfamiliar forest to only feel more scared. You're lost! You feel the hairs on your neck rise again as you shake in your spot.. before you can even turn you're lunged at!");
    Console.WriteLine("Scream or say your final words! it's your last chance too!!");

    string message;
    message = Console.ReadLine();
    // try to line break each scream
    Console.Write(message);
    Console.Write(" ");
 
    Console.Write(message);
    Console.Write(" ");
    
    Console.Write(message);
    Console.Write(" ");

    Console.WriteLine("Your scream echo's out into the forrest as whatever monster found you... eats you alive.");

}
else if (input == "right")
{
    // step 6: mountain path
    Console.WriteLine("You choose the mountain. enjoy your hike up!");
    // add in totem to be picked up... maybe use thing from module 2 sildeshow???
}
else
{
    // step 7: invalid option
    Console.WriteLine("you did not choose [right] or [left]... bye!");
}