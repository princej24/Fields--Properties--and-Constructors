using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;

namespace Fields__Properties__and_Constructors
{
    public class Instroctor
    {
        string firstName;
        string lastName;
        string phone;
        
        public Instroctor(string firstName, string lastName, string phone) 
        {
         this.firstName = firstName;
         this.lastName = lastName;
         this.phone = phone;
        }
        public string LastName
        {
            // get is used to read info only 
            get
            {
                return LastName;
            }
            set
            {
                if (value != "") 
                { 
                    LastName = value;
                }
                else
                {
                    MessageBox.Show("please enter a valid last name  ");
                }
                // value is the value assigned   
                LastName = value;
            }


        }
        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                firstName= value;
            }
        }
        public string Phone
        {
            
            
                get=> Phone;
                set => Phone = value;
        }
        public string Firstname
        {
            get =>firstName;
            set => firstName
                =  value;
        }
        // What does a Constructor do?
        //  allow whats passed in 
        //How do you create a constructor?
        // access modifier - className -parentheses

        //What happens to the default constructor when I make a new constructor?
        // gets replaced 

        //How do you define a property
        //access modifier type of field name of the field in uppper case

        //What are properties used for?
        // protect info 
        //What does a Get allow?
      // get is read only 
        //What does a Set allow?
        //value assigned to user 

    }

   
}
