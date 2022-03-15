using System;

namespace Casino
{
    class Dealers : Employees // : betyder inheritence
    {
        public DealCards()
        {
            return;
        }

        public ShuffleDeck(){

        }

        public new Dealers(int id, string Name)
        {
            this.id = id;
            this.Name = Name;
        }

        public LeaveCasino(int id){
            Employees.RemoveEmployee(this.id);
        }

    }
}