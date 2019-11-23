using QuanLyBanHang.Models;
using QuanLyBanHang.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserList(UserListAction CommandAction, bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
    }
}