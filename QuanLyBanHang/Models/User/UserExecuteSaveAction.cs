using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserBussiness;
using System.Security.Cryptography;
using System.Text;
namespace QuanLyBanHang.Models
{
    public class UserExecuteSaveAction
    {
        public string EditFlag { get; set; }
        public Domain.User UserList { get; set; }
        private string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public bool Execute()
        {
            using (var cmd = new UserExecuteSaveBussiness())
            {
                cmd.EditFlag = this.EditFlag;
                cmd.Item = this.UserList;
                cmd.Item.Password = CreateMD5(this.UserList.Password.ToLower());
                return cmd.Execute();
            }
        }

    }
}