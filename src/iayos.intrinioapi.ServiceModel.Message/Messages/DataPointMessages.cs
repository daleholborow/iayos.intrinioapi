using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dto;
using iayos.intrinioapi.ServiceModel.Enum;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Message.Messages
{
	[Route("/data_point", HttpMethods.Get)]
	public class SearchDataPoints : Request, IReturn<SearchDataPointsResponse>
	{

		/// <summary>
		/// an identifier for the company or data point, including the SEC CIK ID, FRED Series ID, or 
		/// Damodaran equity risk premium (ERP). You may request up to 150 companies at once by separating 
		/// them by a coma (each ticker and item combination requested will count as 1 query of the API): 
		///   TICKER SYMBOL | STOCK MARKET INDICES | CENTRAL INDEX KEY | DAMODARAN ERP
		/// </summary>
		public string identifier => string.Join(",", Identifers);

		/// <summary>
		/// the specified standardized tag or series ID requested. You may request up to 150 tags at once by 
		/// separating them by a coma (each ticker and item combination requested will count as 1 query of 
		/// the API): INTRINIO DATA POINT TAGS | DAMODARAN ERP
		/// </summary>
		public string item => string.Join(",", Tags);

		public List<string> Identifers { get; set; } = new ArrayOfString();

		public List<DataPointTag> Tags { get; set; } = new List<DataPointTag>();
	}

	public class SearchDataPointsResponse : Response<List<DataPointDto>>
	{
	}

	
}
