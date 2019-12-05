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
                cmd.QueryString = "UPDATE [dbo].[Notification] SET [StatusNoti] = 1 WHERE [Notification].SaleId = " + this.Item.SaleId;
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
