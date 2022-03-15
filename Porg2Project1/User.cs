using System;

namespace Casino
{
    class User{
        public string Username { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public int age { get; set; }
        public bool BankId { get; set; }
    
        


        public LoginUser(string Username, string Password){
            
            if(Username == currentUsename && Password == currentPassword){
                return System.Console.WriteLine("You are logged in");
            
            }else
            {
                System.Console.WriteLine("Username or password is incorrect try again");
                    
            }
        }

        public LoginBankId(){
            return false;
        }


        public Users(int Id, string Username, string Password, string FirstName, string LastName, int age, bool BankId){
            
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.age = age;
            this.BankId = BankId;

        }
    }
}


