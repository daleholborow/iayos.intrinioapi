using System;

namespace iayos.intrinioapi.servicemodel.dto
{
	/// <summary>
	/// http://docs.intrinio.com/#return-values149
	/// </summary>
	public class OwnerInstitutionalHoldingDto
	{

		/// <summary>
		///  the CUSIP number for the security report by the Institutional Owner
		/// </summary>
		public string cusip { get; set; }


		/// <summary>
		///  the ticker symbol for the security
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		///  - the name of the security
		/// </summary>
		public string security_name { get; set; }

		/// <summary>
		/// the type of the security
		/// </summary>
		public string security_type { get; set; }

		/// <summary>
		///  the class of stock held
		/// </summary>
		public string title_of_class { get; set; }

		/// <summary>
		/// the stock exchange where the security is traded
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		/// the date of the latest 13-F filing on record with the SEC.
		/// </summary> 
		public DateTime period_ended { get; set; }

		/// <summary>
		/// shares
		/// </summary>
		public string type { get; set; } 

		/// <summary>
		/// Segregate the holdings of securities of a class according to the nature of the investment discretion held by the Manager.
		/// </summary>
		public string investment_discretion { get; set; }

		/// <summary>
		/// a code for other managerial authority of the securities listed
		/// </summary>
		public string other_manager { get; set; }

		/// <summary>
		/// the number of shares where the insitutional holder has sole voting authority
		/// </summary>
		public string sole_voting_authority { get; set; }

		/// <summary>
		/// the number of shares where the insitutional holder has shared voting authority
		/// </summary>
		public string shared_voting_authority { get; set; }

		/// <summary>
		///  the number of shares where the insitutional holder has no voting authority
		/// </summary>
		public string no_voting_authority { get; set; }
		
		/// <summary>
		///  the market value in amount of dollars of the holding in the listed security
		/// </summary>
		public double value { get; set; }

		/// <summary>
		/// the number of shares held in the listed security
		/// </summary>
		public double amount { get; set; }
	}
}