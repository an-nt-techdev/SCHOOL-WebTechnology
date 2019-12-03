using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDataBase;
using Domain;
using Repository;

namespace UserBussiness
{
    public class UserExecuteSaveBussiness:Connection
    {
        public string EditFlag { get; set; }
        public Domain.User Item { get; set; }
        public bool Execute()
        {
            if (EditFlag == "M") // modifi - sua 
            {
                using (var cmd = new UserUpdateRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
            else
            {
                using (var cmd = new UserInsertRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
        }
    }
}
