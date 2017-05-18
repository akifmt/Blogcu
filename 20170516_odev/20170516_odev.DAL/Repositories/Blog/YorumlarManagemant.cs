using _20170516_odev.DAL.IRepositories.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20170516_odev.Entity;
using System.Data.SqlClient;
using _20170516_odev.DAL.DALExtension;
using _20170516_odev.Entity.Enums;
using System.Data.Common;
using _20170516_odev.DAL.IRepositories;

namespace _20170516_odev.DAL.Repositories.Blog
{
    public class YorumlarManagemant : IYorum
    {
        public int Add(Yorumlar yeniYor)
        {
            int sonuc;

            Dictionary<string, object> param = new Dictionary<string, object>();
            
            param.Add("@AdiSoyad", yeniYor.AdiSoyadi);
            param.Add("@YorumIcerik", yeniYor.Yorumicerik);
            param.Add("@Email", yeniYor.Email);
            param.Add("@MakaleID", yeniYor.MakaleID);

            sonuc = (int)DALHelper.ExecNonQuery("sp_AddYorum", Databases.MSSQL, param);
            return sonuc;
        }

        public int Delete(Yorumlar parameter)
        {
            throw new NotImplementedException();
        }

        public ICollection<Yorumlar> GetByID(int? parameter, Yorumlar parameter1)
        {
            int gelenMakaleID = (int)parameter;

            ICollection<Yorumlar> returnList = new List<Yorumlar>();


            DbDataReader dr = (DbDataReader)DALHelper.ExecReader("sp_GetYorumlarByID", Databases.MSSQL, (int)parameter, "@MakaleID");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Yorumlar yorum = new Yorumlar();
                    yorum.MakaleID = Convert.ToInt32(dr["MakaleID"] == null ? 0 : dr["MakaleID"]);
                    yorum.AdiSoyadi = dr["AdiSoyad"] == null ? "" : dr["AdiSoyad"].ToString();
                    yorum.Yorumicerik = dr["YorumIcerik"] == null ? "" : dr["YorumIcerik"].ToString();

                    returnList.Add(yorum);
                }
            }
            return returnList;
            
        }

        Yorumlar IGetByID<Yorumlar, int>.GetByID(int? parameter, Yorumlar parameter1)
        {
            throw new NotImplementedException();
        }
    }
}
