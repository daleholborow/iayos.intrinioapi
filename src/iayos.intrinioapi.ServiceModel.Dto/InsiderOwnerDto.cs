using System;

namespace iayos.intrinioapi.servicemodel.dto
{
	/// <summary>
	/// http://docs.intrinio.com/#return-values132
	/// </summary>
	public class InsiderOwnerDto
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
		/// - the last insider transaction date where indicated ownership
		/// </summary>
		public DateTime? last_reported_date { get; set; }

		/// <summary>
		/// the value of the owners direct and indirect interests in the company based on the price from the previous day’s price.
		/// </summary>
		public double? value { get; set; }

		/// <summary>
		///  the total number of the owners direct and indirect interests in the company - direct interests are in the insiders name, while indirect interests may be in a trust, foundation, or spouses name but the owner still has some control over the securities
		/// </summary>
		public double? amount { get; set; } 
	}


}
