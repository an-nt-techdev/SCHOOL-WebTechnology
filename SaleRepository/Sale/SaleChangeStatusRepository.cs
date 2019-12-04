using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleChangeStatusRepository : Connection
    {
        public int SaleId { get; set; }
        public int Salest { get; set; }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                if (this.Salest == 2)
                {
                    cmd.QueryString = "UPDATE [dbo].[Sale] SET [Status] = 2 WHERE [Sale].SaleId=" + this.SaleId;
                }
                else
                {
                    cmd.QueryString = "UPDATE [dbo].[Sale] SET [Status] = 1 WHERE [Sale].SaleId=" + this.SaleId;
                }
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
