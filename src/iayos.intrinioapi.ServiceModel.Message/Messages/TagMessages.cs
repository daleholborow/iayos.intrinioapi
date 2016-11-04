using System;
using System.Runtime.Serialization;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{

	/// <summary>
	/// http://docs.intrinio.com/#standardized-tags-and-labels
	/// </summary>
	[Route("/tags/standardized", HttpMethods.Get)]
	public class GetStandardizedTags : RequestList, IReturn<GetStandardizedTagsResponse>
	{
		/// <summary>
		/// the financial statement requested, options include the income statement, balance sheet, statement 
		/// of cash flows, calculated metrics and ratios, and current data points : 
		/// income_statement | balance_sheet | cash_flow_statement | calculations | current
		/// </summary>
		public FinancialStatement statement { get; set; } = FinancialStatement.IaYoS_Warning_Unset;

		/// <summary>
		/// (optional, must include a ticker if not specified) - the financial statement tag template: industrial | financial
		/// </summary>
		public TagTemplate? template { get; set; }


		/// <summary>
		/// (optional, must include a template if not specified) - the stock market ticker symbol associated 
		/// with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/*
		public int sequence(optional, returns full list without a sequence number) - an integer 0 or greater for calling a single tag from the first entry, based on order
		*/

	}

	public class GetStandardizedTagsResponse : ResponseMetaList<StandardizedTagDto>
	{
	}


	/// <summary>
	/// http://docs.intrinio.com/#as-reported-xbrl-tags-and-labels
	/// </summary>
	[Route("/tags/reported", HttpMethods.Get)]
	public class GetAsReportedXbrlTags : RequestList, IReturn<GetAsReportedXbrlTagsResponse>
	{
		/// <summary>
		///the financial statement requested: income_statement | balance_sheet | cash_flow_statement
		/// </summary>
		public FinancialStatement statement { get; set; } = FinancialStatement.IaYoS_Warning_Unset;

		/// <summary>
		/// (optional, must include a ticker if not specified) - the financial statement tag template: industrial | financial
		/// </summary>
		public TagTemplate? template { get; set; }


		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/*
		public int sequence(optional, returns full list without a sequence number) - an integer 0 or greater for calling a single tag from the first entry, based on order
		*/

		/// <summary>
		/// (optional, otherwise, must specify a date) - the fiscal year associated with the fundamental: YYYY
		/// </summary>
		public int? fiscal_year { get; set; }

		/// <summary>
		/// (optional, otherwise, must specify a date) - the fiscal period associated with the fundamental: FY | Q1 | Q2 | Q3
		/// </summary>
		public FiscalPeriod? fiscal_period { get; set; }

		/// <summary>
		/// (optional, otherwise, must specify a fiscal year and fiscal period) - the first fundamental will be the latest as of this specified date: YYYY-MM-DD
		/// </summary>
		/// <seealso cref="Date_IaYoS"/>
		public string date => Date_IaYoS != null ? Date_IaYoS.GetValueOrDefault().ToString("YYYY-MM-DD") : null;

		/// <summary>
		/// Conveniently set date using actual date object
		/// </summary>
		/// <seealso cref="date"/>
		[IgnoreDataMember]
		public DateTime? Date_IaYoS { get; set; }

		/// <summary>
		/// type (optional, must specify a date or must specify a fiscal year and fiscal period) - the type of periods requested - includes 
		/// fiscal years for annual data, quarters for quarterly data and trailing twelve months for annual data on a quarterly basis: FY | QTR
		/// </summary>
		public FiscalPeriodAsReported? type { get; set; }

	}

	public class GetAsReportedXbrlTagsResponse : ResponseMetaList<AsReportedTagDto> {}

}
