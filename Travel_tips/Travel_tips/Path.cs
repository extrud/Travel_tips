using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
namespace Travel_tips
{
    public class Path 
    {
        string name;
        List<int> points = new List<int>(); //Их Айдишники
        int id;
        int raiting;
        List<string> Comments = new List<string>();
        internal List<int> Points
        {
            get { return points; }
            set { points = value; }
        }
        string discription;

        public Path(string name, int id, int raiting)
        {
            this.name = name;    
            this.id = id;
            this.raiting = raiting;
        }

        public string Discription
        {
            get { return discription; }
            set { discription = value; }
        }
       
        public int Raiting
        {
            get { return raiting; }
            set { raiting = value; }
        }
        void Update()
        {
 
        }

      
    }
}
