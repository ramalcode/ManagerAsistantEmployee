using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Moduls
{
    internal class Emplyee
    {
        private string _name;
        public bool _isSuccessfull = true;
        private double _salary;

        public string Name 
        { 
            get=> _name;
            set
            {
                if (value.Trim().Length>2)
                {
                    _name = value.Trim();

                }
            } 
        }

        public double Salary
        {
            get => _salary;
            set
            {
                if (value>250)
                {
                    _salary=value;  
                }
            }
        }

        public bool IsSuccesfull
        {
            get => _isSuccessfull;
            set
            {
                _isSuccessfull = value;

            }

        }

        public Emplyee(string name, double salary, bool issuccesful)
        {
            Name = name;
            Salary=salary;
            IsSuccesfull = issuccesful;
        }
    }
}
