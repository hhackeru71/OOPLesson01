using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson1
{
    class Person
    {
       private string firstName;
       private string lastName;
       private int age;


        //prop
        public string FirstName
        {
            get { return firstName;}//מחזיר את המידע
            set { firstName = value;}//השמה למשתנה
        }

        public string LastName
        {
            set { lastName = value;}
        }

        public int Age
        {
            get { return age;}
            set
            {
                if (value > 50)
                    return;
                age = value;
            }
        }

        

        //public void Print()
        //{
        //    Console.WriteLine($"{firstName}{lastName}{age}");
        //}


        //public int GetAge()
        //{
        //    return age;
        //}

        //public bool Check()
        //{
        //    return firstName.Length > 5;
        //}





        //פונקציה  שמחזירה את הגיל של המשתמש 

        //פונקציה שמקבלת את השם של המשתמש   ובודקת האם המחרוזת האורך שלה יותר מ5 
        //במידה וכן מחזירה true
        //אחרת false


    }
}

