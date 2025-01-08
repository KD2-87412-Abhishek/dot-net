using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Supervisor : Employee
    {
		private int subbordinates;

		public int Subbordinates
		{
			get { return subbordinates; }
			set { subbordinates = value; }
		}

		public Supervisor() : base() {
			base.Designation = "Supervisor";
		}
        public Supervisor(string name, bool gender, Date birth, string address, double salary, string designation, DeptType dept,int subbordinates) : base(name,gender,birth,address,salary,"Supervisor",dept)  { 
			this.subbordinates = subbordinates;
		}
		public void Accept()
		{
			base.Accept();
			Console.WriteLine("Enter the subbordinates");
			subbordinates = Convert.ToInt32(subbordinates);	
		}

		public void Print()
		{
			base.Print();
			Console.WriteLine("The subbordinates : "+  subbordinates);
		}
		public string ToString()
		{
			return base.ToString() + ", Subbordinates = " + subbordinates;
		}
    }
}
