using iayos.intrinioapi.servicemodel.dto;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{

	/// <summary>
	/// http://docs.intrinio.com/#company-master
	/// Get all the master companies list items
	/// </summary>
	[Route("/companies", HttpMethods.Get)]
	public class GetCompaniesMasterList : RequestMany, IReturn<GetCompaniesMasterListResponse>
	{
	}

	public class GetCompaniesMasterListResponse : ResponseMany<CompanyMasterDto>
	{
	}


	/// <summary>
	/// http://docs.intrinio.com/#companies
	/// Load a SINGLE company based on ticker or cik
	/// </summary>
	[Route("/companies", HttpMethods.Get)]
	public class GetSingleCompanyDetails : IRequestSingle, IReturn<GetSingleCompanyDetailsResponse>
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

		///// <summary>
		///// query (optional, returns full list of companies with compacted response values, if no query specified) - a string 
		///// query search of company name or ticker symbol with the returned results being the relevant companies in compacted list format.
		///// </summary>
		//public string query { get; set; }
	}

	public class GetSingleCompanyDetailsResponse : CompanyDetailDto, IResponseSingle
	{

	}


	/// <summary>
	/// http://docs.intrinio.com/#companies
	/// Load a collection of companies
	/// </summary>
	[Route("/companies", HttpMethods.Get)]
	public class GetCompanyDetails : RequestMany, IReturn<GetCompanyDetailsResponse>
	{
		/*/// <summary>
		/// identifier (optional, returns full list of companies with compacted response values, if no identifier 
		/// specified) - the stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// cik (optional, returns full list of companies with compacted response values, if no identifier specified) - the 
		/// Central Index Key issued by the SEC, which is the unique identifier all company filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }*/

		/// <summary>
		/// query (optional, returns full list of companies with compacted response values, if no query specified) - a string 
		/// query search of company name or ticker symbol with the returned results being the relevant companies in compacted list format.
		/// </summary>
		public string query { get; set; }
	}

	public class GetCompanyDetailsResponse : ResponseMany<CompanyMasterDto>
	{
		
	}


	[Route("/news", HttpMethods.Get)]
	public class GetCompanyNews : RequestMany, IReturn<GetCompanyNewsResponse>
	{
		/// <summary>
		/// ithe stock market ticker symbol associated with the company’s common stock. If the company is foreign, use the stock 
		/// exchange code, followed by a colon, then the ticker. You may request up to 10 tickers at once by separating them with a coma: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }
	}

	public class GetCompanyNewsResponse : ResponseMany<CompanyNewsDto>
	{
		
	}

	
}