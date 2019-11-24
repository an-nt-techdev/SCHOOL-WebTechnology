using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public class UserInsertRepository : Connection
    {
        public Domain.User Item { get; set; }
        public bool Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "INSERT INTO [dbo].[User]([Username] ,[Password] ,[Email] ,[LastLogin] ,[Token] ,[EmployeeId]) VALUES (N'" + Item.Username + "',N'" + Item.Password + "',N'" + Item.Email + "','','','" + Item.EmployeeId + "')";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
