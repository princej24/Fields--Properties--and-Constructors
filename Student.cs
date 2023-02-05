using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Fields__Properties__and_Constructors
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public double CSIGrade;
        public double GenEdGrade;

        public Student(string firstName,string lastName,int CSI,int GenEd )
        {
            FirstName= firstName;
            LastName= lastName; 
            CSIGrade= CSI;
            GenEdGrade= GenEd;

        }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = -1;
            GenEdGrade = -1;
        }
        //What is an instance?
        //giving a value//instansiate 
       // How do we make one?
       // use new As a Key WOrd 

       // What does the new keyword do?
       // holds like a string / veriable 
      //How do you access members of an object?
      // using the dot 
    }
}
