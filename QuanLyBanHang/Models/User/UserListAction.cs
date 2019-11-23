using System;
using Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserRepository;

namespace QuanLyBanHang.Models.User
{
    public class UserListAction
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new UserSearchRepository())
            {
                return cmd.Execute();
            }
        }
    }
}