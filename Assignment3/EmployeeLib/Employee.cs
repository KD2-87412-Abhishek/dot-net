using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeLib
{
    public enum DeptType
    {
        HR=1, EXPORTS, MANUFACTURING, IMPORTS, TECHNOLOGY, MARKETING, SALES
    }
    public class Employee : Person
    {
        private static int id = 0;
        private double salary;
        private string designation;
        private DeptType deptType;

        public DeptType DeptType
        {
            get { return deptType; }
            set { deptType = value; }
        }


        
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee() : base() {
            ++id;
        }

        public Employee(string name, bool gender, Date birth, string address, double salary,string designation, DeptType dept) : base(
            name,gender,birth,address) 
        {
               
            ++id ;
            this.salary = salary;
            this.designation = designation;
            this.deptType = dept;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose the department : 1.HR, 2.EXPORTS, 3.MANUFACTURING, 4.IMPORTS, 5.TECHNOLOGY, 6.MARKETING, 7.SALES");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    deptType = DeptType.HR;
                    break;
                case 2:
                    deptType = DeptType.EXPORTS;
                    break;
                case 3:
                    deptType = DeptType.MANUFACTURING;
                    break;
                case 4:
                    deptType = DeptType.IMPORTS;
                    break;
                case 5:
                    deptType = DeptType.TECHNOLOGY;
                    break;
                case 6:
                    deptType = DeptType.MARKETING;
                    break;
                case 7:
                    deptType = DeptType.SALES;
                    break;
                 default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
         public override void Print()
        {
            base.Print();
            Console.WriteLine("The salary : " + salary);
            Console.WriteLine("The designation : " + designation);
            Console.WriteLine("The depatment : " + deptType.ToString());

        }

       

        virtual public string ToString()
        {
            string message = "id = {0}, salary = {1}, designation = {2}, Department = {3}";
            return   base.ToString()+string.Format(message, Employee.id, salary, designation, DeptType.ToString());
        }

    }
}
