using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDataBase
{
    public abstract class Connection : IDisposable
    {
        protected string ConnectionString { get; }
        public Connection()
        {
            this.ConnectionString = @"Data Source=(Localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLBH.mdf;Integrated Security=True";
        }
        public void Dispose()
        {
        }
    }
}
