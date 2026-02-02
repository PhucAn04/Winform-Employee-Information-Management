using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BOPHAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tp_BOPHAN getItem(int id) 
        {
            return db.tp_BOPHAN.FirstOrDefault(x => x.IDBP == id); 
        }

        public List<tp_BOPHAN> getList() 
        {
            return db.tp_BOPHAN.ToList(); 
        }

        public tp_BOPHAN Add(tp_BOPHAN tg) 
        {
            try
            {
                db.tp_BOPHAN.Add(tg); 
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tp_BOPHAN Update(tp_BOPHAN dt)
        {
            try
            {
                var _dt = db.tp_BOPHAN.FirstOrDefault(x => x.IDBP == dt.IDBP);
                _dt.TENBP = dt.TENBP;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _tg = db.tp_BOPHAN.FirstOrDefault(x => x.IDBP == id);
                db.tp_BOPHAN.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}
