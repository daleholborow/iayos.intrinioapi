using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Messages;

namespace iayos.intrinioapi.ServiceModel.Dtos
{

	public enum EntityStatus
	{
		UNKNOWN = 0,		// iayos value, to be used as the default, but we expect to always resolve status 
		ACTIVE
	}
	public class SecurityDto
	{
		public string ticker { get; set; }
		public string security_name { get; set; }
		public string security_type { get; set; }
		public string security_class { get; set; }
		public string stock_exchange { get; set; }
		public string listing_exchange { get; set; }
		public object market_category { get; set; }
		public bool etf { get; set; }
		public int round_lot_size { get; set; }
		public object financial_status { get; set; }
		public bool primary_security { get; set; }
		public bool delisted_security { get; set; }
		public string last_crsp_adj_date { get; set; }
	}


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

		/// <summary>
		///  the company’s official legal name
		/// </summary>
		public string legal_name { get; set; }

		/// <summary>
		///  the Stock Exchange where the company’s common stock is primarily traded
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		///  the Standard Industrial Classification (SIC) determined by the company filed with the SEC
		/// </summary>
		public int sic { get; set; }

		/// <summary>
		///  a one or two sentence description of the company’s operations
		/// </summary>
		public string short_description { get; set; }

		/// <summary>
		/// a one paragraph description of the company’s operations and other corporate actions
		/// </summary>
		public string long_description { get; set; }

		/// <summary>
		/// the Chief Executive Officer of the company
		/// </summary>
		public string ceo { get; set; }

		/// <summary>
		/// the url to the company’s primary corporate website or primary internet property
		/// </summary>
		public string company_url { get; set; }

		/// <summary>
		///  the company’s headquarters address
		/// </summary>
		public string business_address { get; set; }

		/// <summary>
		/// the mailing address reported by the company
		/// </summary>
		public string mailing_address { get; set; }

		/// <summary>
		/// the phone number reported by the company
		/// </summary>
		public string business_phone_no { get; set; }

		/// <summary>
		/// the company’s headquarters address line 1
		/// </summary>
		public string hq_address1 { get; set; }

		/// <summary>
		/// the company’s headquarters address line 2
		/// </summary>
		public object hq_address2 { get; set; }

		/// <summary>
		/// the company’s headquarters city
		/// </summary>
		public string hq_address_city { get; set; }

		/// <summary>
		/// the company’s headquarters postal code
		/// </summary>
		public string hq_address_postal_code { get; set; }

		/// <summary>
		///  the company’s legal organization form
		/// </summary>
		public string entity_legal_form { get; set; }


		public List<SecurityDto> securities { get; set; }

		/// <summary>
		///  the financial statement template used by Intrinio to standardize the as reported data
		/// </summary>
		public string template { get; set; }

		/// <summary>
		/// if true, the company has standardized and as reported fundamental data via the Intrinio API; 
		/// if false, the company has as reported data only.
		/// </summary>
		public bool standardized_active { get; set; }

		/// <summary>
		/// the state (US &amp; Canada Only) where the company headquarters is located
		/// </summary>
		public string hq_state { get; set; }

		/// <summary>
		///  the country where the company headquarters is located
		/// </summary>
		public string hq_country { get; set; }

		/// <summary>
		/// the state (US & Canada Only) where the company is incorporated
		/// </summary>
		public string inc_state { get; set; }

		/// <summary>
		///  the country where the company is incorporated
		/// </summary>
		public string inc_country { get; set; }

		/// <summary>
		///  the number of employees working for the company
		/// </summary>
		public int employees { get; set; }


		public EntityStatus entity_status { get; set; }

		/// <summary>
		///  the company’s operating sector
		/// </summary>
		public string sector { get; set; }

		/// <summary>
		/// the company’s operating industry category
		/// </summary>
		public string industry_category { get; set; }

		/// <summary>
		///  the company’s operating industry group
		/// </summary>
		public string industry_group { get; set; }
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
		public string symbol { get; set; }

		/// <summary>
		/// the index name
		/// </summary>
		public string index_name { get; set; }

		public string continent { get; set; }

		public string country { get; set; }

		
		public IndexType index_type { get; set; } = IndexType.full;
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
