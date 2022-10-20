using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson1
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public void Print()
        {
            Console.WriteLine($"{firstName}{lastName}{age}");
        }


        public int GetAge()
        {
            return age;
        }

        public bool Check()
        {
            return firstName.Length > 5;
        }





        //פונקציה  שמחזירה את הגיל של המשתמש 

        //פונקציה שמקבלת את השם של המשתמש   ובודקת האם המחרוזת האורך שלה יותר מ5 
        //במידה וכן מחזירה true
        //אחרת false


    }
}

