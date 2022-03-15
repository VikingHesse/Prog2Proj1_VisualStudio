using System;
using System.Collections.Generic;

namespace Casino
{
    class Managers : Employees
    {
        private HireEmployee()
        {
            if(Console.ReadLine("Dealers"))
            {
                Dealers dealer1 = new Dealers();
            }
            else if(Console.ReadLine("Programmers"))
            {
                Programmers programmer = new Programmers();
            }
        }
        private FireEmployee()
        {
            int ID = int.Parse(Console.Read());

            Employees.RemoveEmployee(ID);
        }
        private CheckEmployee(int id)
        { 
           int id = int.Parse(Console.Read());
        }

        public Managers(int id, string Name)
        {
            this.id = id;
            this.Name = Name;
        }

        public list<Programmers> AllProgrammers { get; set; } = new list<Programmers>();

        public List<Dealers> AllDealers { get; set; } = new list<Dealers>();
    }
}