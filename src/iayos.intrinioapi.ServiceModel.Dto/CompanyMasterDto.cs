namespace iayos.intrinioapi.servicemodel.dto
{
	/// <summary>
	/// Limited subset of company data as returned doing Master Data listing
	/// </summary>
	public class CompanyMasterDto
	{
		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all company filings are issued under
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// the Legal Entity Identifier for the company
		/// </summary>
		public string lei { get; set; }

		/// <summary>
		/// the company name in shorter form
		/// </summary>
		public string cik { get; set; }
	}
}