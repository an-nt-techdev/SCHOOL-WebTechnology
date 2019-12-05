using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NotificationChangeStatusRepository : Connection
    {
        public int NotificationId { get; set; }
        public int NotificationStatus { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                if (this.NotificationStatus == 1)
                {
                    cmd.QueryString = "UPDATE [dbo].[Notification] SET [StatusNoti] = 0 WHERE [Notification].NotificationId = " + this.NotificationId;
                }
                else
                {
                    cmd.QueryString = "UPDATE [dbo].[Notification] SET [StatusNoti] = 1 WHERE [Notification].NotificationId = " + this.NotificationId;
                }
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
