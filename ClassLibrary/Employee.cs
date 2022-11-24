using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Employee
    {
        public string _name;
        public string _surname;
        double _salary;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length > 2 && value.Trim().Length < 20)
                {
                    if (CheckName(value))
                    {
                        _name = value;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong name");
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 2 && value.Length < 20)
                {
                    if(CheckUsername(value)) 
                    { 
                        _surname = value;
                    }
                    else
                    {
                        Console.WriteLine("Wrong suraname");
                    }
                }
            }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Wrong salary");
                }

            }
        }

        public bool CheckName(string name)
        {
            bool firstupper = false;
            bool letter = false;

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsUpper(name[0]))
                {
                    firstupper = true;
                }
                if (char.IsLetter(name[i]))
                {
                    letter = true;
                }
               
            }
            if (letter && firstupper) 
            {
                return true;
            }
            return false;
        }
        public bool CheckUsername(string surname)
        {
            bool firstupper = false;
            bool letter = false;

            for (int i = 0; i < surname.Length; i++)
            {
                if (char.IsUpper(surname[0]))
                {
                    firstupper = true;
                }
                if (char.IsLetter(surname[i]))
                {
                    letter = true;
                }

            }
            if (letter && firstupper)
            {
                return true;
            }
            return false;

        }
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
    }
}

