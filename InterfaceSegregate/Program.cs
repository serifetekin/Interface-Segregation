using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregate
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAccess dba = new DbAccess();
            dba.SQLCalistir("SQL");

            DbSqlServer dbs = new DbSqlServer();
            dbs.SQLCalistir("sql");
            dbs.SPCalistir("sql");

            Console.ReadLine();
        }
    }
}
