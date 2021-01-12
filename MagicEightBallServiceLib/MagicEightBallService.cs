using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        public MagicEightBallService()
        {
            Console.Write("The 8-Ball is waiting for your question...");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            var answers = new string[] { "Future Uncertain", "Yes", "No",
            "Hazy", "Ask again later", "Definitely" };

            var randomizer = new Random();
            return answers[randomizer.Next(answers.Length)];
        }
    }
}
