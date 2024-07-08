using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct PhoneBook
    {
        #region Attributes
        private String[] names;
        private long[] numbers;
        private int size;
        #endregion

        #region Property
        public int Size // readonly property
        {

            get { return size; }
        }
        #endregion

        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new String[size];
            numbers = new long[size];
        }
        public PhoneBook()
        {
            size = 0;
            names = default;
            numbers = default;
        }
        #endregion

        #region Methods
        public long GetNumber(string name)
        {
            if (names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }

        public void setNumber(string name, long value)
        {
            if (names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        break;
                    }
                }
            }
        }
        public void AddPerson(int index, string name, long number)
        {
            if (names != null && numbers != null)
            {
                if (index >= 0 && index < size)
                {
                    names[index] = name;
                    numbers[index] = number;
                }
            }

        } 
        //2
        public long this[string name]
        {
            get
            {
                if (names != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            break;
                        }
                    }
                }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"position : {index}\nName : {names[index]}\nNumber : {numbers[index]}\n";
            }
        }
        #endregion
    }
}
