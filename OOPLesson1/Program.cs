using System;

namespace OOPLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person();
            ps.firstName = "yarin";
            ps.lastName = "sh";
            ps.age = 50;
             
            Console.WriteLine(ps.GetAge());
            Console.WriteLine(ps.Check());
            //להדפיס האם האורך של המחרוזת   יותר מ5 ע"י שימוש בפונקציה שבודקת

        }
    }
}
