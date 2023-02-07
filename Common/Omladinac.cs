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
    public class Omladinac : IDomenskiObjekat
    {
        [Browsable(false)]
        public int IDOmladinca { get; set; }
        public String Ime { get; set; }

        public String Prezime { get; set; }

        public String JMBG { get; set; }

        public String BrojTelefona { get; set; }

        public String BrojRacuna { get; set; }

        public DateTime DatumRodjenja { get; set; }

        [Browsable(false)]
        public string TableName => "Omladinac";
        [Browsable(false)]
        public string InsertValues => $"'{Ime}','{Prezime}', '{JMBG}','{BrojTelefona}',{BrojRacuna},'{DatumRodjenja}'";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string SearchCondition => Uslov;
        [Browsable(false)]
        public string Uslov { get; set; }

        [Browsable(false)]
        public string SetValues => $"Ime='{Ime}',Prezime='{Prezime}',DatumRodjenja='{DatumRodjenja}',JMBG='{JMBG}',BrojTelefona='{BrojTelefona}',BrojRacuna={BrojRacuna}";

        [Browsable(false)]
        public string WhereCondition => $"Id={IDOmladinca}";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "";

        [Browsable(false)]
        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Omladinac
                {
                    IDOmladinca = (int)reader[0],
                    Ime = (string)reader[1],
                    Prezime = (string)reader[2],
                    JMBG = (string)reader[3],
                    BrojTelefona = (string)reader[4],
                    BrojRacuna = (string)reader[5],
                    DatumRodjenja = (DateTime)reader[6]
                });
            }
            return result;
        }
    }
}
