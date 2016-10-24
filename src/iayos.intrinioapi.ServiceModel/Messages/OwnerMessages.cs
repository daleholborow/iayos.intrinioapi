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

}
