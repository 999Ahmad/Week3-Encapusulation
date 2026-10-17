using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Encapsulation
{
     class Member
    {

        
        private int memberId;
        private string name;
        private string address;
        private string phone; // Changed to string to keep the leading zeros

        // Public properties 
        public int MemberId
        {
            get { return memberId; }
            private set // Private setter makes it read-only
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error : Member ID must be greater than zero");
                }
            }

            // Private Setter: The private set command in the MemberId property ensures that the MemberId can only be set within the class itself,
            // making it effectively read-only from outside the class.
            // Note: The MemberId is set in the constructor, which is the only place where it can be assigned a value. Everywhere else it is recognised as read-only.


        }
        public string Name
        {
            get { return name; } // get method
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }

        public string Address
        {
            get { return name; } // get method
            set { name = value; } // set method
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor using standard C# casing conventions
        public Member(int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId; // Assigns the camelCase parameter to the PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone no: {Phone}");
            Console.WriteLine();
        }


    }
}
