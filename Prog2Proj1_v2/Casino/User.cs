using System;


namespace Casino
{

    class User
    {
        public string Username { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool BankId { get; set; }

        //ändrade public till public void
        public void LoginUser()
        {
            bool Loggin = false;
            int tries = 0;
            while (Loggin == false)
            {
                string uUsername = Console.ReadLine();
                string pPassword = Console.ReadLine();
                if (uUsername == Username && pPassword == Password)
                {
                    System.Console.WriteLine("Du är inloggad!");
                    Loggin = true;
                }
                else
                {
                    System.Console.WriteLine("Användarnamn eller lösenord fel, försök igen.");
                    tries++;
                }
            }
        }

        //Ändrade public till public bool
        public bool LoginBankId()
        {
            return false;
        }

        //Döpte om till User
        public User(int Id, string Username, string Password, string FirstName, string LastName, int Age, bool BankId)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.BankId = BankId;

        }


    }

}