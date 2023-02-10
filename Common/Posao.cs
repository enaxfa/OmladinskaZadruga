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
        [Browsable(false)]
        public int IdPosla { get; set; }
        public Poslodavac Poslodavac { get; set; }
        public TipPosla TipPosla { get; set; }
        public String Lokacija { get; set; }
        public int Satnica { get; set; }
        public decimal CenaRadnogSata { get; set; }
        public int BrojOmladinaca { get; set; }

        public override string ToString()
        {
            return Poslodavac.Naziv + "-" + TipPosla.Naziv;
        }

        [Browsable(false)]
        public string TableName => "Posao";
        [Browsable(false)]
        public string InsertValues => $"'{Lokacija}', '{Satnica}','{CenaRadnogSata}','{BrojOmladinaca}', '{Poslodavac.IDPoslodavca}', '{TipPosla.Id}'";
        [Browsable(false)]
        public object SelectValues => "p.Id, p.Naziv, tp.Id, tp.Naziv, posao.Id, posao.Lokacija, posao.Satnica, posao.CenaRadnogSata, posao.BrojOmladinaca";
        [Browsable(false)]
        public String Uslov { get; set; }
        [Browsable(false)]
        public string SearchCondition => Uslov;
        [Browsable(false)]
        public string SetValues => $"Lokacija = '{Lokacija}', Satnica = '{Satnica}', CenaRadnogSata = '{CenaRadnogSata}', BrojOmladinaca = '{BrojOmladinaca}', Poslodavac = '{Poslodavac.IDPoslodavca}', TipPosla = '{TipPosla.Id}'";
        [Browsable(false)]
        public string WhereCondition =>$"Id = {IdPosla} and Poslodavac = {Poslodavac.IDPoslodavca}";
        [Browsable(false)]
        public string JoinCondition => "on (posao.Poslodavac=p.Id) join TipPosla tp on (tp.Id=posao.TipPosla)";
        [Browsable(false)]
        public string JoinTable => "join Poslodavac p";
        [Browsable(false)]
        public string TableAlias => "";

        [Browsable(false)]
        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Posao
                {
                    Poslodavac = new Poslodavac
                    {
                        IDPoslodavca = (int)reader[0],
                        Naziv = (string)reader[1],
                    },
                    TipPosla = new TipPosla
                    {
                        Id = (int)reader[2],
                        Naziv = (string)reader[3]
                    },
                    IdPosla = (int)reader[4],
                    Lokacija = (string)reader[5],
                    Satnica = (int)reader[6],
                    CenaRadnogSata = (decimal)reader[7],
                    BrojOmladinaca = (int)reader[8],
                    
                });
            }
            return result;
        }
    }
}
