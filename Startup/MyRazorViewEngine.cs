//using Microsoft.AspNetCore.Mvc.Razor;
//using Microsoft.Extensions.Options;
//using System.Diagnostics;
//using System.Text.Encodings.Web;

//namespace JonDJones.NetCore.StarterKit.Startup
//{
//    public class MyRazorViewEngine : RazorViewEngine
//    {
//        public MyRazorViewEngine(
//            IRazorPageFactoryProvider pageFactory,
//            IRazorPageActivator pageActivator,
//            HtmlEncoder htmlEncoder,
//            IOptions<RazorViewEngineOptions> optionsAccessor,
//            ILoggerFactory loggerFactory,
//            DiagnosticListener diagnosticListener)
//            : base(pageFactory,
//                  pageActivator,
//                  htmlEncoder,
//                  optionsAccessor,
//                  loggerFactory,
//                  diagnosticListener)
//        {
//        }

//        public override IEnumerable<string> AreaViewLocationFormats
//        {
//            get
//            {
//                var value = new Random().Next(0, 1);
//                var theme = value == 0 ? "Theme1" : "Theme2";

//                return base.AreaViewLocationFormats.Select(f => f.Replace("/Views/", "/Views/" + theme + "/"));
//            }
//        }
//        public override IEnumerable<string> ViewLocationFormats
//        {
//            get
//            {
//                var value = new Random().Next(0, 1);
//                var theme = value == 0 ? "Theme1" : "Theme2";

//                return base.ViewLocationFormats.Select(f => f.Replace("/Views/", "/Views/" + theme + "/"));

//            }
//        }
//    }
//}
