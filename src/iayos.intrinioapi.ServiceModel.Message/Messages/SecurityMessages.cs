using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{


	[Route("/securities", HttpMethods.Get)]
	public class GetSecuritiesMasterList : RequestMany, IReturn<GetSecuritiesMasterListResponse>
	{
	}

	public class GetSecuritiesMasterListResponse : ResponseMany<SecurityDetailDto>
	{
	}



	[Route("/securities", HttpMethods.Get)]
	public class GetSecurityDetails : RequestMany, IReturn<GetSecurityDetailsResponse>
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

	public class GetSecurityDetailsResponse : ResponseMany<SecurityDetailDto>
	{
	}


	/// <summary>
	/// Massively detailed dataset when searching for particular securities
	/// </summary>
	[Route("/securities/search", HttpMethods.Get)]
	public class SearchSecurities : RequestMany, IReturn<SearchSecuritiesResponse>
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

		[IgnoreDataMember]
		public List<SecuritiesSearchCondition> Conditions_IaYoS { get; set; } = new List<SecuritiesSearchCondition>();

	}

	public class SearchSecuritiesResponse : ResponseMany<SecurityScreenerDetailDto>
	{
	}


	public class SecuritiesSearchCondition
	{
		public DataPointTag Tag { get; set; }

		public SearchOperator Operator { get; set; } = SearchOperator.eq;

		public object Value { get; set; }
	}


	/// <summary>
	/// http://docs.intrinio.com/#endpoint151
	/// </summary>
	[Route("/securities/institutional_ownership", HttpMethods.Get)]
	public class GetSecurityInstitutionalOwners : RequestMany, IReturn<GetSecurityInstitutionalOwnersResponse>
	{

		/// <summary>
		/// (optional, must have company cik otherwise) - the stock market ticker symbol associated with 
		/// the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }


		/// <summary>
		/// (optional, must have a ticker symbol otherwise) - the Central Index Key issued by the SEC, which 
		/// is the unique identifier all company filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }
	}

	public class GetSecurityInstitutionalOwnersResponse : ResponseMany<SecurityInstitutionalOwnerDetailsDto> { }
}
