namespace iayos.intrinioapi.ServiceModel.Dtos
{
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



	public class SecurityMasterDto
	{
		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		///  the security description as provided by the exchange
		/// </summary>
		public string security_name { get; set; }

		/// <summary>
		/// the type of security, such as Common Stock, Preferred Stock, Warrants, Limited Partnership Interests, etc.
		/// </summary>
		public string security_type { get; set; }

		/// <summary>
		/// if a company has multiple securities, the security class is a single letter description of the class of a certain type of security.
		/// </summary>
		public object security_class { get; set; }

		/// <summary>
		/// the Stock Exchange (and market category) where the company’s common stock is primarily traded
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		/// the Stock Exchange where the company’s common stock is primarily traded
		/// </summary>
		public string listing_exchange { get; set; }

		/// <summary>
		/// the NASDAQ market category for a NASDAQ listed company.
		/// </summary>
		public string market_category { get; set; }

		/// <summary>
		/// true or false, depending on whether the security is an ETF or not.
		/// </summary>
		public bool etf { get; set; }

		/// <summary>
		/// the round lot size for the security.
		/// </summary>
		public int round_lot_size { get; set; }

		/// <summary>
		/// indicates when an issuer has failed to submit its regulatory filings on a timely basis, has failed to 
		/// meet NASDAQ’s continuing listing standards, and/or has filed for bankruptcy. 
		/// Values include: 
		/// D = Deficient: Issuer Failed to Meet NASDAQ Continued Listing Requirements, 
		/// E = Delinquent: Issuer Missed Regulatory Filing Deadline, 
		/// Q = Bankrupt: Issuer Has Filed for Bankruptcy, 
		/// N = Normal (Default): Issuer Is NOT Deficient, Delinquent, or Bankrupt., 
		/// G = Deficient and Bankrupt, 
		/// H = Deficient and Delinquent, 
		/// J = Delinquent and Bankrupt, 
		/// K = Deficient, Delinquent, and Bankrupt
		/// </summary>
		public object financial_status { get; set; }

		/// <summary>
		///  true if the subject security is the primary security for the company. If a security is the default, 
		/// the ticker symbol for the security is the same as the ticker for the company (see /Companies endpoint).
		/// </summary>
		public bool primary_security { get; set; }

		/// <summary>
		///  if the security is no longer traded on public exchanges, the security will be considered delisted and the security no longer will report pricing data.
		/// </summary>
		public bool delisted_security { get; set; }

		/// <summary>
		/// the last recorded date (“YYYY-MM-DD”) of an CRSP adjustment made to prior prices due to a stock split or dividend event.
		/// </summary>
		public string last_crsp_adj_date { get; set; }
	}


	public class IndiceMasterDto
	{
		/// <summary>
		/// the Intrinio symbol associated with the index
		/// </summary>
		public string symbole { get; set; }

		/// <summary>
		/// the index name
		/// </summary>
		public string index_name { get; set; }
	}


	public class OwnerMasterDto
	{

		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string owner_cik { get; set; }


		/// <summary>
		/// the name of the owner, either an institutional owner or an insider owner
		/// </summary>
		public string owner_name { get; set; }
	}

}
