using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class SaleChangeStatusAction
    {
        public int SaleId { get; set; }
        public int Salest { get; set; }
        public bool Execute()
        {
            using(var cmd = new SaleChangeStatusRepository())
            {
                cmd.SaleId = this.SaleId;
                cmd.Salest = this.Salest;
                return cmd.Execute();
            }
        }
    }
}