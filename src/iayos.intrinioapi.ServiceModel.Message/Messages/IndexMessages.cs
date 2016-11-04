using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.flag;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{


	[Route("/indices", HttpMethods.Get)]
	public class GetIndicesMasterList : RequestList, IReturn<GetIndicesMasterListResponse>
	{
		///// <summary>
		///// (optional, returns full list of indices otherwise) - the type of indices specified: stock_market
		///// </summary>
		//public IndexType type { get; set; } = IndexType.full;
	}

	public class GetIndicesMasterListResponse : ResponseMetaList<IndexMasterDto>
	{
	}


	/// <summary>
	/// http://docs.intrinio.com/#indices54
	/// Returns a COLLECTION of indices that match the search string
	/// </summary>
	[Route("/indices", HttpMethods.Get)]
	public class GetIndicesDetails : RequestList, IReturn<GetIndicesDetailsResponse>
	{
		/// <summary>
		/// (optional, returns list of indices with compacted response values, if no query specified) - a 
		/// string query search of index name or symbol with the returned results being the relevant securities in compacted list format.
		/// </summary>
		public string query { get; set; }


		/// <summary>
		/// (optional, returns full list of indices otherwise) - the type of indices specified: stock_market
		/// </summary>
		public IndexType? type { get; set; } //= IndexType.full;
	}

	public class GetIndicesDetailsResponse : ResponseMetaList<IndexDetailDto>
	{
	}


	/// <summary>
	/// http://docs.intrinio.com/#indices54
	/// Get a SINGLE Index (MUST specify identifier)
	/// </summary>
	[Route("/indices", HttpMethods.Get)]
	public class GetSingleIndexDetails : IRequestSingle, IReturn<GetSingleIndexDetailsResponse>
	{
		/// <summary>
		/// The Intrinio symbol associated with the index: STOCK MARKET INDICES
		/// </summary>
		public string identifier { get; set; }
	}

	public class GetSingleIndexDetailsResponse : IndexDetailDto, IResponseSingle
	{
	}
	
}
