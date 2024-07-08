using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assigment_OOP_2
{
    internal class employees
    {
        #region Attributes
        
        private int id;
        private string name;
        private int securityLevel;
        private decimal salary;
        private DateTime hireDate;
        private char gender;

        #endregion

        #region Properties


        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID must be a positive integer.");
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty.");
                name = value;
            }
        }

        public int SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException("Security level must be between 1 and 5.");
                securityLevel = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                salary = value;
            }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Hire date cannot be in the future.");
                hireDate = value;
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value != 'M' && value != 'F' && value != 'O')
                    throw new ArgumentException("Gender must be 'M' for male, 'F' for female, or 'O' for other.");
                gender = value;
            }
        }

        #endregion
        
        #region Constructors

        public Employee(int id, string name, int securityLevel, decimal salary, DateTime hireDate, char gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        #endregion
        
        #region Method

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate:d}, Gender: {Gender}";
        } 
        #endregion
    
    }
 }
