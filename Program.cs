using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
       public static bool CheckUniqe(Employee[] _staff, int _id)
        {
            for (int i = 0; i < _staff.Length; i++)
            {
                if (_staff[i].GetID() == _id)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckUniqeid(Department[] _staff, int _id)
        {
            for (int i = 0; i < _staff.Length; i++)
            {
                if (_staff[i].DeptID == _id)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckUniqename(Department[] _staff, string n)
        {
            for (int i = 0; i < _staff.Length; i++)
            {
                if (_staff[i].DeptName == n)
                {
                    return false;
                }
            }
            return true;
        }
        public static Employee [] InserEmp(Employee []x)
        {
            int d = 0;
            for(int i =0; i < x.Length; i++)
            {
                
                Console.WriteLine($"\tEmployee [{i + 1}] Data ");
                do
                {
                    Console.Write("\tID = ");
                    d = int.Parse(Console.ReadLine());
                } while (CheckUniqe(x, d) == false);
                x[i].SetID(d);
                Console.Write($"\tName = ");
                x[i].SetName(Console.ReadLine());
                Console.Write($"\tSalary = ");
                x[i].SetSalary(int.Parse(Console.ReadLine()));
                Console.WriteLine($" M --> Male \n F --> Female  ");
                Console.Write($"\t Gender = ");
                x[i].SetGender(char.Parse(Console.ReadLine()));
                Console.WriteLine($" 1- Guest \n 2- Developer \n 3- Secretary \n 4- DBA ");
                Console.Write($"\tSecurity = ");
                x[i].SetSecurity(int.Parse(Console.ReadLine()));
                Console.Write($"\t Hire Date = ");
                HiringData y = new HiringData(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                x[i].SetHire(y);
                Console.WriteLine("--------------------");
            }
         
            return x;
        }
        public static void PrintDepName(Department [] depnam)
        {
            for(int i = 0; i < depnam.Length; i++)
            {
                if(depnam[i].DeptID != 0)
                {
                    Console.WriteLine($"Department name {i+1} is: {depnam[i].DeptName}");
                }
            }
            Console.ReadKey();
        }
        public static void PrintEmpcount(Department[] depnam )
        {
            for (int i = 0; i < depnam.Length; i++)
            {
                int count = 0;
                if (depnam[i].DeptID != 0)
                {
                    Console.WriteLine($"Department name {i + 1} is: {depnam[i].DeptName}");
                }
                for(int j = 0; j < depnam[i].DeptEmployees.Length; j++)
                {
                    if (depnam[i].DeptEmployees[j].GetID() != 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The count of employees in this department is : {count}");
            }
            Console.ReadKey();
        }
        public static void DisplayEmpPercom(Department[] dep)
        {
            int count = 0;

            for (int i = 0; i < dep.Length; i++)
            {

                for (int z = 0; z <dep[i].DeptEmployees.Length; z++)
                {
                    if (dep[i].DeptEmployees[z].GetID() != 0)
                    {
                        count++;
                    }
                          
                }
            }

            Console.WriteLine($"The count of all employees in company is : {count}");
            Console.ReadKey();
        }
        public static void DeleteEmployee(Company x)
        {
            Console.Write("Enter Department name : ");
            string y = Console.ReadLine();
            Console.Write("Enter Employee ID : ");
            int r = int.Parse(Console.ReadLine());
            for (int i = 0; i < x.Departments.Length; i++)
            {
                if (x.Departments[i].DeptName == y)
                {
                    for (int j = 0; j < x.Departments[i].DeptEmployees.Length; j++)
                    {
                        if (x.Departments[i].DeptEmployees[j].GetID() == r)
                        {
                            x.Departments[i].DeptEmployees[j] = new Employee();
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Department[] dept = new Department[2];
            int x = 0;
            string s = "a";
            Console.WriteLine("Department Data is: ");
            for (int i = 0; i < dept.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Department {i + 1} :Data  ");
                do
                {
                    Console.Write("\tID = ");
                    x = int.Parse(Console.ReadLine());
                } while (CheckUniqeid(dept, x) == false);
                dept[i].DeptID = x;
                do
                {
                    Console.Write("\tName = ");
                    s = Console.ReadLine();
                } while (CheckUniqename(dept,s ) == false);
                dept[i].DeptName = s;
                Console.Write("\tMenager Name = ");
                dept[i].Manager = Console.ReadLine();
                Employee[] emp = new Employee[2];
                dept[i].DeptEmployees = InserEmp(emp);
                Console.WriteLine("************************************");
            }

            Console.Write("Enter Company name : ");
            string f = Console.ReadLine();
            Company orange = new Company(f, dept);
            //orange.print();
            ////Console.WriteLine($"{orange[2]} ");
            //Console.Write("Enter Department name : ");
            //string y = Console.ReadLine();
            //Console.Write("Enter Employee ID : ");
            //int r = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{orange[r,y]} ");
            Boolean flag = false;
            do
            {
                Console.Clear();
                Console.WriteLine($"a- Display All Department Name \n b- Display employees count per department \n c- Display total number of employees in company \n d- Search for employee by id in department \n e- Update employee name in dept \n f- Delete employee by id \n g- Exit");
                Console.Write("Please enter your choice --> ");
                char ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 'a':
                    case 'A':
                        PrintDepName(dept);
                        break;
                    case 'b':
                    case 'B':
                        PrintEmpcount(dept);
                        break;
                    case 'c':
                    case 'C':
                        DisplayEmpPercom(dept);
                        break;
                    case 'd':
                    case 'D':
                        Console.Write("Enter Department name : ");
                        string y = Console.ReadLine();
                        Console.Write("Enter Employee ID : ");
                        int r = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{orange[r, y]} ");
                        Console.ReadKey();
                        break;
                    case 'e':
                    case 'E':
                         Console.Write("Enter Department name : ");
                        string t = Console.ReadLine();
                        Console.Write("Enter Employee ID : ");
                        int w = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Employee name : ");
                        string nam = Console.ReadLine();
                        orange[w, t]=nam;
                        break;
                    case 'f':
                    case 'F':
                        DeleteEmployee(orange);
                        break;
                    case 'g':
                    case 'G':
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (flag != true);
            Console.ReadKey();
        }
    }
}
