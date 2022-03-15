using System;

namespace Casino
{
    class Employees
    {
        public int Id { get; set;}
        private int AmountOfEmployees { get; set; }
        public string Name { get; set; }

        public CheckIn(int Id)
        {
            return true;
        }

        public RemoveEmployee(int Id)
        {
            Id = null;
        }
    }
}