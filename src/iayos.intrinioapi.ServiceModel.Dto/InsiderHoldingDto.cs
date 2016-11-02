using System;

namespace iayos.intrinioapi.servicemodel.dto
{
	public class InsiderHoldingDto
	{
		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		///  the Central Index Key issued by the SEC, which is the unique identifier all company filings are issued under
		/// </summary>
		public string company_cik { get; set; }

		/// <summary>
		/// the company name in shorter form
		/// </summary>
		public string company_name { get; set; }

		/// <summary>
		/// the Stock Exchange where the company’s common stock is primarily traded
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		/// the last insider transaction date where indicated ownership
		/// </summary>
		public DateTime last_reported_date { get; set; }

		/// <summary>
		/// the value of the owners direct and indirect interests in the company based on the price from the previous day’s price.
		/// </summary>
		public object value { get; set; }
		/// <summary>
		/// the total number of the owners direct and indirect interests in the company - direct interests are in the insiders name, while 
		/// indirect interests may be in a trust, foundation, or spouses name but the owner still has some control over the securities
		/// </summary>
		public double amount { get; set; }
	}
}