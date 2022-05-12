using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ClientDao
    {
        OnlineShopDBContext db = null;
        public ClientDao()
        {
            db = new OnlineShopDBContext(); 
        }

        public IEnumerable<Client> ListAllPaging(string searchString, int page, int pageSize)
        {
            IOrderedQueryable<Client> query = db.Clients;
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(x => x.Name.Contains(searchString) || x.Phone.Contains(searchString))
                    .OrderBy(p => p.Name);
            }
            return query.OrderBy(p => p.Name).ToPagedList(page, pageSize);
        }

        public long Insert(Client cl)
        {
            db.Clients.Add(cl);
            db.SaveChanges();
            return cl.id;
        }
    }
}
