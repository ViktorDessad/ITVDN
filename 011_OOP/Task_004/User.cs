using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    class User
    {
        private string login = "login";
        private string firstName = "firstName";
        private string secondName = "second";
        private int age = 28;
        private string date = "08/11/2019";

        public string Login
        {
            get { return login; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string SecondName
        {
            get { return secondName; }
        }

        public int Age
        {
            get { return age; }
        }

        public string Date
        {
            get { return date; }
        }

        User user;

        public void UserInfo()
        {
            user = new User();
            Console.WriteLine(user.Login);
            Console.WriteLine(user.FirstName);
            Console.WriteLine(user.SecondName);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Date);
        }

    }
}
