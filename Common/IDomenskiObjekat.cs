using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IDomenskiObjekat
    {
        string TableName { get; }
        string InsertValues { get; }
        object SelectValues { get; }
        string SearchCondition { get; }
        List<IDomenskiObjekat> GetEntities(SqlDataReader reader);
    }
}
