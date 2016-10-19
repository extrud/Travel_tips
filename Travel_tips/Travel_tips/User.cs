using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_tips
{
    class User
    {
        string name;
        string lastname;
        string birthday;
        int id;
        List<Path> Pathes = new List<Path>();

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
