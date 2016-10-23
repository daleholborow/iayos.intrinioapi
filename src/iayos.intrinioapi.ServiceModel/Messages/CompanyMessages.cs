using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dtos;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{


	[Route("/companies", HttpMethods.Get)]
	public class GetMasterCompaniesList : Request, IReturn<GetMasterCompaniesListResponse>
	{
		
	}

	public class GetMasterCompaniesListResponse : Response<List<CompanyMasterDto>>
	{
	}


	[Route("/companies", HttpMethods.Get)]
	public class SearchCompanies : Request, IReturn<SearchCompaniesResponse>
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

	public class SearchCompaniesResponse : Response<CompanyDetailDto>
	{
	}
}