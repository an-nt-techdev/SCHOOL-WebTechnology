using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Controllers
{
    public class UserController : CommandBaseController
    {
        // GET: User
        public ActionResult UserList(UserListAction CommandAction, bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
        public ActionResult UserInput(UserInputAction CommandAction)
        {
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
        [HttpPost]
        public ActionResult UserExecuteSave(UserExecuteSaveAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute()));

            }
            catch (Exception ex)
            {

                return JsonExpando(Success(false, ex.Message));

            }
        }
        [HttpPost]
        public ActionResult UserExecuteDeleteByUsername(UsernameExecuteDeleteByUsernameAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute(), "Xóa thành công!"));

            }
            catch (Exception ex)
            {

                return JsonExpando(Success(false, ex.Message));

            }
        }
    }
}