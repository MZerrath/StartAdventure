using System;
using static System.Console;

namespace StartAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string inVal = "";
            string startDescription = "";

            Write("Enter your avatar name: ");
            name = ReadLine();

            Write("{0}, select your start location (1-6): ", name);
            inVal = ReadLine();
            int startLocation = 0;
            int.TryParse(inVal, out startLocation);

            switch(startLocation)
            {
                case 1:
                    startDescription = "Okay, " + name + "... you are in a dimly lit " +
                        "and freezing ice cave filled with hungry penguins.";
                    break;
                case 2:
                    startDescription = "So, " + name + "... you are in an abandoned castle " +
                        "crawling with spiders. A voice in your head screams: \"Please, help me!\"";
                    break;
                case 3:
                    startDescription = "Seems like you're ready to go, " + name + "... " +
                        "you wake up inside a prison, but you have no memory of your crime." +
                        "\nFor some reason, all the other inmates cower in fear, ready to defend themselves.";
                    break;
                case 4:
                    startDescription = "Okay, " + name + "... you are in a strange labyrinth of " +
                        "high walls. You smell oranges and cherries nearby...";
                    break;
                case 5:
                    startDescription = "Right on, " + name + "... you arrive in a church waiting" +
                        " for the wedding to begin. The groom rushes in.\n\"The bride\'s gone missing!\" he shouts.";
                    break;
                case 6:
                    startDescription = "Interesting choice, " + name + "... you wake up in a " +
                        "bed of flowers in a veritable paradise. But something feels off about this place...";
                    break;
                default:
                    startDescription = "Oops. You need to select a number betwen 1 and 6 only.";
                    break;
            }

            WriteLine("\n" + startDescription);

        }
    }
}
