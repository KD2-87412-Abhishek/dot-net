using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class WageEmp : Employee
    {
		private int hours;
		private int rate;

		public int Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		public int Hours
		{
			get { return hours; }
			set { hours = value; }
		}

		public WageEmp() : base() 
		{
			base.Designation = "WageEmployee";
		}

        public WageEmp(string name, bool gender, Date birth, string address, double salary, string designation, DeptType dept,int hours, int rate) : base(name, gender, birth, address, salary, "WageEmployee", dept)
        {
			this.hours = hours;
			this.rate = rate;
        }

		public void Accept()
		{
			base.Accept();
			Console.WriteLine("Enter the Hours");
			hours = Convert.ToInt32(hours);
			Console.WriteLine("Enter the Rate");
			rate = Convert.ToInt32(rate);
		}

		public void Print()
		{
			base.Print();
			Console.WriteLine("Hours: " + hours);
			Console.WriteLine("Rate: "+rate);
		}

		public string ToString()
		{
			return base.ToString()+", hours = "+hours+", rate = "+rate;
		}







    }
}
