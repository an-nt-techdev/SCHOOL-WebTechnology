using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository;
namespace QuanLyBanHang.Models
{
    public class UserInputAction
    {
        public String Username { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new UserGetByUserNameRepository())
            {
                cmd.Username = this.Username;
                return cmd.Execute();
            }
        }
    }
}