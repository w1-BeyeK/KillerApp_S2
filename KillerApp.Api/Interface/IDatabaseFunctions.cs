using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Api.Interface
{
    interface IDatabaseFunctions
    {
        string GetConnection();
        DataTable ExecSelect(string query);
        bool ExecOther(string query);
    }
}
