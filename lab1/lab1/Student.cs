using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public int Age { get; set; }

        private string GenderHelper()
        {
            Random rand = new Random();
            int n = rand.Next(0, 1);
            if (n > 0)
            {
                return "Male";
            } 
            else
            {
                return "Female";
            }
                               
        }

        private string NameHelper(Student st1, Student st2)
        {
            string tempStr = st1.Name + st2.Name;

            return new string(tempStr.Reverse().ToArray());

            //string result = "";
            
            //for (int i = 0; i < tempStr.Length; i++)
            //{
            //    result += tempStr[tempStr.Length - i - 1];
            //}
            //return result;
        }

        private string HairColorHelper()
        {
            string[] hairColors = { "Черные", "Золотой блонд", "Перламутровый блонд",
                                    "Платиновый блонд", "Пшеничный", "Бежевый", 
                                    "Пепельный блонд", "Каштановый", "Шатен", 
                                    "Русые", "Рыжий" };
            Random rand = new Random();
            int n = rand.Next(hairColors.Length);
            return hairColors[n];
        }

        private int AgeHelper(Student st1, Student st2)
        {
            return (int)(((double)st1.Age + (double)st2.Age) / 2);
        }

        public static Student operator +(Student st1, Student st2)
        {
            Student temp = new Student();
            temp.Name = temp.NameHelper(st1, st2);
            temp.Gender = temp.GenderHelper();
            temp.HairColor = temp.HairColorHelper();
            temp.Age = temp.AgeHelper(st1, st2);
            return temp;
        }
    }
}
