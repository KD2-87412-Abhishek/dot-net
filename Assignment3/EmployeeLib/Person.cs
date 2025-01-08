using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeLib
{
    public class Person
    {
		private string name;
		private bool gender;
		private Date dob;
		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public Date DOB
		{
			get { return dob; }
			set { dob = value; }
		}

		public bool Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Person()
		{
            
		}

        public Person(string name, bool gender, Date birth, string address)
        {
			this.name = name;
			this.gender = gender;
			this.dob = birth;
			this.address = address;
        }

       virtual public void Accept()
        {
            Console.WriteLine("Enter the name");
			name = Console.ReadLine();
            Console.WriteLine("Choose the Gender of student : 1. Male, 2.Female");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                gender = true;
            }
            else if (n == 2)
            {
                gender = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Enter the Date");
            dob = new Date();
            dob.AcceptDate();
            Console.WriteLine("Enter the Address");
            address = Console.ReadLine();
            
        }

        public int CalculateAge(Date dob)
        {
            DateTime dateTime = DateTime.Now;
            Date currDate = new Date(dateTime.Day, dateTime.Month, dateTime.Year);
            Date resultDate = currDate - dob;
            return resultDate.Year;

            
        }
        virtual public void Print()
        {
            Console.WriteLine("The Name : " + name );
            if (gender == true)
            {
                Console.WriteLine("Gender of person : Male");
            }
            else
            {
                Console.WriteLine("Gender of person : Female");
            }
            Console.WriteLine("The Date : " + dob.ToString());
            Console.WriteLine("The Address : " + address);
        }

        public string ToString()
        {
            string message = " name = {0}, male = {1}, birth = {2}, address = {3}, age = {4} ";
            return string.Format(message, name, gender, dob.ToString(), address, CalculateAge(dob) );
        }



    }
}
