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
    public class Angazovanje : IDomenskiObjekat
    {
        [Browsable(false)]
        public int Id { get; set; }
        public Omladinac Omladinac { get; set; }
        public Posao Posao { get; set; }
        public DateTime DatumAngazovanja { get; set; }
        [Browsable(false)]
        public string TableName => "Angazovanje";
        [Browsable(false)]
        public string InsertValues => $"'{Omladinac.IDOmladinca}','{Posao.Poslodavac.IDPoslodavca}','{Posao.IdPosla}', '{DatumAngazovanja}'";
        [Browsable(false)]
        public object SelectValues => throw new NotImplementedException();
        [Browsable(false)]
        public string SearchCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string SetValues => throw new NotImplementedException();
        [Browsable(false)]
        public string WhereCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]
        public string TableAlias => throw new NotImplementedException();
        [Browsable(false)]
        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Angazovanje
                {
                    Id = (int)reader[0],
                    Omladinac = new Omladinac
                    {
                        IDOmladinca = (int)reader[1],
                        Ime = (string)reader[2],
                        Prezime = (string)reader[3],
                        JMBG = (string)reader[4],
                        BrojTelefona = (string)reader[5],
                        BrojRacuna = (string)reader[6],
                        DatumRodjenja = (DateTime)reader[7]
                    },
                    Posao = new Posao
                    {
                       Poslodavac = new Poslodavac
                       {
                           IDPoslodavca = (int)reader[8],
                           Naziv = (string)reader[9],
                           PIB = (string)reader[10],
                           Adresa = (string)reader[11],
                           Email = (string)reader[12],
                           Kontakt = (string)reader[13]
                       },
                       TipPosla = new TipPosla
                       {
                           Id = (int)reader[14],
                           Naziv = (string)reader[15]
                       },
                       BrojOmladinaca = (int)reader[16]
                    },
                    DatumAngazovanja = (DateTime)reader[17]
                });
            }
            return result;
        }
    }
}
