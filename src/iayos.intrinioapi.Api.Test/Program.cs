using System.Collections.Generic;
using iayos.intrinioapi.servicemodel.flag;
using iayos.intrinioapi.servicemodel.message.Messages;
using ServiceStack;
using ServiceStack.Configuration;
using Xunit;

namespace iayos.intrinioapi.Api.Test
{
	class Program
	{
		private static IntrinioApiTests tests;

		static void Main(string[] args)
		{
			tests = new IntrinioApiTests();
		}
	}




	public class IntrinioApiTests
	{
		public IntrinioClient ApiClient { get; }


		public IntrinioApiTests()
		{
			var username = ConfigUtils.GetAppSetting("intrinio:username");
			var password = ConfigUtils.GetAppSetting("intrinio:password"); ;

			ApiClient = new IntrinioClient(username, password);
		}


		[Fact]
		public void CanQueryMasterDataListForCompanies()
		{
			// Currently working
			var getCompaniesResponse = ApiClient.GetMasterCompaniesList(new GetCompaniesMasterList { });
		}


		[Fact]
		public void CanQueryMasterDataListForSecurities()
		{
			// Currently failing because empty parameter values cause internal server error
			var getSecuritiesResponse = ApiClient.GetMasterSecuritiesList(new GetSecuritiesMasterList { });
		}


		[Fact]
		public void CanQueryMasterDataListForIndices()
		{
			// Currently working
			var getIndicesResponse = ApiClient.GetMasterIndicesList(new GetIndicesMasterList { });
		}


		[Fact]
		public void CanQueryMasterDataListForOwners()
		{
			// Currently failing with error about insufficient permissions
			var getOwnerResponse = ApiClient.GetMasterOwnersList(new GetOwnersMasterList { });
		}


		[Fact]
		public void CanGetCompanyDetails()
		{
			var request = new GetCompanyDetails
			{

			};
			var response = ApiClient.GetCompanyDetails(request);
		}


		[Fact]
		public void CanGetSecurityDetails()
		{
			var request = new GetSecurityDetails
			{

			};
			var response = ApiClient.GetSecurityDetails(request);
		}

		[Fact]
		public void CanGetIndexDetails()
		{
			var request = new GetIndexDetails { identifier = "$TA100", type = IndexType.stock_market };
			//var request = new GetIndexDetails {identifier = "$SPX" };
			//var request = new GetIndexDetails {};
			var tet = request.ToGetUrl();
			var response = ApiClient.GetIndexDetails(request);
	}


		[Fact]
		public void CanSearchSecuritiesWithConditions()
		{
			var request = new SearchSecurities
			{
				page_size = 10,
				Conditions_IaYoS = new List<SecuritiesSearchCondition>
				{
					new SecuritiesSearchCondition {Operator = SearchOperator.gt, Tag = DataPointTag.open_price, Value = 10.5},
					new SecuritiesSearchCondition {Operator = SearchOperator.gt, Tag = DataPointTag.pricetoearnings, Value = 10}
				}
			};
			var companyDetails = ApiClient.SearchSecurities(request);
			//var requestUrlToTest = request.ToGetUrl();
		}


		[Fact]
		public void CanSearchDataPoints()
		{
			var request = new SearchDataPoints { };
			//request.Identifers.Add("AAC");
			//request.Tags.Add(DataPointTag.price_time);
			//request.Tags.Add(DataPointTag.price_date);
			request.Tags_IaYoS.Add(DataPointTag.pricetoearnings);
			request.Identifers_IaYoS.Add("AAPL");
			var datapointResponse = ApiClient.SearchDataPoints(request);
		}


		[Fact]
		public void CanSearchHistoricalData()
		{
			var request = new SearchHistoricalData { };
			var response = ApiClient.SearchHistoricalData(request);
		}


		[Fact]
		public void CanGetPrices()
		{
			var request = new GetPrices { identifier = "AAPL" };
			var response = ApiClient.GetPrices(request);
		}


		[Fact]
		public void CanGetCompanySecFilings()
		{
			var request = new GetCompanySecFilings { identifier = "AAPL" };
			var response = ApiClient.GetCompanySecFilings(request);
		}


		[Fact]
		public void CanGetCompanyNews()
		{
			var request = new GetCompanyNews { identifier = "AAPL" };
			var response = ApiClient.GetCompanyNews(request);
		}


		[Fact]
		public void CanGetStandardizedFundamentals()
		{
			var request = new GetStandardizedFundamentals { identifier = "AAPL" };
			var response = ApiClient.GetStandardizedFundamentals(request);
		}


		[Fact]
		public void CanGetStandardizedTags()
		{
			var request = new GetStandardizedTags { identifier = "AAPL" };
			var response = ApiClient.GetStandardizedTags(request);
		}


		[Fact]
		public void CanGetStandardizedFinancials()
		{
			var request = new GetStandardizedFinancials { identifier = "AAPL" };
			var response = ApiClient.GetStandardizedFinancials(request);
		}


		[Fact]
		public void CanGetAsReportedFundamentals()
		{
			var request = new GetAsReportedFundamentals { identifier = "AAPL" };
			var response = ApiClient.GetAsReportedFundamentals(request);
		}


		[Fact]
		public void CanGetAsReportedXbrlTags()
		{
			var request = new GetAsReportedXbrlTags { identifier = "AAPL" };
			var response = ApiClient.GetAsReportedXbrlTags(request);
		}


		[Fact]
		public void CanGetAsReportedFinancials()
		{
			var request = new GetAsReportedFinancials { identifier = "AAPL" };
			var response = ApiClient.GetAsReportedFinancials(request);
		}



		#region Insider Transactions & Ownership Data

		[Fact]
		public void CanGetGetInsiderOwners()
		{
			var request = new GetInsiderOwners { institutional = false };
			var response = ApiClient.GetInsiderOwners(request);
		}


		[Fact]
		public void CanGetCompanyInsiderTransactions()
		{
			var request = new GetCompanyInsiderTransactions { identifier = "AAPL" };
			var response = ApiClient.GetCompanyInsiderTransactions(request);
		}


		[Fact]
		public void CanGetCompanyInsiderOwnership()
		{
			var request = new GetCompanyInsiderOwnership { identifier = "AAPL" };
			var response = ApiClient.GetCompanyInsiderOwnership(request);
		}


		[Fact]
		public void CanGetOwnerInsiderTransactions()
		{
			var request = new GetOwnerInsiderTransactions { cik = "0001494730" };
			var response = ApiClient.GetOwnerInsiderTransactions(request);
		}


		[Fact]
		public void CanGetOwnerInsiderHoldings()
		{
			var request = new GetOwnerInsiderHoldings { cik = "0001494730" };
			var response = ApiClient.GetOwnerInsiderHoldings(request);
		}


		[Fact]
		public void CanGetInstitutionalOwners()
		{
			var request = new GetInstitutionalOwners { cik = "0001494730" };
			var response = ApiClient.GetInstitutionalOwners(request);
		}


		[Fact]
		public void CanGetOwnerInstitutionalHoldings()
		{
			var request = new GetOwnerInstitutionalHoldings { cik = "0001494730" };
			var response = ApiClient.GetOwnerInstitutionalHoldings(request);
		}


		[Fact]
		public void CanGetSecurityInstitutionalOwners()
		{
			var request = new GetSecurityInstitutionalOwners { identifier = "AAPL" };
			var response = ApiClient.GetSecurityInstitutionalOwners(request);
		}

		#endregion

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
