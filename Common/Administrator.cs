using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Administrator : IDomenskiObjekat
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Sifra { get; set; }
        public String KorisnickoIme { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Administrator k)
                return k.KorisnickoIme == this.KorisnickoIme && k.Sifra == this.Sifra;
            return false;
        }
        public string TableName => "Administrator";

        public string InsertValues => "";

        public object SelectValues => "*";

        public string SearchCondition => "";

        public string SetValues => "";
        public string WhereCondition => "";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "";

        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Administrator
                {
                    Ime = reader[1].ToString(),
                    Prezime = reader[2].ToString(),
                    Sifra = reader[3].ToString(),
                    KorisnickoIme = reader[4].ToString()
                });
            }
            return result;
        }
    }
}
