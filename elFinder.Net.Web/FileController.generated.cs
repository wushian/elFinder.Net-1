// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Web.Mvc;
using T4MVC;
namespace elFinder.Net.Web.Controllers
{
    public partial class FileController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public FileController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected FileController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SelectFile()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SelectFile);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public FileController Actions { get { return MVC.File; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "File";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "File";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string SelectFile = "SelectFile";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string SelectFile = "SelectFile";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string folder = "folder";
            public readonly string subFolder = "subFolder";
        }
        static readonly ActionParamsClass_SelectFile s_params_SelectFile = new ActionParamsClass_SelectFile();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SelectFile SelectFileParams { get { return s_params_SelectFile; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SelectFile
        {
            public readonly string target = "target";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_FileController : elFinder.Net.Web.Controllers.FileController
    {
        public T4MVC_FileController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string folder, string subFolder);

        public override System.Web.Mvc.ActionResult Index(string folder, string subFolder)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "folder", folder);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "subFolder", subFolder);
            IndexOverride(callInfo, folder, subFolder);
            return callInfo;
        }

        partial void SelectFileOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string target);

        public override System.Web.Mvc.ActionResult SelectFile(string target)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SelectFile);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "target", target);
            SelectFileOverride(callInfo, target);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
