using System.Data;
using iayos.intrinioapi.ServiceModel.Enums;

namespace iayos.intrinioapi.ServiceModel.Dtos
{
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


	/// <summary>
	/// http://docs.intrinio.com/#return-values96
	/// </summary>
	public class FinancialDataPointDto
	{
		/// <summary>
		/// the Intrinio standardized tag of the financial data point
		/// </summary>
		public DataPointTag tag { get; set; }


		/// <summary>
		///  the value of the Intrinio tag of the financial data point
		/// </summary>
		public object value { get; set; }
	}
}