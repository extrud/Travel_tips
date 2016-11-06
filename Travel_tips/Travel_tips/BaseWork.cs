using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace Travel_tips
{
    static class BaseWork
    {
        static Oracle.ManagedDataAccess.Client.OracleConnection Connection;
        public static void InitConnection()
        {

        }
        public static bool TryLogin(string log, string pass)
        {
            return true;
        }
        public static User GetUser(int id)
        {
            return null;
        }
        public static Path GetPath(int id)
        {
            return null;
        }
        public static Travel_Point GetPoint(int id)
        {
            return null;
        }
        public static User[] GetAllUser()
        {
            return null;
        }
        public static Path[] GetAllPathes()
        {
            return null;
        }
        public static void CreatePath(Travel_Point[] points, int id, string pathname, string discription)
        {
        }
        public static void DeletePath(int id)
        {
        }
        public static void EneblePath(int id)
        {
        }
        public static void DisablePath(int id)
        {
        }

    }
}
