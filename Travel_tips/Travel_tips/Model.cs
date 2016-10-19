]using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
namespace Travel_tips
{
    public class Model
    {
        public Oracle.ManagedDataAccess.Client.OracleConnection Connrecton;
        public Path CurentPath;
        public User CurentUser;
    }
}
