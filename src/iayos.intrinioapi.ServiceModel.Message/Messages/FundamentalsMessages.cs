using System;
using System.Runtime.Serialization;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{

	/// <summary>
	/// http://docs.intrinio.com/#standardized-fundamentals
	/// </summary>
	[Route("/fundamentals/standardized", HttpMethods.Get)]
	public class GetStandardizedFundamentals : RequestList, IReturn<GetStandardizedFundamentalsResponse> 
	{

		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// the financial statement requested, options include the income statement, balance sheet, statement of cash 
		/// flows and calculated metrics and ratios: income_statement | balance_sheet | cash_flow_statement | calculations
		/// </summary>
		public FinancialStatement statement { get; set; } = FinancialStatement.IaYoS_Warning_Unset;

		/// <summary>
		/// (optional, returns all available fundamentals) - the type of periods requested - includes fiscal years for 
		/// annual data, quarters for quarterly data and trailing twelve months for annual data on a quarterly basis: FY | QTR | TTM | YTD
		/// </summary>
		public FiscalPeriod? type { get; set; }

		/*
		 * sequence (required, only in Excel add-in function) - an integer 0 or greater for calling a single fundamental from the first entry, most recent first: 0..last available
		 */

		/*
		 * item (required, only in Excel add-in function) - the return value for the fundamental: fiscal_year | fiscal_period | end_date | start_date
		 */

		/// <summary>
		/// (optional, default is today) - the first fundamental will be the latest as of this specified date: yyyy-MM-dd
		/// </summary>
		/// <seealso cref="Date_IaYoS"/>
		public string date => Date_IaYoS != null ? Date_IaYoS.GetValueOrDefault().ToString("yyyy-MM-dd") : null;

		/// <summary>
		/// Conveniently set date using actual date object
		/// </summary>
		/// <seealso cref="date"/>
		[IgnoreDataMember]
		public DateTime? Date_IaYoS { get; set; }

	}

	public class GetStandardizedFundamentalsResponse : ResponseMetaList<FundamentalDto>
	{
	}



	/// <summary>
	/// http://docs.intrinio.com/#as-reported-fundamentals
	/// </summary>
	[Route("/fundamentals/reported", HttpMethods.Get)]
	public class GetAsReportedFundamentals : RequestList, IReturn<GetAsReportedFundamentalsResponse>
	{

		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// the financial statement requested, options include the income statement, balance sheet, statement of 
		/// cash flows and calculated metrics and ratios: income_statement | balance_sheet | cash_flow_statement | calculations
		/// </summary>
		public FinancialStatement statement { get; set; } = FinancialStatement.IaYoS_Warning_Unset;

		/*
		 * sequence (optional, must specify a date or must specify a fiscal year and fiscal period) - the sequence of the requested fundamental 
		 * (i.e. 0 is the first available fundamental associated with the fiscal period type: 0...last available
		 */

		/// <summary>
		///  (optional, returns all available fundamentals) - the type of periods requested - includes fiscal years for annual data, quarters for quarterly data: FY | QTR
		/// </summary>
		public FiscalPeriod? type { get; set; }


		/// <summary>
		/// (optional, default=today) - the first fundamental will be the latest as of this specified date: yyyy-MM-dd
		/// </summary>
		/// <seealso cref="Date_IaYoS"/>
		public string date => Date_IaYoS != null ? Date_IaYoS.GetValueOrDefault().ToString("yyyy-MM-dd") : null;

		/// <summary>
		/// Conveniently set date using actual date object
		/// </summary>
		/// <seealso cref="date"/>
		[IgnoreDataMember]
		public DateTime? Date_IaYoS { get; set; }

	}

	public class GetAsReportedFundamentalsResponse : ResponseMetaList<FundamentalDto>
	{
	}
}
 