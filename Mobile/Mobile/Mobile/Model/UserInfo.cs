using Mobile.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Model
{
    public class UserInfo
    {
        public String Name { get; set; } 
        public String Pass { get; set; }
        public String Email { get; set; }

        public List<Ingredient> fridge = new List<Ingredient>();
    }
}
