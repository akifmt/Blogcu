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
            throw new NotImplementedException();
        }

        public int Update(Makaleler parameter)
        {
            throw new NotImplementedException();
        }
    }
}

