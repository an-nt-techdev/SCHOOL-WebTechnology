using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class NotificationListAction
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new NotificationSearchRepository())
            {
                return cmd.Execute();
            }
        }

        //public int Counting()
        //{
        //    List<dynamic> tmp = Execute();
            
        //    int count = 0;
        //    for (int i = 0; i <= tmp.Count; i++ )
        //    {
        //        if (tmp[i].)
        //        {

        //        }
        //    }
        //    return count;
        //}
    }
}