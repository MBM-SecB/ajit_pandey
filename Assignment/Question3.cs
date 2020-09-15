using System;

    public class Ques3
    {
        // static void Main3(string[] args)
        // {
        //     Ques3 p = new Ques3();
        //     p.GetInitials();
        // }

        public void GetInitials()
        {
            Console.Write("Enter two words separated by space: ");
            string s = Console.ReadLine();
            string[] output = s.Split(' ');
            
            foreach (string a in output)
            {
                if(output.Length!=2)
                {
                Console.WriteLine("Can\'t you read English? Enter only two words.");
                }
                else{
                    Console.Write(a[0]);
                }
            }

        }
    }
