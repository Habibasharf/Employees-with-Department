using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   struct Company
    {
        #region company field and property

       
        private string companyname;

        public string CompanyName
        {
            get { return companyname; }
            set { companyname = value; }
        }
        private Department [] departments;

        public Department[] Departments
        {
            get { return departments; }
            set { departments = value; }
        }
        #endregion
        #region constractors
        public Company( string y, Department[] r)
        {
            
            companyname = y;
            departments = r;
        }
        #endregion
        #region company methods
        public void print()
        {
            Console.WriteLine($"Company Name : {companyname} , Company Departments : ");
            for (int i= 0;i<departments.Length; i++)
            {
                departments[i].print();
            }
            Console.WriteLine("***********************************");
        }
        public string this[ int s]
        {
            set
            {
                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i].DeptID == s)
                    {
                        departments[i].DeptName = value;
                        break;
                    }
                }
            }
            get
            {
                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i].DeptID == s)
                    {
                        return departments[i].DeptName;

                    }
                }
                return $"No Data in this row ";
            }
        }
        public string this[int x, string s]
        {
            set
            {
                for (int i = 0; i < Departments.Length; i++)
                {
                    if (Departments[i].DeptName == s)
                    {
                        for (int j = 0; j < Departments[i].DeptEmployees.Length; j++)
                        {
                            if (Departments[i].DeptEmployees[j].GetID() == x)
                            { 
                                Departments[i].DeptEmployees[j].SetName(value);
                            }
                        }
                    }
                }
            }
            get
            {
                for (int i = 0; i < Departments.Length; i++)
                {
                    if (Departments[i].DeptName == s)
                    {
                        for (int j = 0; j < Departments[i].DeptEmployees.Length; j++)
                        {
                            if (Departments[i].DeptEmployees[j].GetID() == x)
                            {
                                return $"{Departments[i].DeptEmployees[j].print()}";
                            }
                        }
                    }
                }
                return $"The employee of id {x} doesn't existing in this department {s} ";
            }
        }
     
        #endregion

    }

}
