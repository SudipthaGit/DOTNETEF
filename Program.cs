using EFDB.DataBase;
using EFDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FetchUserData();
            
        }

        static List<UserEntity> FetchUserData()
        {
            try
            {
                //var DB = new CSDbContext();
                using (var DB = new CSDbContext()) 
                {
                    var res = (from i in DB.T_user_details
                               where i.Is_Active
                               select new UserEntity
                               {
                                   user_name = i.u_name,
                                   user_dob = i.u_dob,
                                   user_city = i.u_city,
                               }).ToList();
                    return res;
                }
            }
            catch (Exception e) 
            {
            }
            return null;
        }

        static void FetchOrderDetails()
        {

        }

    }
}
