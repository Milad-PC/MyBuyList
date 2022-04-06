using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPartnerRepository:IDisposable
    {
        IEnumerable<Partner> GetAllPartners();
        IEnumerable<Partner> GetPartnersByList();

        Partner GetPartnerByID(int partnerId); 

        bool Insert(Partner partner);
        bool Update(Partner partner);
        bool Delete(Partner partner);
        bool Delete(int partnerId);

        void Save();



    }
}
