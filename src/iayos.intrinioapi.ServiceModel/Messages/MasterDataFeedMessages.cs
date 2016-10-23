using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dtos;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{


	[Route("/companies", HttpMethods.Get)]
	public class GetCompanies : Request, IReturn<GetCompaniesResponse>
	{
		
	}

	public class GetCompaniesResponse : Response<List<CompanyMasterDto>>
	{
	}


	[Route("/securities", HttpMethods.Get)]
	public class GetSecurities : Request, IReturn<GetSecuritiesResponse>
	{
		
	}

	public class GetSecuritiesResponse : Response<List<SecurityMasterDto>>
	{
	}


	public enum IndexType
	{
		full,       // returns full list by default
		stock_market,
		economic,
		sic
	}


	[Route("/indices", HttpMethods.Get)]
	public class GetIndices : Request, IReturn<GetIndicesResponse>
	{
		public IndexType type { get; set; } = IndexType.full;
	}

	public class GetIndicesResponse : Response<List<IndiceMasterDto>>
	{
	}


	[Route("/owners", HttpMethods.Get)]
	public class GetOwners : Request, IReturn<GetOwnersResponse>
	{
	}

	public class GetOwnersResponse : Response<List<OwnerMasterDto>>
	{
	}

	
}
