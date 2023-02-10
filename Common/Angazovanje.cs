using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Angazovanje : IDomenskiObjekat
    {
        public Omladinac Omladinac { get; set; }
        public Posao Posao { get; set; }
        public DateTime DatumAngazovanja { get; set; }
        [Browsable(false)]
        public string TableName => "Angazovanje";
        [Browsable(false)]
        public string InsertValues => $"'{Omladinac.IDOmladinca}','{Posao.Poslodavac.IDPoslodavca}','{Posao.IdPosla}', '{DatumAngazovanja}'";
        [Browsable(false)]
        public object SelectValues => "o.id, o.ime, o.prezime, o.jmbg, o.brojracuna, o.brojtelefona, o.datumrodjenja" +
            ",p.id, p.naziv, p.pib, p.adresa, p.email, p.brojtelefona, tp.id, tp.Naziv, posao.Lokacija, posao.Satnica, posao.CenaRadnogSata, posao.brojOmladinaca, posao.Id, a.Datum";
        [Browsable(false)]
        public string SearchCondition => Uslov;
        [Browsable(false)]
        public string SetValues => $"Omladinac = {Omladinac.IDOmladinca}, Poslodavac = {Posao.Poslodavac.IDPoslodavca}, Posao = {Posao.IdPosla}, Datum = '{DatumAngazovanja}'";
        [Browsable(false)]
        public String Uslov { get; set; }
        [Browsable(false)]
        public string WhereCondition => $"Posao = {Posao.IdPosla} and Poslodavac = {Posao.Poslodavac.IDPoslodavca}";
        [Browsable(false)]
        public string JoinCondition => "join Posao on (a.Poslodavac = posao.Poslodavac and a.Posao = posao.Id) join Poslodavac p on (posao.Poslodavac = p.Id) join TipPosla tp on(posao.TipPosla = tp.Id)";
        [Browsable(false)]
        public string JoinTable => "join Omladinac o on (a.Omladinac = o.Id) ";
        [Browsable(false)]
        public string TableAlias => "a";
        [Browsable(false)]
        public List<IDomenskiObjekat> GetEntities(SqlDataReader reader)
        {
            List<IDomenskiObjekat> result = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                result.Add(new Angazovanje
                {
                    Omladinac = new Omladinac
                    {
                        IDOmladinca = (int)reader[0],
                        Ime = (string)reader[1],
                        Prezime = (string)reader[2],
                        JMBG = (string)reader[3],
                        BrojRacuna = (string)reader[4],
                        BrojTelefona = (string)reader[5],
                        DatumRodjenja = (DateTime)reader[6]
                    },
                    Posao = new Posao
                    {
                       
                       Poslodavac = new Poslodavac
                       {
                           IDPoslodavca = (int)reader[7],
                           Naziv = (string)reader[8],
                           PIB = (string)reader[9],
                           Adresa = (string)reader[10],
                           Email = (string)reader[11],
                           Kontakt = (string)reader[12],
                       },
                       TipPosla = new TipPosla
                       {
                           Id = (int)reader[13],
                           Naziv = (string)reader[14]
                       },
                       Lokacija = (string)reader[15],
                       Satnica = (int)reader[16],
                       CenaRadnogSata = (decimal)reader[17],
                       BrojOmladinaca = (int)reader[18],
                       IdPosla = (int)reader[19]
                    },
                    DatumAngazovanja = (DateTime)reader[20]
                });
            }
            return result;
        }

    }
}
