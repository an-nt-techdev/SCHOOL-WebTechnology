using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserUpdateRepository :Connection
    {
        public Domain.User Item { get; set; }
        public bool Execute()
        {
            
            using (var cmd = new Query())
            {
                cmd.QueryString = "UPDATE [dbo].[User] SET [Password]='" + Item.Password + "',[Email] = '" + Item.Email + "',[EmployeeId]='"+Item.EmployeeId+"' WHERE [User].Username='" + Item.Username+"'";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
