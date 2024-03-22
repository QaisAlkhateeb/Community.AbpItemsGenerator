using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;


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
            return View("$ViewPath$");
        }
    }
    
    // Bundles
        public class $WidgetName$ScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("$ViewRootPath$/$WidgetName$.js");
        }
    }
    public class $WidgetName$StyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("$ViewRootPath$/$WidgetName$.css");
        }
    }

}
