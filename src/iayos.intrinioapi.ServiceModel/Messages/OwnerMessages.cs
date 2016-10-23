using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dtos;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{

	[Route("/owners", HttpMethods.Get)]
	public class GetMasterOwnersList : Request, IReturn<GetOwnersResponse>
	{
	}

	public class GetOwnersResponse : Response<List<OwnerMasterDto>>
	{
	}

}
