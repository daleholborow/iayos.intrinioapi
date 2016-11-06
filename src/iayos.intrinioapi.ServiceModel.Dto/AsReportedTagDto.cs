namespace iayos.intrinioapi.servicemodel.dto
{
	/// <summary>
	/// http://docs.intrinio.com/#return-values106
	/// </summary>
	public class AsReportedTagDto
	{
		/// <summary>
		/// the label of the XBRL tag as reported of the financial statement
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// the XBRL tag of the associated financial data point - maybe can make this an enum?
		/// </summary>
		public string tag { get; set; }

		/// <summary>
		/// the accounting balance (debit or credit) of the tag
		/// </summary>
		public string balance { get; set; }

		/// <summary>
		/// the unit type of the XBRL tag
		/// </summary>
		public string unit { get; set; }

		/// <summary>
		/// the specified domain XBRL tag, associated with certain data points on the financial statements that have a dimension associated with the data point
		/// </summary>
		public string domain_tag { get; set; }

		/// <summary>
		/// the type of value - true indicates that the value is a header label and has no associated data value, whereas false indicates that the XBRL tag has an associated value.
		/// </summary>
		public bool? @abstract { get; set; }

		/// <summary>
		/// an integer 0 or greater indicating the presentation order of the XBRL tag and label in the financial statement
		/// </summary>
		public int? sequence { get; set; }

		/// <summary>
		/// an integer 0 or greater indicating the presentation indentation depth of the XBRL tag and label in the financial statement
		/// </summary>
		public int? depth { get; set; }

		/// <summary>
		/// + / -
		/// </summary>
		public string factor { get; set; }
	}
}