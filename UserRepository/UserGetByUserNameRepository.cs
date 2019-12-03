using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserGetByUserNameRepository : Connection
    {
        public string Username { get; set; }

        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {

                cmd.QueryString = "SELECT * FROM [User] WHERE [User].Username='"+Username+"'";
                
                return cmd.ExecuteQuery();
            }
        }

    }
}
