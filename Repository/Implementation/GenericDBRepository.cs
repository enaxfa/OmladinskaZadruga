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

        public void Add(IDomenskiObjekat entity)
        {
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"insert into {entity.TableName} values ({entity.InsertValues})");
            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Delete(IDomenskiObjekat entity)
        {

            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"delete from {entity.TableName} where {entity.WhereCondition}");
            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }


        public List<IDomenskiObjekat> GetAll(IDomenskiObjekat entity)
        {
            List<IDomenskiObjekat> result;
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition}");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }



        public void Update(IDomenskiObjekat entity)
        {
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"update {entity.TableName} set {entity.SetValues} where {entity.WhereCondition}");
            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IDomenskiObjekat> GetAllWithCondition(IDomenskiObjekat entity)
        {
            List<IDomenskiObjekat> result;
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} where {entity.SearchCondition}");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }
    }
}
