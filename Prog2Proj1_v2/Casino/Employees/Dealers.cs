using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Dealers : Employees
    {
        //Ändrade public till public void
        public void DealCards()
        {
            return;
        }

        //Ändrade public till public void
        public void ShuffleDeck()
        {
        }

        //Tog bort "new", läs mer: https://stackoverflow.com/questions/32691362/the-modifier-new-is-not-valid-for-this-item
        public Dealers(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }


        //Ändrade public till public void
        public void LeaveCasino(int Id)
        {
            Employees.RemoveEmployee(this.Id);
        }


    }
}
