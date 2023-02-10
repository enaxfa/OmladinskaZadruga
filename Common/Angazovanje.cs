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
        public object SelectValues => "a.id, o.id, o.ime, o.prezime, o.jmbg, o.brojracuna, o.brojtelefona, o.datumrodjenja" +
            ",p.id, p.naziv, p.pib, p.adresa, p.email, p.brojtelefona, tp.id, tp.Naziv, posao.Lokacija, posao.Satnica, posao.CenaRadnogSata, posao.brojOmladinaca, a.Datum";
        [Browsable(false)]
        public string SearchCondition => Uslov;
        [Browsable(false)]
        public string SetValues => $"Omladinac = {Omladinac.IDOmladinca}, Poslodavac = {Posao.Poslodavac.IDPoslodavca}, Posao = {Posao.IdPosla}, Datum = {DatumAngazovanja}";
        [Browsable(false)]
        public String Uslov { get; set; }
        [Browsable(false)]
        public string WhereCondition => $"Id = {Id}";
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
                    Id = (int)reader[0],
                    Omladinac = new Omladinac
                    {
                        IDOmladinca = (int)reader[1],
                        Ime = (string)reader[2],
                        Prezime = (string)reader[3],
                        JMBG = (string)reader[4],
                        BrojRacuna = (string)reader[5],
                        BrojTelefona = (string)reader[6],
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
                           Kontakt = (string)reader[13],
                       },
                       TipPosla = new TipPosla
                       {
                           Id = (int)reader[14],
                           Naziv = (string)reader[15]
                       },
                       Lokacija = (string)reader[16],
                       Satnica = (int)reader[17],
                       CenaRadnogSata = (decimal)reader[18],
                       BrojOmladinaca = (int)reader[19]
                    },
                    DatumAngazovanja = (DateTime)reader[20]
                });
            }
            return result;
        }

    }
}
