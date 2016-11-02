using System;

namespace iayos.intrinioapi.ServiceModel.Dto
{
	public class HistoricalDataDto
	{
		/// <summary>
		/// the date associated with the value of the data tag
		/// </summary>
		public DateTime date { get; set; }

		/// <summary>
		/// the value of the Intrinio tag of the financial data point
		/// </summary>
		public object value { get; set; }

	}
}