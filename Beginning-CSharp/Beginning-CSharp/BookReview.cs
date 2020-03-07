using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning_CSharp
{
    struct BookReview
    {
        string name;
        int score;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetScore(int score)
        {
            if (score > 0 && score < 11)
                this.score = score;
            else Console.WriteLine("Error: please enter an integer between 1 and 10");
            

            
        }

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
