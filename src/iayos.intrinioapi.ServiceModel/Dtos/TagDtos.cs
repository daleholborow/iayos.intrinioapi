using iayos.intrinioapi.ServiceModel.Enums;

namespace iayos.intrinioapi.ServiceModel.Dtos
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values90
	/// </summary>
	public class StandardizedTagDto
	{
		/// <summary>
		/// the readable name of the tag
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// the Intrinio standardized tag
		/// </summary>
		public DataPointTag tag { get; set; }

		/// <summary>
		///  the parent Intrinio standardized tag forming the statement relationship with the factor.
		/// </summary>
		public DataPointTag parent { get; set; }

		/// <summary>
		///  the operator forming the statement relationship between the child tag (or tags) and the parent.
		/// </summary>
		public string factor { get; set; }

		/// <summary>
		/// the accounting balance (debit or credit) of the tag
		/// </summary>
		public string balance { get; set; }

		/// <summary>
		/// the nature of the tag, operating or nonoperating
		/// </summary>
		public string type { get; set; }

		/// <summary>
		///  the unit of the tag
		/// </summary>
		public string units { get; set; }
	}


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
		public object domain_tag { get; set; }

		/// <summary>
		/// the type of value - true indicates that the value is a header label and has no associated data value, whereas false indicates that the XBRL tag has an associated value.
		/// </summary>
		public bool @abstract { get; set; }

		/// <summary>
		/// an integer 0 or greater indicating the presentation order of the XBRL tag and label in the financial statement
		/// </summary>
		public int sequence { get; set; }

		/// <summary>
		/// an integer 0 or greater indicating the presentation indentation depth of the XBRL tag and label in the financial statement
		/// </summary>
		public int depth { get; set; }

		/// <summary>
		/// + / -
		/// </summary>
		public string factor { get; set; }
	}
}
