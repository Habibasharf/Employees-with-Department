using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
     struct Employee
    {
        #region structure of employees
        #region fields
        int id;
        string name;
        int salary;
        string security;
        string gender;
        HiringData hiredata;
        #endregion
        #region constractors
        #endregion
        #region property

        #endregion
        #region methods
        #region getter & setter
        public void SetID(int x)
        {
            if (x >= 1)
            {
                id = x;
            }
        }
        public int GetID()
        {
            return id;
        }
        public void SetName(string x)
        {
            if (x.Length >= 3)
            {
                name = x;
            }
        }
        public string GetName()
        {
            return name;
        }
        public void SetSalary(int x)
        {
            if (x >= 3000)
            {
                salary = x;
            }
        }
        public int GetSalary()
        {
            return salary;
        }
        public void SetSecurity(int y)
        {

            switch (y)
            {
                case 1:
                    security = "Guest";
                    break;
                case 2:
                    security = "Developer";
                    break;
                case 3:
                    security = "Secretary";
                    break;
                case 4:
                    security = "DBA";
                    break;
                default:
                    Console.WriteLine("Wronge choice");
                    break;
            }


        }
        public string GetSecurity()
        {
            return security;
        }
        public void SetGender(char x)
        {

            switch (x)
            {
                case 'm':
                case 'M':
                    gender = "Male";
                    break;
                case 'f':
                case 'F':
                    gender = "Female";
                    break;

                default:
                    Console.WriteLine("Wronge choice");
                    break;
            }


        }
        public string GetGender()
        {
            return gender;
        }
        public void SetHire(HiringData d)
        {
            hiredata = d;
        }
        public HiringData GetHire()
        {
            return hiredata;

        }
        public Employee(int x,string y, int s, string r , string g , HiringData h)
        {
            id = x;
            name = y;
            salary = s;
            security = r;
            gender = g;
            hiredata = h;
        }
        #endregion
        public string print()
        {
            return $"Employee data : Id --> {id} , Name --> {name} , Salary --> {salary} , Srcurity Level --> {security}, Gender --> {gender}, Hire Date --> {hiredata.Hire()} ";
        }
        #endregion
        #endregion
    }
    
}
