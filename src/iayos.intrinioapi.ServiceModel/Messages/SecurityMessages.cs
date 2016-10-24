using System;
using System.Collections.Generic;
using System.Linq;
using iayos.intrinioapi.ServiceModel.Dtos;
using iayos.intrinioapi.ServiceModel.Enums;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{


	[Route("/securities", HttpMethods.Get)]
	public class GetSecuritiesMasterList : Request, IReturn<GetSecuritiesMasterListResponse>
	{
	}

	public class GetSecuritiesMasterListResponse : Response<List<SecurityDetailDto>>
	{
	}



	[Route("/securities", HttpMethods.Get)]
	public class GetSecurityDetails : Request, IReturn<GetSecurityDetailsResponse>
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
		/// <seealso cref="LastCrspAdjDate_IaYoS"/>
		public string last_crsp_adj_date => LastCrspAdjDate_IaYoS != null ? LastCrspAdjDate_IaYoS.GetValueOrDefault().ToString("YYYY-MM-DD") : null;

		/// <summary>
		/// Conveniently set last_crsp_adj_date using actual date object
		/// </summary>
		/// <seealso cref="last_crsp_adj_date"/>
		public DateTime? LastCrspAdjDate_IaYoS { get; set; }
	}

	public class GetSecurityDetailsResponse : Response<List<SecurityDetailDto>>
	{
	}


	/// <summary>
	/// Massively detailed dataset when searching for particular securities
	/// </summary>
	[Route("/securities/search", HttpMethods.Get)]
	public class SearchSecurities : Request, IReturn<SearchSecuritiesResponse>
	{

		/// <summary>
		/// A comma-separated list of conditions.Each condition consists three elements separated by tildes (~):
		///  - A data tag INTRINIO DATA POINT TAGS
		///  - An operator
		///    Equal to: “eq”
		///    Greater than: “gt”
		///    Greater than or equal to: “gte”
		///    Less than: “lt”
		///    Less than or equal to: “lte”
		///    Contains text: “contains”
		///  - A value
		/// </summary>
		/// <seealso cref="Conditions_IaYoS"/>
		public string conditions => (Conditions_IaYoS.Count == 0)
			? null
			: string.Join(",", Conditions_IaYoS.Select(sc => $"{sc.Tag}~{sc.Operator}~{sc.Value}"));

		/// <summary>
		/// A data tag by which to order the results INTRINIO DATA POINT TAGS
		/// </summary>
		public DataPointTag? order_column { get; set; }

		/// <summary>
		/// The direction in which to order the results(“asc” for Ascending or “desc” for descending)
		/// </summary>
		public Direction? order_direction { get; set; }

		public List<SecuritiesSearchCondition> Conditions_IaYoS { get; set; } = new List<SecuritiesSearchCondition>();

	}

	public class SearchSecuritiesResponse : Response<List<SecurityScreenerDetailDto>>
	{
	}


	public class SecuritiesSearchCondition
	{
		public DataPointTag Tag { get; set; }

		public SearchOperator Operator { get; set; } = SearchOperator.eq;

		public object Value { get; set; }
	}
}
