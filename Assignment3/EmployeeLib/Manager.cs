using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Manager : Employee
    {
		private double  bonnus;

		public double  Bonnus
		{
			get { return bonnus; }
			set { bonnus = value; }
		}

        public Manager() : base()
        {
            base.Salary = Salary + bonnus;
            base.Designation = "Manager";
        }

        public Manager(string name, bool gender, Date birth, string address, double salary, string designation, DeptType dept, double bonnus) : base(name, gender, birth, address,salary,"Manager",dept) 
        {
            this.bonnus = bonnus;
            base.Salary = salary + bonnus;
        }

         public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the manager bonnous");
            bonnus =  Convert.ToDouble(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("The manager bonnous : "+ bonnus);
            double sal = bonnus +  base.Salary;
            Console.WriteLine("The manager Salary after bonnous : " +sal);

        }

        public override string  ToString()
        {
            return base.ToString()+"Bonnous = "+bonnus;
        }
    }
}
