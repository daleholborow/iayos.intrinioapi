using System;
using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dtos;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{


	[Route("/companies", HttpMethods.Get)]
	public class GetCompanies : Request, IReturn<GetCompaniesResponse>
	{
		/// <summary>
		/// identifier (optional, returns full list of companies with compacted response values, if no identifier 
		/// specified) - the stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// cik (optional, returns full list of companies with compacted response values, if no identifier specified) - the 
		/// Central Index Key issued by the SEC, which is the unique identifier all company filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }

		/// <summary>
		/// query (optional, returns full list of companies with compacted response values, if no query specified) - a string 
		/// query search of company name or ticker symbol with the returned results being the relevant companies in compacted list format.
		/// </summary>
		public string query { get; set; }
	}

	public class GetCompaniesResponse : Response<List<CompanyMasterDto>>
	{
	}


	[Route("/securities", HttpMethods.Get)]
	public class GetSecurities : Request, IReturn<GetSecuritiesResponse>
	{
		/// <summary>
		/// (optional, returns list of securities with compacted response values, if no identifier specified) - the 
		/// stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// (optional, returns list of securities with compacted response values, if no query specified) - a string 
		/// query search of security name or ticker symbol with the returned results being the relevant securities in compacted list format.
		/// </summary>
		public string query { get; set; }

		/// <summary>
		/// (optional) - a date value that returns the list of securities that have had adjusted stock prices 
		/// due to a corporate event after this date: YYYY-MM-DD
		/// </summary>
		public string last_crsp_adj_date => iayosLastCrspAdjDate != null ? iayosLastCrspAdjDate.GetValueOrDefault().ToString("YYYY-MM-DD") : string.Empty;

		/// <summary>
		/// Conveniently set last_crsp_adj_date using actual date object
		/// </summary>
		public DateTime? iayosLastCrspAdjDate { get; set; }
	}

	public class GetSecuritiesResponse : Response<List<SecurityMasterDto>>
	{
		/// <summary>
		/// (optional, returns list of securities with compacted response values, if no identifier specified) - the 
		/// stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// (optional, returns list of securities with compacted response values, if no query specified) - a string 
		/// query search of security name or ticker symbol with the returned results being the relevant securities in compacted list format.
		/// </summary>
		public string query { get; set; }

		/// <summary>
		/// (optional) - a date value that returns the list of securities that have had adjusted stock prices due to a corporate event after this date: YYYY-MM-DD
		/// </summary>
		public string last_crsp_adj_date => iayosLastCrspAdjDate != null ? iayosLastCrspAdjDate.GetValueOrDefault().ToString("YYYY-MM-DD") : string.Empty;


		/// <summary>
		/// Conveniently set last_crsp_adj_date using actual date object
		/// </summary>
		public DateTime? iayosLastCrspAdjDate { get; set; }
	}


	public enum IndexType
	{
		full,       // returns full list by default
		stock_market,
		economic,
		sic
	}


	[Route("/indices", HttpMethods.Get)]
	public class GetIndices : Request, IReturn<GetIndicesResponse>
	{
		/// <summary>
		/// (optional, returns full list of indices with compacted response values if no symbol or 
		/// identifier specified) - the Intrinio symbol associated with the index: STOCK MARKET INDICES
		/// </summary>
		public string identifier { get; set;  }

		/// <summary>
		/// (optional, returns list of indices with compacted response values, if no query specified) - a 
		/// string query search of index name or symbol with the returned results being the relevant securities in compacted list format.
		/// </summary>
		public string query { get; set; }


		/// <summary>
		/// (optional, returns full list of indices otherwise) - the type of indices specified: stock_market
		/// </summary>
		public IndexType type { get; set; } = IndexType.full;
	}

	public class GetIndicesResponse : Response<List<IndiceMasterDto>>
	{
	}


	[Route("/owners", HttpMethods.Get)]
	public class GetOwners : Request, IReturn<GetOwnersResponse>
	{
	}

	public class GetOwnersResponse : Response<List<OwnerMasterDto>>
	{
	}

	
}
