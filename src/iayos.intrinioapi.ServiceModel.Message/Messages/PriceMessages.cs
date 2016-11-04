using System;
using System.Collections.Generic;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{
	[Route("/prices", HttpMethods.Get)]
	public class GetPrices : RequestList, IReturn<GetPricesResponse>
	{

		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities or the stock market index: TICKER SYMBOL | INDEX SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/*
		item(required, only in Excel add-in function) - the selected observation of the historical prices: 
		date | open | high | low | close | volume | ex_dividend | split_ratio | adj_open | adj_high | adj_low | adj_close | adj_volume
		*/

		/*
		sequence(required, only in Excel add-in function) - an integer 0 or greater for calling a single historical data 
		point from the first entry, based on sort order: 0..last available
		*/


		/// <summary>
		/// Set using 
		/// the first date in which historical stock prices are delivered - historical daily prices go back to 1996 for 
		/// most companies, but some go back further to the 1970s or to the date of the IPO: YYYY-MM-DD
		/// </summary>
		/// <seealso cref="StartDate_IaYoS"/>
		public string start_date => StartDate_IaYoS != null ? StartDate_IaYoS.GetValueOrDefault().ToString("YYYY-MM-DD") : null;

		/// <summary>
		/// Conveniently set start_date using actual date object
		/// </summary>
		/// <seealso cref="start_date"/>
		public DateTime? StartDate_IaYoS { get; set; }


		/// <summary>
		/// (optional, default is today) - the last date in which historical stock prices are delivered - end of day prices 
		/// are available around 5 p.m.EST and 15 minute delayed prices are updated every minute throughout the trading day: YYYY-MM-DD
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
		/// (optional, default=desc) - the order of the historical stock price dates: asc | desc
		/// </summary>
		public Direction? sort_order { get; set; }

	}

	public class GetPricesResponse : ResponseMetaList<PriceDto>
	{
	}

	
}
