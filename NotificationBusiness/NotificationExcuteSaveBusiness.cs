using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDataBase;
using Domain;
using Repository;
namespace Business
{
    public class NotificationExcuteSaveBusiness : Connection
    {
        public string EditFlag { get; set; }
        public Product Item { get; set; }
    }
}
