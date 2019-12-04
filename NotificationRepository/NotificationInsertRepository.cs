using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NotificationInsertRepository : Connection
    {
        public Notification Item { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "INSERT INTO [dbo].[Notification]([NotificationId], [SaleId], [Status]) VALUES ((SELECT isnull(MAX(NotificationId),0) + 1 from [Notification])," + Item.SaleId + "," + Item.Status + " ) ";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
