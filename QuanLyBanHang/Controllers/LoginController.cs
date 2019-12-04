using ConnectDataBase;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;
using System.Windows.Forms;

namespace QuanLyBanHang.Controllers
{
    public class LoginController : CommandBaseController
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckLogin(LoginExecuteSearchAction CommandAction)
        {
            try
            {
                List<dynamic> result = CommandAction.Execute();
                if (result.Count() != 0)
                {
                    this.Session["User"] = CommandAction.Username;
                    this.Session["EmployeeName"] = result[0].EmployeeName;
                    this.Session["EmployeeIdd"] = result[0].EmployeeId;
                    this.Session["LastLogin"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    if (this.Session["User"].Equals("admin"))
                    {
                        this.Session["Photo"] = "/img/demo/avatar/admin.png";
                    }
                    else
                    {
                        this.Session["Photo"] = "/img/demo/avatar/avatar2.jpg";
                    }
                    
                
                    this.Session.Timeout = 10;
                    using (var cmd = new LoginUpdateRepository())
                    {
                        result[0].LastLogin = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                        result[0].Token = this.Session.SessionID;
                        cmd.Item = result[0];
                        var res = cmd.Execute();
                        return JsonExpando(Success(res));

                    }
                }
                return JsonExpando(Success(false,"Tên tài khoản hoặc mật khẩu không đúng!"));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false, ex.Message));
            }
        }
        [HttpPost]
        public ActionResult Logout()
        {
            try
            {
                this.Session.Clear();
                this.Session.Abandon();
                return JsonExpando(Success(true));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false,ex.Message));

            }
        }

        [HttpPost]
        public ActionResult OAuth(OAuthAction data)
        {
            try
            {
                var result = data.Execute();
                if (result.Count() == 1)    
                {
                    using (var cmd = new OAuthUpdateByIdRepository())
                    {
                        data.data.LastLogin = DateTime.Now;
                        cmd.data = data.data;
                        this.Session["Email"] = data.data.Email;
                        this.Session["LastLogin"] = data.data.LastLogin;
                        this.Session["Token"] = data.data.Token;
                        this.Session["Photo"] = data.data.Photo;
                        this.Session.Timeout = 10;
                        return JsonExpando(Success(cmd.Execute()));
                    }
                }
                return JsonExpando(Success(false, "Không tìm thấy Email: " + data.data.Email));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false, ex.Message));
            }
        }
    }
}