namespace iayos.intrinioapi.servicemodel.dto
{

	/// <summary>
	/// http://docs.intrinio.com/#index-master
	/// </summary>
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
 