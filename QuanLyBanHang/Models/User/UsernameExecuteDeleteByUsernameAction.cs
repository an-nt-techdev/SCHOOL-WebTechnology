using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class UsernameExecuteDeleteByUsernameAction
    {
        public string Username{ get; set; }
        public bool Execute()
        {
            using (var cmd = new UserDeleteByUsernameRepository())
            {
                cmd.Username = this.Username;
                return cmd.Execute();
            }
        }
    }
}