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
    public class Poslodavac : IDomenskiObjekat
    {
        [Browsable(false)]
        public int IDPoslodavca { get; set; }
        public String Naziv { get; set; }
        public String PIB { get; set; }
        public String Adresa { get; set; }
        public String Email { get; set; }
        public String Kontakt { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }

        [Browsable(false)]
        public string TableName => "Poslodavac";
        [Browsable(false)]
        public string InsertValues => $"'{Naziv}', '{PIB}', '{Adresa}','{Email}','{Kontakt}'";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public String Uslov { get; set; }
        [Browsable(false)]
        public string SearchCondition => Uslov;
        [Browsable(false)]
        public string SetValues => $"Naziv = '{Naziv}', PIB = '{PIB}', Adresa = '{Adresa}', Email = '{Email}', BrojTelefona = '{Kontakt}'";
        [Browsable(false)]
        public string WhereCondition => $"Id = {IDPoslodavca}";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";

        [Browsable(false)]
        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Poslodavac
                {
                    IDPoslodavca = (int)reader[0],
                    Naziv = (string)reader[1],
                    PIB = (string)reader[2],
                    Adresa = (string)reader[3],
                    Email = (string)reader[4],
                    Kontakt = (string)reader[5],
                });
            }
            return result;
        }

    }
}
