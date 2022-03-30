using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Group
    {
        private int _maxStuCount;
        private string _groupName;
        private Student[] _students = new Student[100];
        private int Position = 0;
        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                _groupName = value;
            }
        }
        public int MaxStuCount
        {
            get
            {
                return _maxStuCount;
            }
            set
            {
                _maxStuCount = value;
            }

        }


        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {

            }
            
        }
              
        public void AddStudents(Student student)
        {
            if(_students.Length <= _maxStuCount)
            {
                _students[Position] = student;
                Position++;

            }
            else
            {
                Console.WriteLine("Array's size is full");
            }
                                     
        }

        
        

    }
}
