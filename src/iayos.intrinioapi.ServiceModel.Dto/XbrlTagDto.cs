namespace iayos.intrinioapi.servicemodel.dto
{
	/// <summary>
	/// http://docs.intrinio.com/#return-values111
	/// </summary>
	public class XbrlTagDto
	{
		/// <summary>
		/// the reported XBRL tag of the financial data point
		/// </summary>
		public string xbrl_tag { get; set; }

		public string domain_tag { get; set; }

		/// <summary>
		/// the value of the XBRL tag of the financial data point
		/// </summary>
		public object value { get; set; }
	}
}
