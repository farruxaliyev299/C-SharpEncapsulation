using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class Student
    {
        private int id;
        private string name;
        private string surname;
        public int Id 
        {
            get
            {
                return id;
            }
            set 
            {
                id = value;
            }            
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
            
        }
        public string Surname
        {            
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

    }
}
