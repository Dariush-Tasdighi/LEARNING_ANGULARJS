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
	public partial class IwpcoController
	{
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected IwpcoController(Dummy d) { }

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
		public virtual System.Web.Mvc.JsonResult GetPeople()
		{
			return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPeople);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.JsonResult CreatePerson()
		{
			return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.CreatePerson);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public IwpcoController Actions { get { return MVC.Iwpco; } }
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Area = "";
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Name = "Iwpco";
		[GeneratedCode("T4MVC", "2.0")]
		public const string NameConst = "Iwpco";
		[GeneratedCode("T4MVC", "2.0")]
		static readonly ActionNamesClass s_actions = new ActionNamesClass();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionNamesClass ActionNames { get { return s_actions; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNamesClass
		{
			public readonly string Index = "Index";
			public readonly string GetPerson = "GetPerson";
			public readonly string List = "List";
			public readonly string GetPeople = "GetPeople";
			public readonly string CreatePerson = "CreatePerson";
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNameConstants
		{
			public const string Index = "Index";
			public const string GetPerson = "GetPerson";
			public const string List = "List";
			public const string GetPeople = "GetPeople";
			public const string CreatePerson = "CreatePerson";
		}


		static readonly ActionParamsClass_GetPeople s_params_GetPeople = new ActionParamsClass_GetPeople();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_GetPeople GetPeopleParams { get { return s_params_GetPeople; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_GetPeople
		{
			public readonly string viewModel = "viewModel";
		}
		static readonly ActionParamsClass_CreatePerson s_params_CreatePerson = new ActionParamsClass_CreatePerson();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_CreatePerson CreatePersonParams { get { return s_params_CreatePerson; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_CreatePerson
		{
			public readonly string person = "person";
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
                public readonly string Index = "Index";
                public readonly string Index_Pre_1 = "Index_Pre_1";
                public readonly string Index_Pre_2 = "Index_Pre_2";
                public readonly string List = "List";
                public readonly string List_Pre_1 = "List_Pre_1";
                public readonly string List_Pre_2 = "List_Pre_2";
            }
            public readonly string Index = "~/Views/Iwpco/Index.cshtml";
            public readonly string Index_Pre_1 = "~/Views/Iwpco/Index_Pre_1.cshtml";
            public readonly string Index_Pre_2 = "~/Views/Iwpco/Index_Pre_2.cshtml";
            public readonly string List = "~/Views/Iwpco/List.cshtml";
            public readonly string List_Pre_1 = "~/Views/Iwpco/List_Pre_1.cshtml";
            public readonly string List_Pre_2 = "~/Views/Iwpco/List_Pre_2.cshtml";
		}
	}

	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public partial class T4MVC_IwpcoController : LEARNING_ANGULAR_JS.Controllers.IwpcoController
	{
		public T4MVC_IwpcoController() : base(Dummy.Instance) { }

		[NonAction]
		partial void IndexOverride(T4MVC_System_Web_Mvc_ViewResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ViewResult Index()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Index);
			IndexOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void GetPersonOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

		[NonAction]
		public override System.Web.Mvc.JsonResult GetPerson()
		{
			var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPerson);
			GetPersonOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void ListOverride(T4MVC_System_Web_Mvc_ViewResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ViewResult List()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.List);
			ListOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void GetPeopleOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, ViewModels.Iwpco.GetPeopleViewModel viewModel);

		[NonAction]
		public override System.Web.Mvc.JsonResult GetPeople(ViewModels.Iwpco.GetPeopleViewModel viewModel)
		{
			var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPeople);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
			GetPeopleOverride(callInfo, viewModel);
			return callInfo;
		}

		[NonAction]
		partial void CreatePersonOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, Models.Person person);

		[NonAction]
		public override System.Web.Mvc.JsonResult CreatePerson(Models.Person person)
		{
			var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.CreatePerson);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "person", person);
			CreatePersonOverride(callInfo, person);
			return callInfo;
		}

	}
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114