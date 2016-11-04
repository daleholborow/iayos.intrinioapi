using iayos.intrinioapi.servicemodel.dto;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{

	/// <summary>
	/// http://docs.intrinio.com/#owner-master
	/// </summary>
	[Route("/owners", HttpMethods.Get)]
	public class GetOwnersMasterList : RequestList, IReturn<GetOwnersMasterListResponse>
	{
	}

	public class GetOwnersMasterListResponse : ResponseMetaList<OwnerMasterDto>
	{
	}


	[Route("/owners", HttpMethods.Get)]
	public class GetInsiderOwners : RequestList, IReturn<GetInsiderOwnersResponse>
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

	public class GetInsiderOwnersResponse : ResponseMetaList<OwnerDetailsDto> { }


	/// <summary>
	/// http://docs.intrinio.com/#insider-transactions-by-company
	/// </summary>
	[Route("/companies/insider_transactions", HttpMethods.Get)]
	public class GetCompanyInsiderTransactions : RequestList, IReturn<GetCompanyInsiderTransactionsResponse>
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

	public class GetCompanyInsiderTransactionsResponse : ResponseMetaList<CompanyInsiderTransactionDto> {}


	/// <summary>
	/// </summary>
	[Route("/companies/insider_ownership", HttpMethods.Get)]
	public class GetCompanyInsiderOwnership: RequestList, IReturn<GetCompanyInsiderOwnershipResponse>
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

	public class GetCompanyInsiderOwnershipResponse : ResponseMetaList<InsiderOwnerDto> { }


	/// <summary>
	/// http://docs.intrinio.com/#insider-transactions-by-owner
	/// </summary>
	[Route("/owners/insider_transactions", HttpMethods.Get)]
	public class GetOwnerInsiderTransactions : RequestList, IReturn<GetOwnerInsiderTransactionsResponse>
	{
		/// <summary>
		///  the Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }
	}

	public class GetOwnerInsiderTransactionsResponse : ResponseMetaList<OwnerInsiderTransactionDto> {}


	/// <summary>
	/// http://docs.intrinio.com/#parameters139
	/// </summary>
	[Route("/owners/insider_holdings", HttpMethods.Get)]
	public class GetOwnerInsiderHoldings : RequestList, IReturn<GetOwnerInsiderHoldingsResponse>
	{
		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string cik { get; set; }
	}

	public class GetOwnerInsiderHoldingsResponse : ResponseMetaList<InsiderHoldingDto> {}


	/// <summary>
	/// http://docs.intrinio.com/#owners142
	/// </summary>
	[Route("/owners", HttpMethods.Get)]
	public class GetInstitutionalOwners : RequestList, IReturn<GetInstitutionalOwnersResponse>
	{

		/// <summary>
		/// (optional, returns full list of owners with compacted response values, if no identifier specified) - the Central 
		/// Index Key issued by the SEC, which is the unique identifier all owner filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }


		/// <summary>
		/// (true) - a boolean to include only institutional owners who file 13-F with the SEC
		/// </summary>
		public bool institutional => true;


		/// <summary>
		/// (optional, returns full list of owners with compacted response values, if no query specified) - a string query search 
		/// of owner name or cik id with the returned results being the relevant owners in compacted list format.
		/// </summary>
		public string query { get; set; }
	}

	public class GetInstitutionalOwnersResponse : ResponseMetaList<OwnerDetailsDto> { }




	/// <summary>
	/// http://docs.intrinio.com/#owners142
	/// </summary>
	[Route("/owners", HttpMethods.Get)]
	public class GetOwnerInstitutionalHoldings : RequestList, IReturn<GetOwnerInstitutionalHoldingsResponse>
	{

		/// <summary>
		///  (optional, must have owner cik otherwise) - the stock market ticker symbol associated with the institutional 
		/// owner’s common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }


		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier for the institutional owner: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }
		
	}

	public class GetOwnerInstitutionalHoldingsResponse : ResponseMetaList<OwnerInstitutionalHoldingDto> {}
}
