using System;

namespace iayos.intrinioapi.ServiceModel.Messages
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values85
	/// </summary>
	public class StandardizedFundamentalsDto
	{
		public int fiscal_year { get; set; }
		public DateTime end_date { get; set; }
		public DateTime start_date { get; set; }
		public string fiscal_period { get; set; }
		public string filing_date { get; set; }
	}
}