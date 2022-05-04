using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Common
{
    [Serializable]
    public class UserLogin
    {       
        public long ID { get; set; }
        public string UserName { get; set; }
    }
}