using iayos.intrinioapi.servicemodel.dto;
using ServiceStack;

namespace iayos.intrinioapi.servicemodel.message.Messages
{

	[Route("/owners", HttpMethods.Get)]
	public class GetOwnersMasterList : RequestMany, IReturn<GetOwnersMasterListResponse>
	{
	}

	public class GetOwnersMasterListResponse : ResponseMany<OwnerMasterDto>
	{
	}


	[Route("/owners", HttpMethods.Get)]
	public class GetInsiderOwners : RequestMany, IReturn<GetInsiderOwnersResponse>
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

	public class GetInsiderOwnersResponse : ResponseMany<OwnerDetailsDto> { }


	/// <summary>
	/// http://docs.intrinio.com/#insider-transactions-by-company
	/// </summary>
	[Route("/companies/insider_transactions", HttpMethods.Get)]
	public class GetCompanyInsiderTransactions : RequestMany, IReturn<GetCompanyInsiderTransactionsResponse>
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

	public class GetCompanyInsiderTransactionsResponse : ResponseMany<CompanyInsiderTransactionDto> {}


	/// <summary>
	/// </summary>
	[Route("/companies/insider_ownership", HttpMethods.Get)]
	public class GetCompanyInsiderOwnership: RequestMany, IReturn<GetCompanyInsiderOwnershipResponse>
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

	public class GetCompanyInsiderOwnershipResponse : ResponseMany<InsiderOwnerDto> { }


	/// <summary>
	/// http://docs.intrinio.com/#insider-transactions-by-owner
	/// </summary>
	[Route("/owners/insider_transactions", HttpMethods.Get)]
	public class GetOwnerInsiderTransactions : RequestMany, IReturn<GetOwnerInsiderTransactionsResponse>
	{
		/// <summary>
		///  the Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under: CENTRAL INDEX KEY
		/// </summary>
		public string cik { get; set; }
	}

	public class GetOwnerInsiderTransactionsResponse : ResponseMany<OwnerInsiderTransactionDto> {}


	/// <summary>
	/// http://docs.intrinio.com/#parameters139
	/// </summary>
	[Route("/owners/insider_holdings", HttpMethods.Get)]
	public class GetOwnerInsiderHoldings : RequestMany, IReturn<GetOwnerInsiderHoldingsResponse>
	{
		/// <summary>
		/// the Central Index Key issued by the SEC, which is the unique identifier all owner filings
		/// </summary>
		public string cik { get; set; }
	}

	public class GetOwnerInsiderHoldingsResponse : ResponseMany<InsiderHoldingDto> {}


	/// <summary>
	/// http://docs.intrinio.com/#owners142
	/// </summary>
	[Route("/owners", HttpMethods.Get)]
	public class GetInstitutionalOwners : RequestMany, IReturn<GetInstitutionalOwnersResponse>
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

	public class GetInstitutionalOwnersResponse : ResponseMany<OwnerDetailsDto> { }




	/// <summary>
	/// http://docs.intrinio.com/#owners142
	/// </summary>
	[Route("/owners", HttpMethods.Get)]
	public class GetOwnerInstitutionalHoldings : RequestMany, IReturn<GetOwnerInstitutionalHoldingsResponse>
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

	public class GetOwnerInstitutionalHoldingsResponse : ResponseMany<OwnerInstitutionalHoldingDto> {}
}
