using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class NotificationListAction
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new NotificationSearchRepository())
            {
                return cmd.Execute();
            }
        }
    }
}