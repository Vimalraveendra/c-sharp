using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public void AddGrade(double grade)
        // AddGrade method recives a parameter grade of type double
        {
            // if we declare the the grades here so it will
            // only availble inside this method.
            //   List<double>grades;

            grades.Add(grade)
        }
        //  here I declared the grades with type List of double
        // so that every method in the class Book can access grades
        List<double> grades;
    }
}