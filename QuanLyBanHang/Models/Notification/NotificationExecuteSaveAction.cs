using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class NotificationExecuteSaveAction
    {
        public Notification Item { get; set; }
        public string EditFlag { get; set; }
        public bool Execute()
        {
            using (var cmd = new NotificationExecuteSaveBusiness())
            {
                cmd.Item = this.Item;
                cmd.EditFlag = this.EditFlag;
                return cmd.Execute();
            }
        }
    }
}