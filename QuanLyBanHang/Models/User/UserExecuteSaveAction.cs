using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserBussiness;

namespace QuanLyBanHang.Models
{
    public class UserExecuteSaveAction
    {
        public string EditFlag { get; set; }
        public Domain.User UserList { get; set; }
        public bool Execute()
        {
            using (var cmd = new UserExecuteSaveBussiness())
            {
                cmd.EditFlag = this.EditFlag;
                cmd.Item = this.UserList;
                return cmd.Execute();
            }
        }
    }
}