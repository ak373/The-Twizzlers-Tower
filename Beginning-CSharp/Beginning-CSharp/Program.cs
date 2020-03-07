using System;

namespace Beginning_CSharp
{

    
    


    class Program
    {
        
        static void Main(string[] args)
        {

            var service = new WebService();
            var data = service.GetStudentProfile(100);

            Console.Write(data.student.FirstName + " " + data.student.LastName);
            Console.Write(data.grades[0]);


            
            



        }

            



        

        }
    }
