using System;
using iayos.intrinioapi.servicemodel.flag;

namespace iayos.intrinioapi.servicemodel.dto
{
	/// <summary>
	/// Both:
	/// http://docs.intrinio.com/#security-master
	/// and
	/// http://docs.intrinio.com/#securities
	/// </summary>
	public class SecurityDetailDto
	{
		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		/// the security description as provided by the exchange
		/// </summary>
		public string security_name { get; set; }

		/// <summary>
		/// the type of security, such as Common Stock, Preferred Stock, Warrants, Limited Partnership Interests, etc.
		/// </summary>
		public string security_type { get; set; }

		/// <summary>
		/// if a company has multiple securities, the security class is a single letter description of the class of a certain type of security.
		/// </summary>
		public string security_class { get; set; }

		/// <summary>
		/// the Stock Exchange (and market category) where the company’s common stock is primarily traded
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		/// the Stock Exchange where the company’s common stock is primarily traded
		/// </summary>
		public string listing_exchange { get; set; }

		/// <summary>
		///  the NASDAQ market category for a NASDAQ listed company.
		/// </summary>
		public string market_category { get; set; }

		/// <summary>
		/// true or false, depending on whether the security is an ETF or not.
		/// </summary>
		public bool? etf { get; set; }

		/// <summary>
		///  the round lot size for the security.
		/// </summary>
		public int? round_lot_size { get; set; }

		/// <summary>
		/// indicates when an issuer has failed to submit its regulatory filings on a timely basis, has failed 
		/// to meet NASDAQ’s continuing listing standards, and/or has filed for bankruptcy. 
		/// </summary>
		public SecurityFinancialStatus? financial_status { get; set; }

		/// <summary>
		/// true if the subject security is the primary security for the company. If a security is the default, 
		/// the ticker symbol for the security is the same as the ticker for the company (see /Companies endpoint).
		/// </summary>
		public bool? primary_security { get; set; }

		/// <summary>
		/// if the security is no longer traded on public exchanges, the security will be considered delisted 
		/// and the security no longer will report pricing data.
		/// </summary>
		public bool? delisted_security { get; set; }

		/// <summary>
		/// the last recorded date (“yyyy-MM-dd”) of an CRSP adjustment made to prior prices due to a stock split or dividend event.
		/// </summary>
		public DateTime? last_crsp_adj_date { get; set; }
	}
}