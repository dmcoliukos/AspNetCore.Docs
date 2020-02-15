﻿// This uses same routes as MyDemoController, so only one can be defined unless order is set
// Test with 

//#define First
//#define Second
//#define Third
//#define Forth
#define Five

using Microsoft.AspNetCore.Mvc;

namespace WebMvcRouting.Controllers
{
#if First

    #region snippet
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        [Route("/")]
        public IActionResult Index() =>
            ControllerContext.ToActionResult();

        [Route("About")]
        public IActionResult About() =>
            ControllerContext.ToActionResult();
    }
    #endregion
#elif Second
    #region snippet2
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index/{id?}")]
        public IActionResult Index(int ?id) =>
            ControllerContext.ToActionResult(id);

        [Route("Home/About")]
        [Route("Home/About/{id?}")]
        public IActionResult About(int? id) =>
            ControllerContext.ToActionResult(id);
    }
    #endregion
#elif Third
    #region snippet22
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("[controller]/[action]")]
        public IActionResult Index() =>
            ControllerContext.ToActionResult();

        [Route("[controller]/[action]")]
        public IActionResult About() =>
            ControllerContext.ToActionResult();
    }
    #endregion

#elif Forth
    #region snippet24
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("/Home")]
        [Route("~/Home/Index")]
        public IActionResult Index() =>
            ControllerContext.ToActionResult();

        public IActionResult About() =>
            ControllerContext.ToActionResult();
    }
    #endregion
#elif Five
    #region snippet24
    public class HomeController : Controller
    {
        public IActionResult Index() =>
                  ControllerContext.ToActionResult();
    }
    #endregion
#endif
}

