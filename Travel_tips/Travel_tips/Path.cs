using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
namespace Travel_tips
{
    class Path
    {
        List<Travel_Point> points = new List<Travel_Point>();
        int id;

        internal List<Travel_Point> Points
        {
            get { return points; }
            set { points = value; }
        }
        string discription;

        public string Discription
        {
            get { return discription; }
            set { discription = value; }
        }
        int raiting;
        List<string> Comments = new List<string>();
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
