using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Poslodavac : IDomenskiObjekat
    {

        public int IDPoslodavca { get; set; }
        public String Naziv { get; set; }
        public String PIB { get; set; }
        public String Adresa { get; set; }
        public String Email { get; set; }
        public String BrojTelefona { get; set; }

        public string TableName => "Poslodavac";

        public string InsertValues => $"'{Naziv}', '{PIB}', '{Adresa}','{Email}','{BrojTelefona}'";

        public object SelectValues => "*";

        public String Uslov { get; set; }
        public string SearchCondition => Uslov;

        public string SetValues => $"Naziv = '{Naziv}', PIB = '{PIB}', Adresa = '{Adresa}', Email = '{Email}', BrojTelefona = '{BrojTelefona}'";

        public string WhereCondition => $"Id = {IDPoslodavca}";

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
                    BrojTelefona = (string)reader[5],
                });
            }
            return result;
        }
    }
}
