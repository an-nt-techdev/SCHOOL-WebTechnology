using ConnectDataBase;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class NotificationExecuteSaveBusiness : Connection
    {
        public string EditFlag { get; set; }
        public Notification Item { get; set; }
        public bool Execute()
        {
            if (this.EditFlag == "M")
            {
                using(var cmd = new NotificationUpdateRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
            else
            {
                using(var cmd = new NotificationInsertRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
        }
    }
}
