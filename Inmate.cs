using System;
using System.Collections.Generic;
using System.Text;

namespace KnuOopLab2
{
    class Inmate
    {
        public Inmate(string name, string facultyName, string studyingYear, string building, string address)
        {
            Name = name;
            FacultyName = facultyName;
            StudyingYear = studyingYear;
            Building = building;
            Address = address;
        }
        public string Name { private set; get; }
        public string FacultyName { private set; get;  }
        public string StudyingYear { private set; get; }
        public string Building { private set; get; }
        public string Address { private set; get; }
    }
}
