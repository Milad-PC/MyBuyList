using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PartnerRepository : IPartnerRepository
    {
        MyContext db;
        public PartnerRepository(MyContext mydb)
        {
            db = mydb;
        }
        public bool Delete(Partner partner)
        {
            try
            {
                db.Entry(partner).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch { return false; }
        }

        public bool Delete(int partnerId)
        {
            return Delete(GetPartnerByID(partnerId));
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Partner> GetAllPartners()
        {
            return db.Partners;
        }

        public Partner GetPartnerByID(int partnerId)
        {
            return db.Partners.Find(partnerId);
        }

        public IEnumerable<Partner> GetPartnersByList(int listId)
        {
            return db.Partners.Where(u=>u.ListID == listId);
        }

        public bool Insert(Partner partner)
        {
            try
            {
                db.Partners.Add(partner);
                return true;
            }catch { return false; }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Update(Partner partner)
        {
            try
            {
                db.Entry(partner).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch { return false; }
        }
    }
}
