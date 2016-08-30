using System.Linq;

namespace Infrastructure
{
	public static class HtmlHelpers
	{
		static HtmlHelpers()
		{
		}

		private static string GetErrorMessage
			(System.ComponentModel.DataAnnotations.ValidationAttribute validationAttribute)
		{
			if (validationAttribute == null)
			{
				return ("[Error!]");
			}
			else
			{
				return (validationAttribute.ErrorMessage);
			}
		}

		public static System.Web.IHtmlString NgTextBoxFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			string formName,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null,
			int columnCount = 3,
			bool displayPlaceHolder = false,
			bool readOnly = false,
			bool disabled = false)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			string strType = "text";
			bool blnRequired = false;
			string strErrorMessage = string.Empty;

			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			System.Linq.Expressions.MemberExpression oMemberExpression =
				expression.Body as System.Linq.Expressions.MemberExpression;

			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			if (htmlAttributes == null)
			{
				htmlAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			System.Collections.Generic.Dictionary<string, string> oErrors =
				new System.Collections.Generic.Dictionary<string, string>();
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			string strLabelText = string.Empty;

			if (oModelMetadata != null)
			{
				strLabelText =
					oModelMetadata.DisplayName ??
					oModelMetadata.PropertyName;
			}

			if (string.IsNullOrWhiteSpace(strLabelText))
			{
				strLabelText =
					strHtmlFieldName.Split('.').Last();
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			htmlAttributes.Remove("disabled");
			htmlAttributes.Remove("readonly");

			if (disabled)
			{
				htmlAttributes.Add("disabled", "disabled");
			}
			else
			{
				if (readOnly)
				{
					htmlAttributes.Add("readonly", "readonly");
				}
				else
				{
					if (oModelMetadata != null)
					{
						if (oModelMetadata.IsReadOnly)
						{
							htmlAttributes.Add("readonly", "readonly");
						}
						else
						{
							if (displayPlaceHolder)
							{
								htmlAttributes.Add("placeholder", strLabelText);
							}
						}
					}
				}
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			htmlAttributes.Remove("required");

			System.ComponentModel.DataAnnotations.RequiredAttribute oRequiredAttribute =
				oMemberExpression.Member.GetCustomAttributes
				(typeof(System.ComponentModel.DataAnnotations.RequiredAttribute), false)
				.FirstOrDefault() as System.ComponentModel.DataAnnotations.RequiredAttribute;

			if (oRequiredAttribute != null)
			{
				blnRequired = true;

				strErrorMessage =
					GetErrorMessage(oRequiredAttribute);
			}
			else
			{
				if (oModelMetadata != null)
				{
					if (oModelMetadata.IsRequired)
					{
						blnRequired = true;

						// TODO
						strErrorMessage = "{0} is required!";
					}
				}
			}

			if (blnRequired)
			{
				htmlAttributes.Add("required", "required");

				strErrorMessage =
					string.Format(strErrorMessage, strLabelText);

				oErrors.Add("required", strErrorMessage);
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			string strClassNames = "form-control";

			if (htmlAttributes.ContainsKey("class") == false)
			{
				htmlAttributes.Add("class", strClassNames);
			}
			else
			{
				object objClass;

				bool blnResult =
					htmlAttributes.TryGetValue("class", out objClass);

				if ((blnResult) && (objClass != null) && (objClass.ToString() != string.Empty))
				{
					htmlAttributes.Remove("class");

					htmlAttributes.Add
						("class", objClass.ToString() + " " + strClassNames);
				}
			}
			// **************************************************
			// **************************************************
			// **************************************************

			if (oMemberExpression != null)
			{
				// **************************************************
				// **************************************************
				// **************************************************
				htmlAttributes.Remove("ng-minlength");
				htmlAttributes.Remove("data-ng-minlength");

				htmlAttributes.Remove("ng-maxlength");
				htmlAttributes.Remove("data-ng-maxlength");

				int intMinimumLength = 0;
				int intMaximumLength = 0;

				System.ComponentModel.DataAnnotations.MaxLengthAttribute oMaxLengthAttribute =
					oMemberExpression.Member.GetCustomAttributes
					(typeof(System.ComponentModel.DataAnnotations.MaxLengthAttribute), false)
					.FirstOrDefault() as System.ComponentModel.DataAnnotations.MaxLengthAttribute;

				if (oMaxLengthAttribute != null)
				{
					intMaximumLength =
						oMaxLengthAttribute.Length;

					strErrorMessage =
						GetErrorMessage(oMaxLengthAttribute);
				}
				else
				{
					System.ComponentModel.DataAnnotations.StringLengthAttribute oStringLengthAttribute =
						oMemberExpression.Member.GetCustomAttributes
						(typeof(System.ComponentModel.DataAnnotations.StringLengthAttribute), false)
						.FirstOrDefault() as System.ComponentModel.DataAnnotations.StringLengthAttribute;

					if (oStringLengthAttribute != null)
					{
						intMinimumLength =
							oStringLengthAttribute.MinimumLength;

						intMaximumLength =
							oStringLengthAttribute.MaximumLength;

						strErrorMessage =
							GetErrorMessage(oStringLengthAttribute);
					}
				}

				if (intMinimumLength > 0)
				{
					htmlAttributes.Add("data-ng-minlength", intMinimumLength);

					string strErrorMessageTemp =
						string.Format(strErrorMessage, strLabelText, intMinimumLength, intMaximumLength);

					oErrors.Add("minlength", strErrorMessageTemp);
				}

				if (intMaximumLength > 0)
				{
					htmlAttributes.Add("data-ng-maxlength", intMaximumLength);

					string strErrorMessageTemp =
						string.Format(strErrorMessage, strLabelText, intMinimumLength, intMaximumLength);

					oErrors.Add("maxlength", strErrorMessageTemp);
				}

				if (intMaximumLength > 0)
				{
					htmlAttributes.Add("maxlength", intMaximumLength);
				}
				// **************************************************
				// **************************************************
				// **************************************************

				// **************************************************
				// **************************************************
				// **************************************************
				System.ComponentModel.DataAnnotations.RegularExpressionAttribute oRegularExpressionAttribute =
					oMemberExpression.Member.GetCustomAttributes
					(typeof(System.ComponentModel.DataAnnotations.RegularExpressionAttribute), false)
					.FirstOrDefault() as System.ComponentModel.DataAnnotations.RegularExpressionAttribute;

				if (oRegularExpressionAttribute != null)
				{
					htmlAttributes.Add("data-ng-pattern", oRegularExpressionAttribute.Pattern);

					strErrorMessage =
						string.Format(GetErrorMessage(oRegularExpressionAttribute), strLabelText);

					oErrors.Add("pattern", strErrorMessage);
				}
				// **************************************************
				// **************************************************
				// **************************************************

				// **************************************************
				// **************************************************
				// **************************************************
				System.ComponentModel.DataAnnotations.CompareAttribute oCompareAttribute =
					oMemberExpression.Member.GetCustomAttributes
					(typeof(System.ComponentModel.DataAnnotations.CompareAttribute), false)
					.FirstOrDefault() as System.ComponentModel.DataAnnotations.CompareAttribute;

				if (oCompareAttribute != null)
				{
					htmlAttributes.Add("data-ng-compare", oCompareAttribute.OtherProperty);

					var varOtherProperty =
						oModelMetadata.ContainerType.GetProperties()
						.Where(current => current.Name == oCompareAttribute.OtherProperty)
						.FirstOrDefault();

					//if(varOtherProperty != null)
					//{
					//	System.ComponentModel.DataAnnotations.DisplayAttribute oDisplayAttribute =
					//		varOtherProperty.CustomAttributes
					//		.Wher
					//}

					strErrorMessage =
						string.Format(GetErrorMessage(oCompareAttribute),
						strLabelText, oCompareAttribute.OtherPropertyDisplayName);

					oErrors.Add("compare", strErrorMessage);
				}
				// **************************************************
				// **************************************************
				// **************************************************

				// **************************************************
				// **************************************************
				// **************************************************
				System.ComponentModel.DataAnnotations.DataTypeAttribute oDataTypeAttribute =
					oMemberExpression.Member.GetCustomAttributes
					(typeof(System.ComponentModel.DataAnnotations.DataTypeAttribute), false)
					.FirstOrDefault() as System.ComponentModel.DataAnnotations.DataTypeAttribute;

				if (oDataTypeAttribute != null)
				{
					switch (oDataTypeAttribute.DataType)
					{
						case System.ComponentModel.DataAnnotations.DataType.Url:
						{
							strType = "url";

							// TODO
							oErrors.Add("url", "Not a valid url!");
							break;
						}

						case System.ComponentModel.DataAnnotations.DataType.Password:
						{
							strType = "password";
							break;
						}

						case System.ComponentModel.DataAnnotations.DataType.EmailAddress:
						{
							strType = "email";

							// TODO
							oErrors.Add("url", "Not a valid email address!");
							break;
						}

						case System.ComponentModel.DataAnnotations.DataType.MultilineText:
						{
							strType = "textarea";
							break;
						}
					}
				}
				// **************************************************
				// **************************************************
				// **************************************************
			}

			// **************************************************
			// **************************************************
			// **************************************************
			htmlAttributes.Add("id", strHtmlFieldName);
			htmlAttributes.Add("name", strHtmlFieldName);

			if ((htmlAttributes.ContainsKey("ng-model") == false) &&
				(htmlAttributes.ContainsKey("data-ng-model") == false))
			{
				htmlAttributes.Add("data-ng-model", strHtmlFieldName);
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			string strInput = string.Empty;

			if (strType == "textarea")
			{
				strInput = "<textarea {0}></textarea>";
			}
			else
			{
				htmlAttributes.Add("type", strType);

				strInput = "<input {0} />";
			}
			// **************************************************
			// **************************************************
			// **************************************************

			System.Text.StringBuilder oStringBuilder = null;

			// **************************************************
			// **************************************************
			// **************************************************
			oStringBuilder =
				new System.Text.StringBuilder();

			foreach (var varHtmlAttribute in htmlAttributes)
			{
				if (varHtmlAttribute.Value == null)
				{
					oStringBuilder.Append(" " + varHtmlAttribute.Key);
				}
				else
				{
					oStringBuilder.Append(" " + varHtmlAttribute.Key + "='" + varHtmlAttribute.Value + "'");
				}
			}
			// **************************************************
			// **************************************************
			// **************************************************

			strInput =
				string.Format(strInput, oStringBuilder.ToString());

			// **************************************************
			// **************************************************
			// **************************************************
			oStringBuilder =
				new System.Text.StringBuilder();

			foreach (var varError in oErrors)
			{
				if ((string.IsNullOrWhiteSpace(varError.Key) == false) &&
					(string.IsNullOrWhiteSpace(varError.Value) == false))
				{
					oStringBuilder.Append(string.Format("<span class='help-block' data-ng-show='{0}.{1}.$error.{2}'>{3}</span>",
						formName, strHtmlFieldName, varError.Key, varError.Value));
				}
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			System.Web.Mvc.TagBuilder oMainDiv =
				new System.Web.Mvc.TagBuilder("div");

			oMainDiv.AddCssClass("row form-group");
			// **************************************************

			// **************************************************
			System.Web.Mvc.TagBuilder oLabel =
				new System.Web.Mvc.TagBuilder("label");

			oLabel.AddCssClass("control-label");
			oLabel.AddCssClass("col-sm-" + columnCount);
			oLabel.Attributes.Add("for", strHtmlFieldName);
			// **************************************************

			// **************************************************
			if (blnRequired)
			{
				System.Web.Mvc.TagBuilder oRequiredSpan =
					new System.Web.Mvc.TagBuilder("span");

				oRequiredSpan.AddCssClass("required");

				oRequiredSpan.InnerHtml = "*";

				oLabel.InnerHtml = strLabelText + " " + oRequiredSpan.ToString();
			}
			else
			{
				oLabel.InnerHtml = strLabelText;
			}
			// **************************************************

			// **************************************************
			System.Web.Mvc.TagBuilder oErrorsDiv =
				new System.Web.Mvc.TagBuilder("div");

			oErrorsDiv.Attributes.Add("data-ng-show", string.Format("{0}.{1}.$invalid && {0}.{1}.$dirty", formName, strHtmlFieldName));
			oErrorsDiv.InnerHtml = oStringBuilder.ToString();
			// **************************************************

			// **************************************************
			System.Web.Mvc.TagBuilder oInputDiv =
				new System.Web.Mvc.TagBuilder("div");

			oInputDiv.AddCssClass("col-sm-" + (12 - columnCount));

			string strAttributeValue =
				"{" +
				string.Format("'has-error': {0}.{1}.$invalid && {0}.{1}.$dirty",
				formName, strHtmlFieldName) +
				"}";

			oInputDiv.Attributes.Add("data-ng-class", strAttributeValue);

			oInputDiv.InnerHtml = strInput + oErrorsDiv.ToString();
			// **************************************************

			oMainDiv.InnerHtml = oLabel.ToString() + oInputDiv.ToString();

			//<div class='row form-group'>
			//	<label for="Password" class="control-label col-sm-3">
			//		Password
			//		<span class="required">*</span>
			//	</label>
			//	<div class='col-sm-9' data-ng-class="{'has-error': mainForm.Password.$invalid && mainForm.Password.$dirty}">
			//		<input type="password" id="Password" name="Password" class="form-control" data-ng-model="Password" placeholder="Password" required />

			//		<div data-ng-show="mainForm.Password.$invalid && mainForm.Password.$dirty">
			//			<span class="help-block" data-ng-show="mainForm.Password.$error.required">Required!</span>
			//		</div>
			//	</div>
			//</div>

			return (html.Raw(oMainDiv.ToString()));
		}
	}
}
