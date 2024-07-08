using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assigment_OOP_2
{
    public enum SecurityLevel
    {
        Guest,
        Secretary,
        DBA,
        SecurityOfficer
    }
    internal class employees
    {
        #region Attributes
        
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private decimal salary;
        private HiringDate hireDate;
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

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                if (Enum.IsDefined(typeof(SecurityLevel) , value))
                    throw new ArgumentException("Invalid Security Level");
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

        public HiringDate HireDate
        {
            get { return hireDate; }
            set
            {
                if (value.Year > DateTime.Now.Year ||
                (value.Year == DateTime.Now.Year && value.Month > DateTime.Now.Month) ||
                (value.Year == DateTime.Now.Year && value.Month == DateTime.Now.Month && value.Day > DateTime.Now.Day))
                {
                    throw new ArgumentException("Hire date cannot be in the future.");
                }
                hireDate = value;
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value != 'M' && value != 'F' && value != 'O')
                    throw new ArgumentException("Gender must be 'M' for male, 'F' for female");
                gender = value;
            }
        }

        #endregion
        
        #region Constructors

        public employees(int id, string name, int securityLevel, decimal salary, DateTime hireDate, char gender)
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
