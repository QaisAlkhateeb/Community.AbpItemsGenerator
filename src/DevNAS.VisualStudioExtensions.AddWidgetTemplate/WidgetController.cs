using Microsoft.AspNetCore.Mvc;
using System;
using Volo.Abp.AspNetCore.Mvc;


namespace $rootnamespace$
{
    [Route("$RefreshUrl$")]
    public class $safeitemname$ : AbpController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return ViewComponent("$WidgetName$", new {});
        }
    }
}
