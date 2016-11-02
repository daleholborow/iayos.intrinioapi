using System;
using iayos.intrinioapi.servicemodel.flag;

namespace iayos.intrinioapi.servicemodel.dto
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values85
	/// </summary>
	public class FundamentalsDto
	{

		/// <summary>
		///  the fiscal year of the fundamental
		/// </summary>
		public int fiscal_year { get; set; }

		/// <summary>
		/// the last date of the fundamental
		/// </summary>
		public DateTime end_date { get; set; }

		/// <summary>
		/// (not available on the balance sheet) the first date of the fundamental
		/// </summary>
		public DateTime? start_date { get; set; }

		/// <summary>
		/// the fiscal period of the fundamental
		/// </summary>
		public FiscalPeriod fiscal_period { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public DateTime filing_date { get; set; }
	}
}