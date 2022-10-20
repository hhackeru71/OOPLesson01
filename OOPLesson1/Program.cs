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
            ps.Print();
            //שמדפיס את הגיל של המשתמש ע"י הפונקציה שמחזירה את הגיל של המשתמש
            //להדפיס האם האורך של המחרוזת   יותר מ5 ע"י שימוש בפונקציה שבודקת

        }
    }
}
