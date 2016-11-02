using System;

namespace iayos.intrinioapi.ServiceModel.Dto
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values75
	/// </summary>
	public class CompanySecFilingDto
	{
		public DateTime filing_date { get; set; }
		public DateTime accepted_date { get; set; }
		public DateTime period_ended { get; set; }
		public string accno { get; set; }
		public string report_type { get; set; }
		public string filing_url { get; set; }
		public string report_url { get; set; }
		public string instance_url { get; set; }
	}


	/// <summary>
	/// http://docs.intrinio.com/#return-values128
	/// </summary>
	public class TransactionDto
	{

		#region All Filings

		/// <summary>
		/// the ticker symbol for the company’s common stock
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// the company’s Central Index Key(CIK) unique identifier with the SEC
		/// </summary>
		public string company_cik { get; set; }

		/// <summary>
		///  the name of the company
		/// </summary>
		public string company_name { get; set; }

		/// the date of the filing with the SEC made by the owner 
		public DateTime? filing_date { get; set; }

		///the URL of the filing with the SEC 
		public string filing_url { get; set; }

		/// <summary>
		/// (true/false) a boolean indicating whether or not the owner is a director in the company
		/// </summary>
		public bool? director { get; set; }

		/// <summary>
		/// (true/false) a boolean indicating whether or not the owner is a officer in the company
		/// </summary>
		public bool? officer { get; set; }

		/// <summary>
		/// (true/false) a boolean indicating whether or not the owner has a ten percent or greater interest in the company
		/// </summary>
		public bool? ten_percent_owner { get; set; }

		/// <summary>
		/// (true/false) a boolean indicating whether or not the owner has another relationship with the company beside, direct, officer, or significant owner in the company
		/// </summary>
		public bool? other_relation { get; set; }

		/// <summary>
		/// the officer title of the owner in the company
		/// </summary>
		public string officer_title { get; set; }


		/// <summary>
		/// (false) a boolean indicating the transaction is not a derivative transaction and instead is dealings in the common stock of the company
		/// (true) a boolean indicating the transaction is a derivative transaction, which may or may not become common stock due to various possible exercise or conversion requirements
		/// </summary>
		public bool derivative_transaction { get; set; }

		#endregion



		/// <summary>
		///  the name of the derivative security transacted
		/// </summary>
		public string security_title { get; set; }


		/// <summary>
		/// the price of the derivative securities
		/// </summary>
		public double? transaction_price { get; set; }

		/// <summary>
		/// the total number of derivative securities owned following the subject transaction
		/// </summary>
		public string total_shares_owned { get; set; }

		/// <summary>
		/// a symbol representing the ownership of the securities transacted: D - Direct Ownership | I - Indirect Ownership
		/// </summary>
		public string ownership_type_code { get; set; }


		/// <summary>
		/// the line number of the transaction from the filing document
		/// </summary>
		public int? report_line_number { get; set; }


		#region Non-Derivate Filings

		public string owner_cik { get; set; }

		public string owner_name { get; set; }

		/// <summary>
		/// the date of the transaction
		/// </summary>
		public DateTime? transaction_date { get; set; }

		/// <summary>
		/// the date of the transaction had it not a directly identifiable date
		/// </summary>
		public DateTime? deemed_execution_date { get; set; }

		/// <summary>
		/// a symbol representing the transaction type: P - Purchase | S — Sale | A — Award | M - Conversion to Common | C — Conversion | X - Exercise of Derivative More Transaction Codes
		/// </summary>
		public string transaction_type_code { get; set; }

		/// <summary>
		/// the number of derivative securities involved in the subject transaction
		/// </summary>
		public double? amount_of_shares { get; set; }

		/// <summary>
		/// a symbol representing whether or not the derivative securities are Acquired or Disposed: A - Acquisition | D - Disposition
		/// </summary>
		public string acquisition_disposition_code { get; set; }

		#endregion


		#region Derivate Filings

		/// <summary>
		/// the conversion or exercise price of the derivative security transacted
		/// </summary>
		public string conversion_exercise_price { get; set; }

		/// <summary>
		/// - the exercise date of the derivative securities
		/// </summary>
		public DateTime? exercise_date { get; set;  }

		/// <summary>
		/// the expiration date of the derivative securities
		/// </summary>
		public DateTime? expiration_date { get; set; }

		/// <summary>
		/// the name of the underlying non-derivative security related to this derivative transaction
		/// </summary>
		public string underlying_security_title { get; set; }

		/// <summary>
		/// the number of non-derivative shares involved in the subject transaction
		/// </summary>
		public double? underlying_shares { get; set; }

		/// <summary>
		/// if the ownership type is indirect, an indication of who is the owner of the securities - usually a trust, foundation, or spouse
		/// </summary>
		public string nature_of_ownership { get; set; }


		#endregion



	}
}