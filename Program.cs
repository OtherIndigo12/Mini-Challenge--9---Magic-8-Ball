Console.Clear();
//Zackary Santos
//Last Saved: 9/16/2026 9:20 PM
//Mini Challenge #9 - Magic 8 Ball
//I made a Magic 8 Ball that can respond to questions
//Peer Review Name:Brandon Langehennig
//Review: Code runs great and works as intended

string replay;


string response1 = "no lol";
string response2 = "Cant talk right now, Im busy doing stuff....";
string response3 = "uh, sure.";
string response4 = "maybe....";
string response5 = "I could tell you, but I wont :)";
string response6 = "my always accurate sources say 'no'";
string response7 = "my always accurate sources say 'yes'";
string response8 = "dont count on it";
string response9 = "rely on it, maybe";
string response10 = "Cant Speak Now, I am Sleeping....";

string[] responseBox = [response1, response2, response3, response3, response4, response5,
                        response6, response7, response8, response9, response10];

do
{
    Random userResponse;
    userResponse = new Random();

    Console.Write("I am a Super Cool Magic 8 Ball! Ask me Anything!: ");
    string response = Console.ReadLine();

    int randResponse = userResponse.Next(responseBox.Length);

    Console.WriteLine(responseBox[randResponse]);

    Console.Write("Do you want to Ask Me Another Question? (Answer 'yes' or 'no'): ");
    replay = Console.ReadLine().ToLower();

    while (replay != "yes" && replay != "no")
    {
        Console.Write("Enter an Actual Answer Please! please type 'yes' or 'no': ");
        replay = Console.ReadLine();
    }

    if (replay == "no")
    {
        Console.WriteLine("See You Later Then, I Guess....");
        break;
    }

} while (replay == "yes");