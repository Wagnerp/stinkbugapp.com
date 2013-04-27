using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stinkbugapp.com.Controllers
{
    public class ErrorsController : Controller
    {
        public ActionResult Index(int statusCode, Exception exception)
        {
            Response.StatusCode = statusCode;
            return View( statusCode.ToString() );
        }
    }
}
