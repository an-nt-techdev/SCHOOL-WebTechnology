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
                cmd.QueryString = "SELECT [dbo][Notification].*, [dbo][Sale].* FROM [dbo][Notification] LEFT JOIN [dbo][Sale] on [dbo][Sale].SaleId = [dbo][Notification].SaleId";
                return cmd.ExecuteQuery();
            }
        }
    }
}
