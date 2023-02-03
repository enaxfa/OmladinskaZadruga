using Common;
using Repository.DBConnection;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class GenericDBRepository : IDBRepository<IDomenskiObjekat>
    {
        public void Add(IDomenskiObjekat entity)
        {
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"insert into {entity.TableName} values ({entity.InsertValues})");
            cmd.ExecuteNonQuery();
        }

        public void Close()
        {
            DBConnectionFactory.Instance.GetDBConnection().Close();
        }

        public void Commit()
        {
            DBConnectionFactory.Instance.GetDBConnection().Commit();
        }

        public void Rollback()
        {
            DBConnectionFactory.Instance.GetDBConnection().Rollback();
        }

        public void Delete(IDomenskiObjekat key)
        {
            throw new NotImplementedException();
        }

        public IDomenskiObjekat Get(IDomenskiObjekat key)
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> GetAll(IDomenskiObjekat entity)
        {
            List<IDomenskiObjekat> result;
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"select * from {entity.TableName}");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }


        public List<IDomenskiObjekat> Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public void Update(IDomenskiObjekat entity)
        {
            throw new NotImplementedException();
        }
    }
}
