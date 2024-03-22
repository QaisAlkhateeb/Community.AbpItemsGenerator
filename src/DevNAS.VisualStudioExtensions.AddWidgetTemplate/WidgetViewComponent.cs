using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.ChartJs;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;
using Volo.Abp.Modularity;


namespace $rootnamespace$
{
    [Widget(RefreshUrl = "$RefreshUrl$",
        ScriptTypes = new[] { typeof($WidgetName$ScriptContributor) },
        StyleTypes = new[] { typeof( $WidgetName$StyleContributor) }
    )]
    [ViewComponent(Name = "$WidgetName$")]
    public class $safeitemname$ : AbpViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("$ViewPath$/$WidgetName$ViewComponent.cshtml");
        }
    }
    
    // Bundles
        public class $WidgetName$ScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("$ViewPath$/$WidgetName$.js");
        }
    }
    public class $WidgetName$StyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("$ViewPath$/$WidgetName$.css");
        }
    }

}
