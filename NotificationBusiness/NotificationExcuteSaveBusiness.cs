using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Domain;

namespace Business
{
    public class NotificationExcuteSaveBusiness : Connection
    {
        public string EditFlag { get; set; }
        public Notification Item { get; set; }
        public bool Execute()
        {
            if (this.EditFlag == "M")
            {
                using (var cmd = new EmployeeUpdateRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
            else
            {
                using (var cmd = new NotificationInsertRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
        }
    }
}
