using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280_Assignment_5
{
    public class User
    {
        /// <summary>
        /// Create an object "User" that has a name and an age
        /// </summary>
        /// 
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Create the user from the input from MainMenu
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        public static void AddNewUser(string Name, int Age)
        {
            User myUser = new User(Name, Age); 
        }
    }
}
