using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    internal class Student

    {
        string name;
        int rost;
        int ves;
        public Student (string name, int rost, int ves)
        {
            this.name = name;
            this.rost = rost;
            this.ves = ves;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Rost
        {
            get { return Rost; }
            set { Rost = value; }
        }
        public int Ves
        {
            get { return Ves; }
            set { Ves = value; }
        }
        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            if (name.CompareTo(student.Name) > 0)
                return name.CompareTo(student.Name);
            if (name.Equals(student.Name))
                return name.CompareTo(student.Name);
            return 0;

        }
    }
}
