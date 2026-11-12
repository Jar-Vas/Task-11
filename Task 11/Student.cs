using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Task_11
{
    internal class Student
    {
        public string fName {  get; set; }
        public string sName { get; set; }
        public int Age { get; set; }
        public string University { get; set; }

        public Student(string _fName, string _sName, int _age, string _university) { fName = _fName; sName = _sName; Age = _age; University = _university; }
        public Student() { fName = "No data"; sName = "No data"; Age = 0; University = "No data"; }
        public string Info() { return  fName + " " + sName + " " + Age.ToString() + " " + University; }
    }
}
