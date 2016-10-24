namespace iayos.intrinioapi.ServiceModel.Dtos
{

	/// <summary>
	/// http://docs.intrinio.com/#owner-master
	/// </summary>
	public class OwnerMasterDto
	{

		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string owner_cik { get; set; }


		/// <summary>
		/// the name of the owner, either an institutional owner or an insider owner
		/// </summary>
		public string owner_name { get; set; }
	}

}
