using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FutShowMe.WebAPI.Controllers
{
    public class BaseController : Controller
    {
        // ---------------------------------------------------------------------------------------------
        // Class variables
        // ---------------------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------------------
        // Public methods
        // ---------------------------------------------------------------------------------------------

        #region CONSTRUCTOR >> BaseController
        public BaseController()
        {

        }
        #endregion


        // ---------------------------------------------------------------------------------------------
        // Private methods
        // ---------------------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------------------
        // Protected methods
        // ---------------------------------------------------------------------------------------------

        #region buildJsonResult
        public JsonResult buildJsonResult(object data)
        {
            return new JsonResult(
                data
                );
        }
        #endregion

    }
}
