using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Manager : Employees
    {

        //Ändrade private till private void

        public Manager(int Id, string name)
        {
            this.Id = Id;
            this.Name = name;
        }
        private void HireEmployee()
        {

            //La till en input string för att kunna använda if, else if. 
            string input = Console.ReadLine();

            //La till 
            if (input == "Dealers")
            {
                Dealers dealer1 = new Dealers(Id, Name);
            }
            else if (input == "Programmers")
            {
                Programmers programmer = new Programmers(Id, Name);
            }
        }

        //Ändrade private till private void
        private void CheckEmployee(int id)
        {
            int Id = int.Parse(Console.ReadLine());
        }

        //Ändrade private till private void
        public void Managers(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public List<Programmers> AllProgrammers { get; set; } = new List<Programmers>();

        public List<Dealers> AllDealers { get; set; } = new List<Dealers>();

    }
}
