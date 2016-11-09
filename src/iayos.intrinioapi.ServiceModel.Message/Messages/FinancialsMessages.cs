using System;
using System.Runtime.Serialization;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{

	/// <summary>
	/// http://docs.intrinio.com/#standardized-financials
	/// </summary>
	[Route("/financials/standardized", HttpMethods.Get)]
	public class GetStandardizedFinancials : RequestList, IReturn<GetStandardizedFinancialsResponse> 
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


		/// <summary>
		/// (optional, otherwise, must specify a date) - the fiscal year associated with the fundamental: YYYY
		/// </summary>
		public int? fiscal_year { get; set; }

		/// <summary>
		/// (optional, otherwise, must specify a date) - the fiscal period associated with the fundamental: FY | Q1 | Q2 | Q3 | Q4 | Q1TTM | Q2TTM | Q3TTM | Q2YTD | Q3YTD
		/// </summary>
		public FiscalPeriod? fiscal_period { get; set; }

		/*
		 * sequence (optional, must specify a date or must specify a fiscal year and fiscal period) - the sequence of the requested fundamental 
		 * (i.e. 0 is the first available fundamental associated with the fiscal period type: 0...last available
		 */

		/// <summary>
		/// (optional, must specify a date or must specify a fiscal year and fiscal period) - the type of periods requested - includes 
		/// fiscal years for annual data, quarters for quarterly data and trailing twelve months for annual data on a quarterly basis: FY | QTR | TTM | YTD
		/// </summary>
		public HistoricalDataType? type { get; set; }


		/// <summary>
		/// (optional, otherwise, must specify a fiscal year and fiscal period) - the first fundamental will be 
		/// the latest as of this specified date: YYYY-MM-DD
		/// </summary>
		/// <seealso cref="Date_IaYoS"/>
		public string date => Date_IaYoS != null ? Date_IaYoS.GetValueOrDefault().ToString("YYYY-MM-DD") : null;

		/// <summary>
		/// Conveniently set date using actual date object
		/// </summary>
		/// <seealso cref="date"/>
		[IgnoreDataMember]
		public DateTime? Date_IaYoS { get; set; }

		/*
		 * tag (required, only in Excel & Sheets add-in function) - the specified standardized tag: STANDARDIZED INDUSTRIAL TAGS | STANDARDIZED FINANCIAL TAGS
		 */

		/*
		 * rounding (optional, only in Excel & Sheets add-ins function) – round the returned value (actuals, thousands, millions, billions): A | K | M | B
		 */

	}

	public class GetStandardizedFinancialsResponse : ResponseMetaList<StandardizedFinancialDto>
	{
	}

	
	/// <summary>
	/// http://docs.intrinio.com/#as-reported-financials
	/// </summary>
	[Route("/financials/reported", HttpMethods.Get)]
	public class GetAsReportedFinancials : RequestList, IReturn<GetAsReportedFinancialsResponse>
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


		/// <summary>
		/// (optional, otherwise, must specify a date) - the fiscal year associated with the fundamental: YYYY
		/// </summary>
		public int? fiscal_year { get; set; }

		/// <summary>
		/// (optional, otherwise, must specify a date) - the fiscal period associated with the fundamental: FY | Q1 | Q2 | Q3 | Q4 | Q1TTM | Q2TTM | Q3TTM | Q2YTD | Q3YTD
		/// </summary>
		public FiscalPeriod? fiscal_period { get; set; }

		/*
		 * sequence (optional, must specify a date or must specify a fiscal year and fiscal period) - the sequence of the requested fundamental 
		 * (i.e. 0 is the first available fundamental associated with the fiscal period type: 0...last available
		 */

		/// <summary>
		/// (optional, must specify a date or must specify a fiscal year and fiscal period) - the type of periods requested - includes 
		/// fiscal years for annual data, quarters for quarterly data and trailing twelve months for annual data on a quarterly basis: FY | QTR | TTM | YTD
		/// </summary>
		public HistoricalDataType? type { get; set; }


		/// <summary>
		/// (optional, otherwise, must specify a fiscal year and fiscal period) - the first fundamental will be 
		/// the latest as of this specified date: YYYY-MM-DD
		/// </summary>
		/// <seealso cref="Date_IaYoS"/>
		public string date => Date_IaYoS != null ? Date_IaYoS.GetValueOrDefault().ToString("YYYY-MM-DD") : null;

		/// <summary>
		/// Conveniently set date using actual date object
		/// </summary>
		/// <seealso cref="date"/>
		[IgnoreDataMember]
		public DateTime? Date_IaYoS { get; set; }

		/*
		 * xbrl_tag (required, only in Excel & Sheets add-in function) - the specified AsReported tag: AsReported INDUSTRIAL TAGS | AsReported FINANCIAL TAGS
		 */

		/*
		 * domain_tag (optional, only available in the Excel add-in function) - the specified domain XBRL tag, associated with 
		 * certain data points on the financial statements that have a dimension associated with the data point
		 */

	}

	public class GetAsReportedFinancialsResponse : ResponseMetaList<AsReportedFinancialDto>
	{
	}

	
}
