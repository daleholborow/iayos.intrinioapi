using System;
using iayos.intrinioapi.ServiceModel.Enums;

namespace iayos.intrinioapi.ServiceModel.Dtos
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values85
	/// </summary>
	public class FundamentalsDto
	{
		public int fiscal_year { get; set; }

		public DateTime end_date { get; set; }

		public DateTime start_date { get; set; }

		public FiscalPeriod fiscal_period { get; set; }

		public DateTime filing_date { get; set; }
	}
}