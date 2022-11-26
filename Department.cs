using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    struct Department
    {
        #region department fields and property

        private int deptid;

        public int DeptID
        {
            get { return deptid; }
            set 
            { 
                if(value >=1)
                   deptid = value;
            }
        }

        private string deptname;

        public string DeptName
        {
            get { return deptname; }
            set 
            { 
                if(value.Trim().Length >=3)
                     deptname = value;
            }
        }
        private  string manager;

        public string Manager
        {
            get { return manager; }
            set {
                if (value.Trim().Length >=3)
                    manager = value; 
            }
        }
        private Employee [] deptemployees;

        public Employee [] DeptEmployees
        {
            get { return deptemployees; }
            set { deptemployees = value; }
        }

        #endregion
        #region constractors
        public Department(int x ,string y, string s, Employee [] r)
        {
            deptid = x;
            deptname = y;
            manager = s;
            deptemployees = r;
        }
        #endregion
        #region methods
        public void print()
        {
            Console.WriteLine($"\t\t Department Id : {deptid} ,Department Name : {deptname} , Department Manager : {manager} , Department Employees : ");
            for(int i =0; i<deptemployees.Length; i++)
            {
                Console.WriteLine($"\t \t {deptemployees[i].print()}");
            }
            Console.WriteLine("-------------------------------");
        }
        #endregion
    }
}
