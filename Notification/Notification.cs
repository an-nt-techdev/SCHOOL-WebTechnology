using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Domain
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int SaleId { get; set; }
        public int Status { get; set; }
    }
}
