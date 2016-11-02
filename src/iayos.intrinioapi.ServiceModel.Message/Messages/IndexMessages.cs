using System.Collections.Generic;
using iayos.intrinioapi.servicemodel.dto;
using iayos.intrinioapi.servicemodel.@enum;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{


	[Route("/indices", HttpMethods.Get)]
	public class GetIndicesMasterList : Request, IReturn<GetIndicesMasterListResponse>
	{
		/// <summary>
		/// (optional, returns full list of indices otherwise) - the type of indices specified: stock_market
		/// </summary>
		public IndexType type { get; set; } = IndexType.full;
	}

	public class GetIndicesMasterListResponse : Response<List<IndexMasterDto>>
	{
	}


	[Route("/indices", HttpMethods.Get)]
	public class GetIndexDetails : Request, IReturn<GetIndexDetailsResponse>
	{
		/// <summary>
		/// (optional, returns full list of indices with compacted response values if no symbol or 
		/// identifier specified) - the Intrinio symbol associated with the index: STOCK MARKET INDICES
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// (optional, returns list of indices with compacted response values, if no query specified) - a 
		/// string query search of index name or symbol with the returned results being the relevant securities in compacted list format.
		/// </summary>
		public string query { get; set; }


		/// <summary>
		/// (optional, returns full list of indices otherwise) - the type of indices specified: stock_market
		/// </summary>
		public IndexType type { get; set; } = IndexType.full;
	}

	public class GetIndexDetailsResponse : Response<List<IndexDetailDto>>
	{
	}
}
