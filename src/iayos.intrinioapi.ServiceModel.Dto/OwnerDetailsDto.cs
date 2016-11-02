namespace iayos.intrinioapi.servicemodel.dto
{
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