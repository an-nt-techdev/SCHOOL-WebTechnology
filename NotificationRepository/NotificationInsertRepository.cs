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
                cmd.QueryString = "INSERT INTO [dbo].[Notification]([NotificationId], [SaleId], [StatusNoti]) VALUES ((SELECT isnull(MAX(NotificationId),0) + 1 from [Notification]), (SELECT isnull(MAX(SaleId),0) from [Sale]), 1) ";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
