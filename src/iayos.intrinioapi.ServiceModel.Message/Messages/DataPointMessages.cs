using System.Collections.Generic;
using System.Runtime.Serialization;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
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
		public string identifier => string.Join(",", Identifers_IaYoS);

		/// <summary>
		/// the specified standardized tag or series ID requested. You may request up to 150 tags at once by 
		/// separating them by a coma (each ticker and item combination requested will count as 1 query of 
		/// the API): INTRINIO DATA POINT TAGS | DAMODARAN ERP
		/// </summary>
		public string item => string.Join(",", Tags_IaYoS);

		/// <summary>
		/// Use this to populate the list of identifiers, wont be serialized
		/// </summary>
		[IgnoreDataMember]
		public List<string> Identifers_IaYoS { get; set; } = new ArrayOfString();

		/// <summary>
		/// Use this to populate the list of tags, wont be serialized
		/// </summary>
		[IgnoreDataMember]
		public List<DataPointTag> Tags_IaYoS { get; set; } = new List<DataPointTag>();
	}

	public class SearchDataPointsResponse : Response<List<DataPointDto>>
	{
	}

	
}
