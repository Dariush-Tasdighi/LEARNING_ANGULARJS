// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class LearningDirectiveController
	{
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected LearningDirectiveController(Dummy d) { }

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToAction(ActionResult result)
		{
			var callInfo = result.GetT4MVCResult();
			return RedirectToRoute(callInfo.RouteValueDictionary);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
		{
			return RedirectToAction(taskResult.Result);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
		{
			var callInfo = result.GetT4MVCResult();
			return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
		{
			return RedirectToActionPermanent(taskResult.Result);
		}

		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.JsonResult GetCities()
		{
			return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetCities);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public LearningDirectiveController Actions { get { return MVC.LearningDirective; } }
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Area = "";
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Name = "LearningDirective";
		[GeneratedCode("T4MVC", "2.0")]
		public const string NameConst = "LearningDirective";
		[GeneratedCode("T4MVC", "2.0")]
		static readonly ActionNamesClass s_actions = new ActionNamesClass();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionNamesClass ActionNames { get { return s_actions; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNamesClass
		{
			public readonly string Learn01 = "Learn01";
			public readonly string GetStates = "GetStates";
			public readonly string GetCities = "GetCities";
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNameConstants
		{
			public const string Learn01 = "Learn01";
			public const string GetStates = "GetStates";
			public const string GetCities = "GetCities";
		}


		static readonly ActionParamsClass_GetCities s_params_GetCities = new ActionParamsClass_GetCities();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_GetCities GetCitiesParams { get { return s_params_GetCities; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_GetCities
		{
			public readonly string stateId = "stateId";
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
                public readonly string Learn01 = "Learn01";
            }
            public readonly string Learn01 = "~/Views/LearningDirective/Learn01.cshtml";
		}
	}

	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public partial class T4MVC_LearningDirectiveController : LEARNING_ANGULAR_JS.Controllers.LearningDirectiveController
	{
		public T4MVC_LearningDirectiveController() : base(Dummy.Instance) { }

		[NonAction]
		partial void Learn01Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ViewResult Learn01()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn01);
			Learn01Override(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void GetStatesOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

		[NonAction]
		public override System.Web.Mvc.JsonResult GetStates()
		{
			var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetStates);
			GetStatesOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void GetCitiesOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, int stateId);

		[NonAction]
		public override System.Web.Mvc.JsonResult GetCities(int stateId)
		{
			var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetCities);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "stateId", stateId);
			GetCitiesOverride(callInfo, stateId);
			return callInfo;
		}

	}
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
