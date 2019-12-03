using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserDeleteByUsernameRepository:Connection
    {
        public string Username { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "DELETE FROM [User] WHERE [User].Username='"+Username+"'";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
