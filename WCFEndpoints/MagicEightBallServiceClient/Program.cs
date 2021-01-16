using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceClient.ServiceReference1;

namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Ask the Magic 8 Ball ****\n");
            using (EightBallClient ball = new EightBallClient("NetTcpBinding_IEightBall"))
            {
                bool isExit = false;
                while(isExit == false)
                {
                    Console.WriteLine("Your question:");
                    string question = Console.ReadLine();
                    if(question == "Exit")
                    {
                        isExit = true;
                    }
                    else
                    {
                        string answer = ball.ObtainAnswerToQuestion(question);
                        Console.WriteLine($"8-Ball says: {answer}");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
