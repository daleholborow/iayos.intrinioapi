using System;

namespace iayos.intrinioapi.servicemodel.dto
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values75
	/// </summary>
	public class CompanySecFilingDto
	{

		/// <summary>
		///  the date the filing was submitted to the SEC by the company
		/// </summary>
		public DateTime? filing_date { get; set; }

		/// <summary>
		/// the date and time when the filing was submitted to the SEC by the company
		/// </summary>
		public DateTime? accepted_date { get; set; }

		/// <summary>
		/// the date of the period end for the filing
		/// </summary>
		public DateTime? period_ended { get; set; }

		/// <summary>
		/// the SEC unique number for the filing
		/// </summary>
		public string accno { get; set; }

		/// <summary>
		///  the filing report type
		/// </summary>
		public string report_type { get; set; }

		/// <summary>
		/// the URL to the filing page on the SEC site
		/// </summary>
		public string filing_url { get; set; }

		/// <summary>
		///  the URL to the actual report on the SEC site
		/// </summary>
		public string report_url { get; set; }

		/// <summary>
		///  the URL for the XBRL filing for the report
		/// </summary>
		public string instance_url { get; set; }
	}
}