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
    public class Posao : IDomenskiObjekat
    {
        public int IdPosla { get; set; }
        public String Lokacija { get; set; }
        public int Satnica { get; set; }
        public int CenaRadnogSata { get; set; }
        public int BrojOmladinaca { get; set; }
        public Poslodavac Poslodavac { get; set; }
        public TipPosla TipPosla { get; set; }
        [Browsable(false)]
        public string TableName => "Posao";
        [Browsable(false)]
        public string InsertValues => $"'{Lokacija}', '{Satnica}','{CenaRadnogSata}','{BrojOmladinaca}', '{Poslodavac.IDPoslodavca}', '{TipPosla.Id}'";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string SearchCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string SetValues => $"Id = '{IdPosla}', Lokacija = '{Lokacija}', Satnica = '{Satnica}', Cena radnog sata = '{CenaRadnogSata}', Broj omladinaca = '{BrojOmladinaca}', Poslodavac = '{Poslodavac.IDPoslodavca}', TipPosla = '{TipPosla.Id}'";
        [Browsable(false)]
        public string WhereCondition =>$"Id = {IdPosla}";
        [Browsable(false)]
        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Posao
                {
                    IdPosla = (int)reader[0],
                    Lokacija = (string)reader[1],
                    Satnica = (int)reader[2],
                    CenaRadnogSata = (int)reader[3],
                    BrojOmladinaca = (int)reader[4],
                    Poslodavac = new Poslodavac
                    {
                        IDPoslodavca = (int)reader[5]
                    },
                    TipPosla = new TipPosla
                    {
                        Id = (int)reader[6]
                    }
                });
            }
            return result;
        }
    }
}
