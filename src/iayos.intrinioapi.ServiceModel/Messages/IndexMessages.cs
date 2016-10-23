using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dtos;
using iayos.intrinioapi.ServiceModel.Enums;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{


	[Route("/indices", HttpMethods.Get)]
	public class GetMasterIndicesList : Request, IReturn<GetIndicesResponse>
	{
		/// <summary>
		/// (optional, returns full list of indices with compacted response values if no symbol or 
		/// identifier specified) - the Intrinio symbol associated with the index: STOCK MARKET INDICES
		/// </summary>
		public string identifier { get; set;  }

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

	public class GetIndicesResponse : Response<List<IndexMasterDto>>
	{
	}


	
}
