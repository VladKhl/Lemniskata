using System;
using System.Collections.Generic;
using System.Text;

namespace Lemniskata.db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
       
    }
}
