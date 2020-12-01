using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class Contact
    {
        public string FirstName { get; }
        public string LastName { get; }
        public List<Phone> TelNumbers { get; }

        public Contact(string Fname,string Lname,List<Phone> numbers)
        {
            FirstName = Fname;
            LastName = Lname;
            TelNumbers = numbers;
        }

        public override string ToString()
        {
            string outputString;
            outputString = FirstName + " " + LastName + " ";
            if (TelNumbers != null)
                for (int i = 0; i < TelNumbers.Count; i++)
                    outputString += TelNumbers[i].type + " " + TelNumbers[i].number + ", ";
            return outputString;
        }
    }

    
}
