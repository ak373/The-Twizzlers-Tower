using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning_CSharp
{
    struct BookRefew
    {
        string bookName;
        int bookGrade;

        public string GetName()
        {
            return bookName;
        }

        public int GetScore()
        {
            return bookGrade;
        }

        public void SetName(string bookName)
        {
            this.bookName = bookName;
        }
        public void SetGrade(int bookGrade)
        {
            if (bookGrade < 1 || bookGrade > 10)
            {
                Console.WriteLine("Error: Please enter an integer between 1 and 10");
            }
            else
            {
                this.bookGrade = bookGrade;
            }
            
            
        }
    }
}
