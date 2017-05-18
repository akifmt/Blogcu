using _20170516_odev.DAL.IRepositories.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20170516_odev.Entity;
using _20170516_odev.DAL.DALExtension;
using _20170516_odev.Entity.Enums;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace _20170516_odev.DAL.Repositories.Blog
{
    public class MakaleManagement : IMakale
    {
        public int Add(Makaleler yeniMak)
        {
            int sonuc;

            Dictionary<string, object> param = new Dictionary<string, object>();
            
            param.Add("@Baslık", yeniMak.Baslik);
            param.Add("@Icerik", yeniMak.Icerik);
            param.Add("@MakaleFotoPath", yeniMak.MakaleFotoPath);
            param.Add("@KategoriID", yeniMak.KategoriID);
            param.Add("@YazarUserName", yeniMak.YazarUserName);

            sonuc = (int)DALHelper.ExecNonQuery("sp_AddMakale", Databases.MSSQL, param);
            return sonuc;
        }

        public int Delete(Makaleler parameter)
        {
            throw new NotImplementedException();
        }

        public ICollection<Makaleler> GetAll()
        {
            ICollection<Makaleler> returnList = new List<Makaleler>();
            DbDataReader dr = (DbDataReader)DALHelper.ExecReader("GetMakaleWithKategori", Databases.MSSQL);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Makaleler maka = new Makaleler();
                    maka.Kategori = new Kategoriler();
                    maka.MakaleID = Convert.ToInt32(dr["MakaleID"] == null ? 0 : dr["MakaleID"]);
                    maka.Baslik = dr["Baslık"] == null ? "" : dr["Baslık"].ToString();
                    maka.Icerik = dr["Icerik"] == null ? "" : dr["Icerik"].ToString();
                    maka.KategoriID = Convert.ToInt32(dr["KategoriID"] == null ? 0 : dr["KategoriID"]);
                    maka.YazarUserName = dr["YazarUserName"] == null ? "" : dr["YazarUserName"].ToString();
                    maka.MakaleFotoPath = dr["MakaleFotoPath"] == null ? "" : dr["MakaleFotoPath"].ToString();
                    maka.Kategori.KategoriAdi = dr["KategoriName"] == null ? "" : dr["KategoriName"].ToString();
                    maka.Kategori.KategoriID = maka.KategoriID;
                    returnList.Add(maka);
                }
            }
            return returnList;
            
        }

        public int Update(Makaleler parameter)
        {
            throw new NotImplementedException();
        }
    }
}

