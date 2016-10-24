using System;

namespace iayos.intrinioapi.ServiceModel.Dtos
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
}