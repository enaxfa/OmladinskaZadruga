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
        string SelectValues { get; }
        string SearchCondition { get; }
        string SetValues { get;  }
        string WhereCondition { get; }
        string JoinCondition { get; }
        string JoinTable { get; }
        string TableAlias { get; }

        List<IDomenskiObjekat> GetEntities(SqlDataReader reader);
    }
}
