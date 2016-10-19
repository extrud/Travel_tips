using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_tips
{
    public static class ContentManger
    {
        
        public static User GetUser(int id)
        {
            return new User("Db not set","Db not set","Db not set",0);
        }
        public static Path GetPath(int id)
        {
            return new Path("Db not set",0,0);
        }



    }
}
