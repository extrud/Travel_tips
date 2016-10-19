using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
namespace Travel_tips
{
    class Travel_Point
    {
        int pathId;
        int id;
        PointLatLng point;
        string Discription_text;
        string Img;
        public Travel_Point(PointLatLng point, string discription_text, string img, int pId)
        {
            this.point = point;
            Discription_text = discription_text;
            Img = img;
            pathId = pId;
        }
        public PointLatLng Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public string Discription_text1
        {
            get
            {
                return Discription_text;
            }

            set
            {
                Discription_text = value;
            }
        }

        public string Img1
        {
            get
            {
                return Img;
            }

            set
            {
                Img = value;
            }
        }
    }
}
