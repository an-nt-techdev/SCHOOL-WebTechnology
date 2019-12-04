using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NotificationUpdateRepository : Connection
    {
        public Notification Item { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "UPDATE [dbo].[Notificaiton] SET [Status] = '" + Item.Status + "' WHERE [Notification].NotificationId = '" + Item.NotificationId + "'";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
