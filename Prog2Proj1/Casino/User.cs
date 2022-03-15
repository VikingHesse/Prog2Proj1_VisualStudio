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

        // La till variabler, annars "The name "Currentusername" does not exist in the current context"
        public string CurrentUsername { get; set; }
        public string CurrentPassword { get; set; }

        //ändrade public till public void
        public void LoginUser(string Username, string Password)
        {
            if (Username == CurrentUsername && Password == CurrentPassword)
            {
                System.Console.WriteLine("You are logged in");
            }
            else
            {
                System.Console.WriteLine("Username or password is incorrect, try again");
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
