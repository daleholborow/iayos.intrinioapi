using System;
using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Enums;
using iayos.intrinioapi.ServiceModel.Messages;
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
		public void CanQueryMasterDataListForCompanies()
		{
			// Currently working
			var getCompaniesResponse = _client.GetMasterCompaniesList(new GetCompaniesMasterList { });
		}


		[Fact]
		public void CanQueryMasterDataListForSecurities()
		{
			// Currently failing because empty parameter values cause internal server error
			var getSecuritiesResponse = _client.GetMasterSecuritiesList(new GetSecuritiesMasterList { });
		}


		[Fact]
		public void CanQueryMasterDataListForIndices()
		{
			// Currently working
			var getIndicesResponse = _client.GetMasterIndicesList(new GetIndicesMasterList { });
		}


		[Fact]
		public void CanQueryMasterDataListForOwners()
		{
			// Currently failing with error about insufficient permissions
			var getOwnerResponse = _client.GetMasterOwnersList(new GetOwnersMasterList { });
		}


		[Fact]
		public void CanGetCompanyDetails()
		{
			var request = new GetCompanyDetails
			{

			};
			var response = _client.GetCompanyDetails(request);
		}


		[Fact]
		public void CanGetSecurityDetails()
		{
			var request = new GetSecurityDetails
			{

			};
			var response = _client.GetSecurityDetails(request);
		}

		[Fact]
		public void CanGetIndexDetails()
		{
			var request = new GetIndexDetails
			{

			};
			var response = _client.GetIndexDetails(request);
		}


		[Fact]
		public void CanSearchSecuritiesWithConditions()
		{
			var request = new SearchSecurities
			{
				page_size = 1,
				Conditions_IaYoS = new List<SecuritiesSearchCondition>
				{
					new SecuritiesSearchCondition {Operator = SearchOperator.gt, Tag = DataPointTag.accruedexpenses, Value = 0.01}
				}
			};
			var companyDetails = _client.SearchSecurities(request);
		}


		[Fact]
		public void CanSearchDataPoints()
		{
			var request = new SearchDataPoints { };
			request.Identifers.Add("AAPL");
			request.Tags.Add(DataPointTag.accruedexpenses);
			request.Tags.Add(DataPointTag.acquisitions);
			var datapointResponse = _client.SearchDataPoints(request);
		}


		[Fact]
		public void CanSearchHistoricalData()
		{
			var request = new SearchHistoricalData { };
			var response = _client.SearchHistoricalData(request);
		}


		[Fact]
		public void CanGetPrices()
		{
			var request = new GetPrices { identifier = "AAPL" };
			var response = _client.GetPrices(request);
		}


		[Fact]
		public void CanGetCompanySecFilings()
		{
			var request = new GetCompanySecFilings { identifier = "AAPL" };
			var response = _client.GetCompanySecFilings(request);
		}


		[Fact]
		public void CanGetCompanyNews()
		{
			//var request = new GetCom { identifier = "AAPL" };
			var response = _client.GetCompanyNews(new object());
		}


		[Fact]
		public void CanGetStandardizedFundamentals()
		{
			var request = new GetStandardizedFundamentals { identifier = "AAPL" };
			var response = _client.GetStandardizedFundamentals(request);
		}


		[Fact]
		public void CanGetStandardizedTags()
		{
			var request = new GetStandardizedTags { identifier = "AAPL" };
			var response = _client.GetStandardizedTags(request);
		}


		[Fact]
		public void CanGetStandardizedFinancials()
		{
			var request = new GetStandardizedFinancials { identifier = "AAPL" };
			var response = _client.GetStandardizedFinancials(request);
		}


		[Fact]
		public void CanGetAsReportedFundamentals()
		{
			var request = new GetAsReportedFundamentals { identifier = "AAPL" };
			var response = _client.GetAsReportedFundamentals(request);
		}


		[Fact]
		public void CanGetAsReportedTags()
		{
			var request = new GetAsReportedTags { identifier = "AAPL" };
			var response = _client.GetAsReportedTags(request);
		}


		[Fact]
		public void CanGetAsReportedFinancials()
		{
			var request = new GetAsReportedFinancials { identifier = "AAPL" };
			var response = _client.GetAsReportedFinancials(request);
		}


		//[Fact]
		//public void DoSomeStuff()
		//{
		//	try
		//	{
		//	}
		//	catch (WebServiceException webEx)
		//	{
		//		// TODO Inspect the webEx to see what went wrong:
		//		var errorMessage = webEx.ErrorMessage;
		//		/*
		//		 * Example error response:
		//		  webEx.StatusCode        = 400
		//		  webEx.StatusDescription = ArgumentNullException
		//		  webEx.ErrorCode         = ArgumentNullException
		//		  webEx.ErrorMessage      = Value cannot be null. Parameter name: Name
		//		  webEx.StackTrace        = (your Server Exception StackTrace - in DebugMode)
		//		  webEx.ResponseDto       = (your populated Response DTO)
		//		  webEx.ResponseStatus    = (your populated Response Status DTO)
		//		  webEx.GetFieldErrors()  = (individual errors for each field if any)
		//		*/
		//	}
		//}

	}
}
