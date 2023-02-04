using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Omladinac : IDomenskiObjekat
    {
        public String Ime { get; set; }

        public String Prezime { get; set; }

        public String JMBG { get; set; }

        public String BrojTelefona { get; set; }

        public String BrojRacuna { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public string TableName => "Omladinac";

        public string InsertValues => $"'{Ime}','{Prezime}', '{JMBG}','{BrojTelefona}',{BrojRacuna},'{DatumRodjenja}'";

        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Omladinac
                {
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
