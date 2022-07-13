using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    public class Student
    {
       
        public int Telebecode  { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Telebekodu : {Telebecode},Ad : {Name},Soyad : {Surname}";
        }
    }

    
}
