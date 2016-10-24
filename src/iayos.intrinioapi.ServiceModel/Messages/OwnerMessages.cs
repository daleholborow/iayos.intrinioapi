using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dtos;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{

	[Route("/owners", HttpMethods.Get)]
	public class GetOwnersMasterList : Request, IReturn<GetOwnersMasterListResponse>
	{
	}

	public class GetOwnersMasterListResponse : Response<List<OwnerMasterDto>>
	{
	}


	[Route("/owners", HttpMethods.Get)]
	public class GetInsiderOwners : Request, IReturn<GetInsiderOwnersResponse>
	{

		/// <summary>
		/// (optional, returns full list of owners with compacted response values, if no identifier specified) - the Central 
		/// Index Key issued by the SEC, which is the unique identifier all owner filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }


		/// <summary>
		/// (optional, returns all owners otherwise) - (false) - a boolean to include only insider owners who have filed forms 3, 4, or 5 with the SEC
		/// </summary>
		public bool? institutional { get; set; }


		/// <summary>
		/// (optional, returns full list of owners with compacted response values, if no query specified) - a string query search 
		/// of owner name or cik id with the returned results being the relevant owners in compacted list format.
		/// </summary>
		public string query { get; set; }
	}

	public class GetInsiderOwnersResponse : Response<List<OwnerDetailsDto>> { }


	/// <summary>
	/// http://docs.intrinio.com/#insider-transactions-by-company
	/// </summary>
	[Route("/companies/insider_transactions", HttpMethods.Get)]
	public class GetInsiderTransactions : Request, IReturn<GetInsiderTransactionsResponse>
	{
		/// <summary>
		/// ( (optional, must have company cik otherwise) - the stock market ticker symbol associated with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/// <summary>
		/// (optional, must have a ticker symbol otherwise) - the Central Index Key issued by the SEC, which is the unique identifier all company filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }

	}

	public class GetInsiderTransactionsResponse : Response<List<TransactionDto>> {}
}
