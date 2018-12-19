using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Model
{
    public class Acounts
    {
        static public List<UserInfo> users = new List<UserInfo>
        {
            new UserInfo{ Name = "omer" , Pass = "123"},
            new UserInfo{ Name = "ahmet" , Pass = "123"}
        };
    }
}
