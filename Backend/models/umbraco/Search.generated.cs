//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Cg2021.Models.Umbraco
{
	/// <summary>Search</summary>
	[PublishedModel("search")]
	public partial class Search : PublishedContentModel, ICOmppage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public new const string ModelTypeAlias = "search";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Search, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Search(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Found Results Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		[ImplementPropertyType("foundResultsHeader")]
		public virtual string FoundResultsHeader => this.Value<string>(_publishedValueFallback, "foundResultsHeader");

		///<summary>
		/// No Results Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		[ImplementPropertyType("noResultsHeader")]
		public virtual string NoResultsHeader => this.Value<string>(_publishedValueFallback, "noResultsHeader");

		///<summary>
		/// Show In Menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		[ImplementPropertyType("showInMenu")]
		public virtual bool ShowInMenu => global::Cg2021.Models.Umbraco.COmppage.GetShowInMenu(this, _publishedValueFallback);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Cg2021.Models.Umbraco.COmppage.GetTitle(this, _publishedValueFallback);
	}
}
