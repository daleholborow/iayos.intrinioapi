namespace iayos.intrinioapi.servicemodel.dto
{

	/// <summary>
	/// http://docs.intrinio.com/#data-point
	/// </summary>
	public class DataPointDto
	{
		/// <summary>
		/// the ticker or identifier for the data point
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// the requested standardized tag or series ID
		/// </summary>
		public string item { get; set; }

		/// <summary>
		/// the value of the Intrinio tag of the financial data point
		/// </summary>
		public object value { get; set; } 
	}
}