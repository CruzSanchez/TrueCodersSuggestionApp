using System;
using System.Collections.Generic;
using System.Text;

namespace TrueCodersSuggestion.Library
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public string TeacherName { get; set; }
        public string ClassName { get; set; }
        public Suggestion Suggestion { get; set; }
    }
}
