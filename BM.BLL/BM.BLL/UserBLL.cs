using BM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.BLL
{
    public class UserBLL
    {
        public static UserBLL Instance = new UserBLL();

        public bool Login(AHUsers user, ref string msg)
        {
            return true;
        }

        public bool RegisterShop(AHAgent agent, ref string msg)
        {
            return true;
        }

        public void GetPhoneCode()
        {
        }
    }
}
