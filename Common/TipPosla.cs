using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class TipPosla : IDomenskiObjekat
    {
        [Browsable(false)]
        public int Id { get; set; }
        public String Naziv { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }

        [Browsable(false)]
        public string TableName => "TipPosla";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string SearchCondition => "";
        [Browsable(false)]
        public string SetValues => "";
        [Browsable(false)]
        public string WhereCondition => $"Id = {Id}";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "";

        [Browsable(false)]
        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new TipPosla
                {
                    Id = (int)reader[0],
                    Naziv = (string)reader[1]
                });
            }
            return result;
        }
    }
}
