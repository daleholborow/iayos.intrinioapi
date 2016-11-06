using System;

namespace iayos.intrinioapi.servicemodel.dto
{

	/// <summary>
	/// http://docs.intrinio.com/#return-values71
	/// Stock price observation for a particular date
	/// </summary>
	public class PriceDto
	{
		public DateTime date { get; set; }
		public double? open { get; set; }
		public double? high { get; set; }
		public double? low { get; set; }
		public double? close { get; set; }
		public double? volume { get; set; }
		public double? ex_dividend { get; set; }
		public double? split_ratio { get; set; }
		public double? adj_open { get; set; }
		public double? adj_high { get; set; }
		public double? adj_low { get; set; }
		public double? adj_close { get; set; }
		public double? adj_volume { get; set; }
	}
}
