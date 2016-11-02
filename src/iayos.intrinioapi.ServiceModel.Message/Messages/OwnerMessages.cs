using System.Collections.Generic;
using iayos.intrinioapi.servicemodel.dto;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
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
	public class GetCompanyInsiderTransactions : Request, IReturn<GetCompanyInsiderTransactionsResponse>
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

	public class GetCompanyInsiderTransactionsResponse : Response<List<CompanyInsiderTransactionDto>> {}


	/// <summary>
	/// </summary>
	[Route("/companies/insider_ownership", HttpMethods.Get)]
	public class GetCompanyInsiderOwnership: Request, IReturn<GetCompanyInsiderOwnershipResponse>
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

	public class GetCompanyInsiderOwnershipResponse : Response<List<InsiderOwnerDto>> { }


	/// <summary>
	/// http://docs.intrinio.com/#insider-transactions-by-owner
	/// </summary>
	[Route("/owners/insider_transactions", HttpMethods.Get)]
	public class GetOwnerInsiderTransactions : Request, IReturn<GetOwnerInsiderTransactionsResponse>
	{
		/// <summary>
		///  the Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }
	}

	public class GetOwnerInsiderTransactionsResponse : Response<List<OwnerInsiderTransactionDto>> {}


	/// <summary>
	/// http://docs.intrinio.com/#parameters139
	/// </summary>
	public class GetOwnerInsiderHoldings : Request, IReturn<GetOwnerInsiderHoldingsResponse>
	{
		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string cik { get; set; }
	}

	public class GetOwnerInsiderHoldingsResponse : Response<List<InsiderHoldingDto>> {}


}
