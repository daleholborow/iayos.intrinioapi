using System;
using System.Collections.Generic;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;


namespace iayos.intrinioapi.servicemodel.message.Messages
{

	[Route("/historical_data", HttpMethods.Get)]
	public class SearchHistoricalData : Request, IReturn<SearchHistoricalDataResponse>
	{

		/// <summary>
		/// the stock market ticker symbol associated with the company’s common stock or index. If the company is 
		/// foreign, use the stock exchange code, followed by a colon, then the ticker. You may request up to 150 
		/// tickers at once by separating them by a coma (each ticker and item combination requested will count
		///  as 1 query of the API): TICKER SYMBOL | INDEX SYMBOL
		/// </summary>
		/// <seealso cref="Identifier_IaYoS" />
		public string identifier => string.Join(",", Identifier_IaYoS);

		/// <summary>
		/// Use this collection to populate the identifers
		/// </summary>
		/// <seealso cref="identifier"/>
		public List<string> Identifier_IaYoS { get; set; } = new ArrayOfString();

		/// <summary>
		/// the specified standardized tag requested. INTRINIO TAGS
		/// </summary>
		public DataPointTag item { get; set; } = DataPointTag.IaYoS_Warning_Unset;

		/// <summary>
		/// (required, only in Excel add-in function) - an integer 0 or greater for calling a single historical data point 
		/// from the first entry, based on sort order: 0..last available
		/// </summary>
		//public string sequence { get; set; }

		/// <summary>
		/// Set using 
		/// (optional) - the first date in which historical stock prices are delivered - historical daily prices go back 
		/// to 1996 for most companies, but some go back further to the 1970s or to the date of the IPO: YYYY-MM-DD
		/// </summary>
		/// <seealso cref="StartDate_IaYoS"/>
		public string start_date => StartDate_IaYoS != null ? StartDate_IaYoS.GetValueOrDefault().ToString("YYYY-MM-DD") : null;

		/// <summary>
		/// Conveniently set start_date using actual date object
		/// </summary>
		/// <seealso cref="start_date"/>
		public DateTime? StartDate_IaYoS { get; set; }


		/// <summary>
		/// (optional, default=today) - the last date in which historical stock prices are delivered - end of day prices 
		/// are available around 5 p.m. EST and 15 minute delayed prices are updated every minute throughout the trading day: YYYY-MM-DD
		/// </summary>
		/// <seealso cref="EndDate_IaYoS"/>
		public string end_date => EndDate_IaYoS != null ? EndDate_IaYoS.GetValueOrDefault().ToString("YYYY-MM-DD") : null;

		/// <summary>
		/// Conveniently set end_date using actual date object
		/// </summary>
		/// <seealso cref="end_date"/>
		public DateTime? EndDate_IaYoS { get; set; }

		/// <summary>
		/// (optional, returns daily historical price data otherwise) - the frequency of the historical prices & valuation 
		/// data: daily | weekly | monthly | quarterly | yearly
		/// </summary>
		public DataFrequency frequency { get; set; } = DataFrequency.daily;

		/// <summary>
		/// (optional, returns trailing twelve months (TTM) for the income statement, cash flow statement and calculations, and 
		/// quarterly (QTR) for balance sheet) - the type of periods requested - includes fiscal years for annual data, quarters 
		/// for quarterly data and trailing twelve months for annual data on a quarterly basis: FY | QTR | TTM | YTD
		/// </summary>
		public HistoricalDataType? type { get; set; }


		// show_date (optional, only in Excel add-in, false by default, hence returning the value) if true, the function will return the date value instead of the data point value for the given query: true | false

		/// <summary>
		/// (optional, default=desc) - the order of the historical stock price dates: asc | desc
		/// </summary>
		public Direction? sort_order { get; set; }

	}

	public class SearchHistoricalDataResponse : Response<List<HistoricalDataDto>>
	{

		/// <summary>
		/// the ticker or identifier for the data point
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// the requested standardized tag or series ID
		/// </summary>
		public DataPointTag item { get; set; }
	}
}
 