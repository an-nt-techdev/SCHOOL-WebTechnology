using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRepository
{
    public class UserSearchRepository: Connection
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT * FROM [User]";
                return cmd.ExecuteQuery();
            }
        }
    }
}
