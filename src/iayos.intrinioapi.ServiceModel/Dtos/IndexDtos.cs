using iayos.intrinioapi.ServiceModel.Enums;
using iayos.intrinioapi.ServiceModel.Messages;

namespace iayos.intrinioapi.ServiceModel.Dtos
{
	public class IndexListDto
	{
		/// <summary>
		/// the Intrinio symbol associated with the index
		/// </summary>
		public string symbol { get; set; }

		/// <summary>
		/// the index name
		/// </summary>
		public string index_name { get; set; }

		/// <summary>
		/// the continent of the country of focus for the index
		/// </summary>
		public string continent { get; set; }

		/// <summary>
		/// the country of focus for the index
		/// </summary>
		public string country { get; set; }

		/// <summary>
		///  the index type, either stock_market, economic or sector
		/// </summary>
		public IndexType index_type { get; set; } = IndexType.full;

	}


	public class IndexMasterDto
	{
		/// <summary>
		/// the Intrinio symbol associated with the index
		/// </summary>
		public string symbol { get; set; }

		/// <summary>
		/// the index name
		/// </summary>
		public string index_name { get; set; }
	}
}
 