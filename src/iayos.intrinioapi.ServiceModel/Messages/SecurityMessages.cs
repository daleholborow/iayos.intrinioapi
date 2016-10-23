using System;
using System.Collections.Generic;
using System.Linq;
using iayos.intrinioapi.ServiceModel.Dtos;
using iayos.intrinioapi.ServiceModel.Enums;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{


	[Route("/securities", HttpMethods.Get)]
	public class GetMasterSecuritiesList : Request, IReturn<GetSecuritiesResponse>
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
		public string conditions => (SearchConditions.Count == 0) 
			? string.Empty 
			: string.Join(",", SearchConditions.Select(sc => $"{sc.Tag}~{sc.Operator}~{sc.Value}"));

		/// <summary>
		/// A data tag by which to order the results INTRINIO DATA POINT TAGS
		/// </summary>
		public DataPointTag? order_column { get; set; }

		/// <summary>
		/// The direction in which to order the results(“asc” for Ascending or “desc” for descending)
		/// </summary>
		public Direction? order_direction { get; set; }

		public List<SecuritiesSearchCondition> SearchConditions { get; set; } = new List<SecuritiesSearchCondition>();

	}

	public class SearchSecuritiesResponse : Response<List<SecurityMasterDto>>
	{
		
	}


	public class SecuritiesSearchCondition
	{
		public DataPointTag Tag { get; set; }

		public SearchOperator Operator { get; set; } = SearchOperator.eq;

		public object Value { get; set; }
	}
}
