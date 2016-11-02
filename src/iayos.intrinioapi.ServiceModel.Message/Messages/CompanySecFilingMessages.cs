using System.Collections.Generic;
using iayos.intrinioapi.servicemodel.dto;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{

	[Route("/companies/filings", HttpMethods.Get)]
	public class GetCompanySecFilings : Request, IReturn<GetCompanySecFilingsResponse>
	{
		/// <summary>
		/// the ticker or identifier for the data point
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// the report type of the filing requested: 10-K | 10-Q | 8-K | 4 | etc
		/// </summary>
		public string report_type { get; set; }
	}

	

	public class GetCompanySecFilingsResponse : Response<List<CompanySecFilingDto>>
	{
	}
}
