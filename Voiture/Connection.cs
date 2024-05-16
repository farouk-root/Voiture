using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Voiture
{
    class Connection
    {
        public static OleDbConnection GetConnection()
        {
            const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\farouk\\Desktop\\Voiture\\VOITURE.accdb";
            return new OleDbConnection(connectionString);
        }
    }
}
