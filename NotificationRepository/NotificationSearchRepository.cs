using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NotificationSearchRepository : Connection
    {
        public List<dynamic> Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "SELECT [Notification].[NotificationId], [Notification].[StatusNoti], [Sale].* FROM [Notification] LEFT JOIN [Sale] on [Sale].SaleId = [Notification].SaleId";
                return cmd.ExecuteQuery();
            }
        }
    }
}
