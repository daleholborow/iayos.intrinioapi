using System;

namespace iayos.intrinioapi.servicemodel.dto
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values153
	/// </summary>
	public class SecurityInstitutionalOwnerDetailsDto
	{
		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string owner_cik { get; set; }

		/// <summary>
		/// the name of the owner, either an institutional owner or an insider owner
		/// </summary>
		public string owner_name { get; set; }

		/// <summary>
		/// - the date of the latest 13-F filing on record with the SEC.
		/// </summary>
		public DateTime? period_ended { get; set; }

		/// <summary>
		/// the market value in amount of dollars of the holding in the listed security
		/// </summary>
		public double? value { get; set; }

		/// <summary>
		/// the number of shares held in the listed security
		/// </summary>
		public double? amount { get; set; }

		/// <summary>
		/// the number of shares where the insitutional holder has sole voting authority
		/// </summary>
		public double? sole_voting_authority { get; set; }

		/// <summary>
		/// the number of shares where the insitutional holder has shared voting authority
		/// </summary>
		public double? shared_voting_authority { get; set; }

		/// <summary>
		/// the number of shares where the insitutional holder has no voting authority
		/// </summary>
		public double? no_voting_authority { get; set; }

		/// <summary>
		/// the prior quarter number of shares held by the owner
		/// </summary>
		public double? prev_amount { get; set; }

		/// <summary>
		/// the change in number of shares held from the prior quarter
		/// </summary>
		public double? amount_chg { get; set; }

		/// <summary>
		/// the percentage change in the number of shares held from the prior quarter
		/// </summary>
		public double? amount_pct_chg { get; set;  } 

	}




	/// <summary>
	/// http://docs.intrinio.com/#return-values124
	/// </summary>
	public class OwnerDetailsDto
	{
		#region for shortened summary version
		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string owner_cik { get; set; }

		/// <summary>
		/// the name of the owner, either an institutional owner or an insider owner
		/// </summary>
		public string owner_name { get; set; }
		#endregion

		#region full version
		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string cik_id { get; set; }

		/// <summary>
		/// the name of the owner, either an institutional owner or an insider owner
		/// </summary>
		public string name { get; set; }

		/// <summary>
		///  the state (US & Canada Only) where the company headquarters is located
		/// </summary>
		public string state { get; set; }

		/// <summary>
		/// the state (US & Canada Only) where the company is incorporated
		/// </summary>
		public string state_inc { get; set; }

		/// <summary>
		/// the country where the company is incorporated
		/// </summary>
		public string country_inc { get; set; }

		/// <summary>
		///  the company’s headquarters address
		/// </summary>
		public string business_address { get; set; }

		/// <summary>
		/// the phone number reported by the company
		/// </summary>
		public string business_phone_no { get; set; }

		/// <summary>
		/// the mailing address reported by the company
		/// </summary>
		public string mailing_address { get; set; }

		/// <summary>
		///  (true or false) boolean indicating whether or not the owner is an institutional owner or other owner type (such as insider owner)
		/// </summary>
		public bool? institutional { get; set; }
		#endregion
	}
}