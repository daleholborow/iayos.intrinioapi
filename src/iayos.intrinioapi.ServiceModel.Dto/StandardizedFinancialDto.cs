using iayos.intrinioapi.servicemodel.flag;

namespace iayos.intrinioapi.servicemodel.dto
{
	/// <summary>
	/// http://docs.intrinio.com/#return-values104
	/// </summary>
	public class StandardizedFinancialDto
	{
		/// <summary>
		/// the Intrinio standardized tag of the financial data point
		/// </summary>
		public DataPointTag tag { get; set; } = DataPointTag.IaYoS_Warning_Unset;


		/// <summary>
		///  the value of the Intrinio tag of the financial data point
		/// </summary>
		public double? value { get; set; }
	}
}