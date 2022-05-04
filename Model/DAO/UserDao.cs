using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model.DAO
{
    public class UserDao
    {
        public UserDao()
        {
        }
        OnlineShopDBContext db = new OnlineShopDBContext();    
        public long Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }
        public bool CheckUserName(string userName)
        {
            return db.Users.Count(x => x.UserName == userName) > 0;
        }
        public bool CheckEmail(string email)
        {
            return db.Users.Count(x => x.Email == email) > 0;
        }
        public User getByID(string username)
        {
            return db.Users.SingleOrDefault(x=>x.UserName == username);
        }

        public bool Login(string Username, string Password)
        {
            var result = db.Users.Count(x=> x.UserName == Username && x.Password == Password);  
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
