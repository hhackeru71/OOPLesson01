using System;

namespace OOPLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person ps = new Person();
            //ps.FirstName = "sdfsdf";
            //Console.WriteLine(ps.FirstName);
            //ps.LastName = "sdfdsf";
            ps.Age = 60;
            ps.FirstName = " sdfdsf";
            ps.LastName = " sdfdsf";
            Person ps = new Person
            {
                Age = 40,
                FirstName = "sdfdsf",
                LastName = " sdfsdf"
            }
            Console.WriteLine(ps.Age);
            ps.Age = 40;
            Console.WriteLine(ps.Age);




            //ps.firstName = "yarin";
            //ps.lastName = "sh";
            //ps.age = 50;

            //Console.WriteLine(ps.GetAge());
            //Console.WriteLine(ps.Check());
            //להדפיס האם האורך של המחרוזת   יותר מ5 ע"י שימוש בפונקציה שבודקת

        }
    }
}
