using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.DataAccess
{
    public static class GlobalConfig
    {
        public static IDataConnection connection;

        public static void StartConnection(DatabaseType dataBase)
        {
            if (dataBase == DatabaseType.SQLServer)
            {
                SQLServerDataAccess sql = new SQLServerDataAccess();
                connection = sql; 
            }

            else if (dataBase == DatabaseType.SQLite)
            {
                SQLiteDataAccess sql = new SQLiteDataAccess();
                connection = sql;
            }
        }

    }
}
