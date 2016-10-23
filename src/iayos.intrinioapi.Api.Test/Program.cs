using iayos.intrinioapi.ServiceModel.Messages;
using ServiceStack;
using ServiceStack.Configuration;
using Xunit;

namespace iayos.intrinioapi.Api.Test
{
	class Program
	{
		static void Main(string[] args)
		{
		}
	}


	public class IntrinioApiTests
	{
		private readonly IntrinioClient _client;

		public IntrinioApiTests()
		{
			var username = ConfigUtils.GetAppSetting("intrinio:username");
			var password = ConfigUtils.GetAppSetting("intrinio:password"); ;

			_client = new IntrinioClient(username, password);
		}


		[Fact]
		public void DoSomeStuff()
		{

			try
			{
				// Currently working
				//var getCompaniesResponse = _client.GetCompanyMaster(new GetCompanies { });

				// Currently failing because empty parameter values cause internal server error
				//var getSecuritiesResponse = _client.GetSecuritiesMaster(new GetSecurities { });

				// Currently working
				//var getIndicesResponse = _client.GetIndicesMaster(new GetIndices { });

				// Currently failing with error about insufficient permissions
				//var getOwnerResponse = _client.GetOwnersMaster(new GetOwners { });
			}
			catch (WebServiceException webEx)
			{

				// TODO Inspect the webEx to see what went wrong:


				/*
				 * Example error response:
				  webEx.StatusCode        = 400
				  webEx.StatusDescription = ArgumentNullException
				  webEx.ErrorCode         = ArgumentNullException
				  webEx.ErrorMessage      = Value cannot be null. Parameter name: Name
				  webEx.StackTrace        = (your Server Exception StackTrace - in DebugMode)
				  webEx.ResponseDto       = (your populated Response DTO)
				  webEx.ResponseStatus    = (your populated Response Status DTO)
				  webEx.GetFieldErrors()  = (individual errors for each field if any)
				*/
			}

			
		}

	}
}
