using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class NotificationChangeStatusAction
    {
        public int NotificationId { get; set; }
        public int NotificationStatus { get; set; }
        public bool Execute()
        {
            using (var cmd = new NotificationChangeStatusRepository())
            {
                cmd.NotificationId = this.NotificationId;
                cmd.NotificationStatus = this.NotificationStatus;
                return cmd.Execute();
            }
        }
    }
}