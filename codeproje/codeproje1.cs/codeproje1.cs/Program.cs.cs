using System;

class ForestAdventureGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("The forest is eerily quiet tonight. What's your name?");
        string playerName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(playerName))
        {
            playerName = "Wanderer";
            Console.WriteLine("You didn't provide a name, so you'll be called 'Wanderer'. Stay sharp, the forest can be unforgiving...");
        }
        else
        {
            Console.WriteLine($"Nice to meet you, {playerName}. But something about this forest feels... wrong.");
        }

        Console.WriteLine($"\n{playerName}, you were hiking in the woods when you got lost. The path you were on has disappeared, and now you're surrounded by towering trees and the sound of rustling leaves.");
        Console.WriteLine("Your phone has no signal, and the sun is setting fast. You need to find a way out before it gets dark.");

        int cautiousCount = 0;

        string answer1 = AskQuestion("\n1. You hear something moving in the bushes behind you. Do you:",
                                     "A. Turn around and investigate (1)",
                                     "B. Keep walking and ignore the sound (2)");

        if (answer1 == "1")
        {
            Console.WriteLine("You turn around, but whatever was there has vanished, leaving you more on edge.");
        }
        else
        {
            Console.WriteLine("You keep moving forward, trying to stay calm as the forest seems to close in around you.");
            cautiousCount++;
        }

        string answer2 = AskQuestion("\n2. The forest grows darker, and you spot a faint light in the distance. Do you:",
                                     "A. Head towards the light, hoping for help (1)",
                                     "B. Stay on your current path, unsure if the light is safe (2)");

        if (answer2 == "1")
        {
            Console.WriteLine("You cautiously approach the light. It seems to flicker like a lantern, but no one is there when you arrive.");
        }
        else
        {
            Console.WriteLine("You stick to your path, trusting your instincts over the strange light.");
            cautiousCount++;
        }

        string answer3 = AskQuestion("\n3. A chilling howl echoes through the forest. Do you:",
                                     "A. Follow the sound to investigate (1)",
                                     "B. Turn and try to move as far from it as possible (2)");

        if (answer3 == "1")
        {
            Console.WriteLine("You move towards the howl, your curiosity overpowering your fear.");
        }
        else
        {
            Console.WriteLine("You quickly change direction, determined to put as much distance as you can between you and the source of the sound.");
            EndCautiousEnding(playerName);
            return;
        }

        string answer4 = AskQuestion("\n4. You come across an abandoned campsite. A small tent and extinguished fire remain. Do you:",
                                     "A. Search the campsite for clues or supplies (1)",
                                     "B. Keep moving, not wanting to linger in case danger returns (2)");

        if (answer4 == "1")
        {
            Console.WriteLine("You search the campsite but find nothing helpful, only remnants of someone else's misfortune.");
        }
        else
        {
            Console.WriteLine("You leave the campsite behind, unwilling to risk whatever may still be lurking nearby.");
            cautiousCount++;
        }

        if (cautiousCount == 4)
        {
            EndCautiousEnding(playerName);
        }
        else
        {
            FinalExtendedEnding(playerName);
        }
    }

    static string AskQuestion(string question, string option1, string option2)
    {
        string answer;
        do
        {
            Console.WriteLine(question);
            Console.WriteLine(option1);
            Console.WriteLine(option2);
            answer = Console.ReadLine();

            if (answer != "1" && answer != "2")
            {
                Console.WriteLine("Please choose 1 or 2. The forest demands a proper decision.");
            }
        } while (answer != "1" && answer != "2");

        return answer;
    }

    static void EndCautiousEnding(string playerName)
    {
        Console.WriteLine($"\nThanks for playing, {playerName}.");
        Console.WriteLine("You chose caution, avoiding danger at every step. You eventually find your way out of the forest, but the eerie feeling never leaves you.");
        Console.WriteLine("Safe for now, but the forest keeps its secrets. Game Over.");
    }

    static void FinalExtendedEnding(string playerName)
    {
        Console.WriteLine("\nYou balanced caution with curiosity, pushing deeper into the forest...");
        Console.WriteLine("After hours of wandering, you stumble upon a hidden clearing where ancient carvings mark the stones.");
        Console.WriteLine("\nDo you:");
        Console.WriteLine("A. Stay to examine the carvings further (1)");
        Console.WriteLine("B. Leave the clearing and continue searching for an exit (2)");
        string finalAnswer = Console.ReadLine();

        if (finalAnswer == "1")
        {
            Console.WriteLine("As you examine the carvings, a sense of dread washes over you. The forest seems alive, watching your every move. The sun sets, and you're trapped.");
            Console.WriteLine("\nGame Over. The forest has claimed another secret.");
        }
        else
        {
            Console.WriteLine("You leave the clearing, the carvings etched in your memory. As you finally escape the forest, the whispers of the trees fade, but the mystery remains.");
            Console.WriteLine("\nGame Over. You survived, but the forest will always haunt you.");
        }
    }
}
//use Chatgpt for the story. Not all story.