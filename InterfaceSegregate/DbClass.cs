using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregate
{
    interface IDbClass
    {
        void TabloGetir(string sql);
        void SQLCalistir(string sql);
    }

    interface ISqlServer
    {
        void SPCalistir(string sql);
    }

    class DbAccess : IDbClass
    {

        public void SQLCalistir(string sql)
        {
            Console.WriteLine("sql çalıştı");
        }

        public void TabloGetir(string sql)
        {
            Console.WriteLine("tablo getirildi");
        }
    }
    class DbSqlServer : IDbClass, ISqlServer
    {
        public void SPCalistir(string sql)
        {
            Console.WriteLine("sp çalıştı");
        }

        public void SQLCalistir(string sql)
        {
            Console.WriteLine("sql çalıştı");
        }

        public void TabloGetir(string sql)
        {
            Console.WriteLine("tablo getirildi");
        }
    }
}
