using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.MigratorDB.Main
{
    [Serializable]
    public class ConnectionStringCollection
    {
        public string ConnectionStringSqlServer { get; set; } = string.Empty;
        public string ConnectionStringMySql { get; set; } = string.Empty;

    }
}
