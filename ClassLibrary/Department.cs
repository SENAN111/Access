using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Department: Employee
    {
        public string _name;
        public int _employeeLimit;
        public float _salarylimit;
        public Department[] employee;
        public string DEpartmentname
        {
            get { return _name; } 
            set
            { 
                if(value.Trim().Length>3 && value.Trim().Length<30)
                {
                    _name = value.Trim();
                }
            }
        }
        public int EmployeeLimit
        {
            get { return _employeeLimit; }
            set
            {
                if(value>2 )
                {
                    _employeeLimit = value;
                }
            }
        }
        public float Salarylimit
        { get { return _salarylimit; }
            set
            {
                if(value>250 )
                {
                    _salarylimit = value;
                }
            }
                
        }
        //public Department(string name)
        //{
        //    _name= name;
        //    employee = new Department[0];
        //}
       

    }



    }
}
