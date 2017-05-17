using _20170516_odev.DAL.IRepositories.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20170516_odev.Entity;
using System.Data.Common;
using _20170516_odev.DAL.DALExtension;
using _20170516_odev.Entity.Enums;

namespace _20170516_odev.DAL.Repositories.Blog
{
    public class KategoriManagement : IKategori
    {
        public ICollection<Kategoriler> GetAll()
        {
            ICollection<Kategoriler> returnList = new List<Kategoriler>();
            DbDataReader dr = (DbDataReader)DALHelper.ExecReader("sp_GetAllKategoriler", Databases.MSSQL);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Kategoriler kate = new Kategoriler();
                    kate.KategoriID = Convert.ToInt32(dr["KategorilerID"] == null ? 0 : dr["KategorilerID"]);
                    kate.KategoriAdi = dr["KategoriName"] == null ? "" : dr["KategoriName"].ToString();
                    returnList.Add(kate);
                }
            }
            return returnList;
        }
    }
}
