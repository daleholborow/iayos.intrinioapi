using System;
using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Enums;

namespace iayos.intrinioapi.ServiceModel.Dtos
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


	/// <summary>
	/// Detailed company data as returned by specific company search
	/// </summary>
	public class CompanyDetailDto
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


		public List<SecurityDetailDto> securities { get; set; }

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


	public class CompanyNewsDto
	{
		/// <summary>
		/// the title of the article
		/// </summary>
		public string title { get; set; }

		/// <summary>
		/// the date the article was published
		/// </summary>
		public DateTime publication_date { get; set; }


		/// <summary>
		/// the hyperlink to the article
		/// </summary>
		public string url { get; set; }


		/// <summary>
		/// a brief summary of the article
		/// </summary>
		public string summary { get; set; }
	}

}
