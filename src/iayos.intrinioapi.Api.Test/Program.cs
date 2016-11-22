using System;
using System.Collections.Generic;
using System.Linq;
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

		#region Master Data queries

		[Fact]
		public void CanQueryMasterDataListForCompanies()
		{
			// Currently working
			var response = ApiClient.GetMasterCompaniesList(new GetCompaniesMasterList { });
			Assert.True(response.data.Count > 0);
		}


		[Fact]
		public void CanQueryMasterDataListForSecurities()
		{
			// Currently failing because empty parameter values cause internal server error
			var response = ApiClient.GetMasterSecuritiesList(new GetSecuritiesMasterList { });
			Assert.True(response.data.Count > 0);
		}


		[Fact]
		public void CanQueryMasterDataListForIndices()
		{
			// Currently working
			var response = ApiClient.GetMasterIndicesList(new GetIndicesMasterList { });
			Assert.True(response.data.Count > 0);
		}


		[Fact]
		public void CanQueryMasterDataListForOwners()
		{
			// Currently failing with error about insufficient permissions
			var response = ApiClient.GetMasterOwnersList(new GetOwnersMasterList { });
			Assert.True(response.data.Count > 0);
		}

		#endregion


		/// <summary>
		/// Can get single company by its unique ticker or cik or query 
		/// </summary>
		[Theory]
		[InlineData("thereisnowaythistickerexists", null, false)]
		[InlineData(null, "thereisnowaythiscikexists", false)]
		[InlineData("AA", null, true)]
		[InlineData(null, "0000004281", true)]
		public void CanGetSingleCompanyDetails(string ticker, string cik, bool expectResults)
		{
			var request = new GetSingleCompanyDetails { identifier = ticker, cik = cik };
			//var requestUrl = request.ToGetUrl();
			var response = ApiClient.GetSingleCompanyDetails(request);
			Assert.True((response == null) == !expectResults);
			if (expectResults) Assert.True(response?.ticker == request.identifier || ticker.IsNullOrEmpty());
			if (expectResults) Assert.True(response?.cik == request.cik || cik.IsNullOrEmpty());
		}


		/// <summary>
		/// Can load all companies that match some conditions in the query
		/// </summary>
		[Theory]
		[InlineData(null, true)]
		[InlineData("thereisnowaythiscompanyexists", false)]
		public void CanGetMultipleCompanyDetails(string searchQuery, bool expectResults)
		{
			var request = new GetCompaniesDetails { query = searchQuery };
			var response = ApiClient.GetCompanyDetails(request);
			Assert.True(response.data.Count > 0 == expectResults);
		}

		
		/// <summary>
		/// Can get a collection of security by stock unique ticker or cik or query 
		/// </summary>
		[Theory]
		[InlineData("thereisnowaythistickerexists", false)]
		[InlineData("AA", true)]
		public void CanGetSecurityDetailsByTicker(string ticker, bool expectResults)
		{
			var request = new GetSecuritiesDetailsByCompany { identifier = ticker };
			var requestUrl = request.ToGetUrl();
			var response = ApiClient.GetSecuritiesDetailsByCompany(request);
			Assert.True((response.data.IsNullOrEmpty()) == !expectResults);
			if (!expectResults) return;
			foreach (var security in response.data)
			{
				Assert.True(security.ticker == request.identifier || ticker.IsNullOrEmpty());
			}
		}


		/// <summary>
		/// Can load all securities that match query conditions
		/// </summary>
		[Theory]
		[InlineData(null, true)]
		[InlineData("AA", true)]
		[InlineData("thereisnowaythissecurityexists", false)]
		public void CanGetMultipleSecurityDetailsForMultipleCompanies(string searchQuery, bool expectResults)
		{
			var request = new GetSecurityDetails { query = searchQuery };
			var requestUrl = request.ToGetUrl();

			var response = ApiClient.GetSecuritiesDetails(request);
			Assert.True((response.data.IsNullOrEmpty()) == !expectResults);
			if (!expectResults) return;
			foreach (var security in response.data)
			{
				if (searchQuery.IsNullOrEmpty()) continue;
				Assert.True(security.ticker.Contains(request.query)); 
			}
		}

		
		/// <summary>
		/// Can get single index by its unique Intrinio code
		/// </summary>
		[Fact]
		public void CanGetSingleIndexDetails()
		{
			var request = new GetSingleIndexDetails { identifier = "$TA100" };
			var requestUrl = request.ToGetUrl();
			var response = ApiClient.GetSingleIndexDetails(request);
			Assert.True(response != null);
			Assert.True(response.symbol == request.identifier);
		}


		/// <summary>
		/// Test that we can get back a COLLECTION of indices
		/// </summary>
		[Fact]
		public void CanGetIndexDetails()
		{
			var request = new GetIndicesDetails { type = IndexType.stock_market };
			var response = ApiClient.GetIndicesDetails(request);
			Assert.False(response.IsErrorResponse());
			Assert.True(response.data.Count > 0);
		}


		/// <summary>
		/// http://docs.intrinio.com/#return-values62
		/// Search a filtered list of the securities based on search conditions
		/// </summary>
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
			var response = ApiClient.SearchSecurities(request);
			Assert.True(response != null);
			Assert.True(response.data.Count > 0);
		}


		/// <summary>
		/// http://docs.intrinio.com/#data-point
		/// Search for a single data point. If rubbish ticker put in, NOT MEANINGFUL (NM) returned!!
		/// </summary>
		[Theory]
		[InlineData("GOOGL", DataPointTag.price_date, true)]
		[InlineData("thisidentifierwillneverexist", DataPointTag.price_date, false)]
		public void CanGetSingleDataPoint(string identifier, DataPointTag item, bool expectResults)
		{
			var request = new GetSingleDataPoint { identifier = identifier, item = item };
			var requestUrl = request.ToGetUrl();
			var response = ApiClient.GetSingleDataPoint(request);
			
			if (expectResults == false) Assert.True(response.value.ToString() == IntrinioInternalFlags.na.ToString());
			//Assert.True((response == null) == !expectResults);
			if (expectResults == true) Assert.True(response.identifier == request.identifier);
			if (expectResults == true) Assert.True(response.item == request.item);
		}


		/// <summary>
		/// http://docs.intrinio.com/#data-point
		/// Search for a collection of data points
		/// </summary>
		[Fact]
		public void CanGetMultipleDataPoints()
		{
			var request = new GetMultipleDataPoints { };
			request.Tags_IaYoS.Add(DataPointTag.price_date);
			request.Tags_IaYoS.Add(DataPointTag.pricetoearnings);
			request.Identifers_IaYoS.Add("AAPL");
			request.Identifers_IaYoS.Add("GOOGL");
			var response = ApiClient.GetMultipleDataPoints(request);
			Assert.True(response != null);
			Assert.True(response.data.Count == 4);
			Assert.True(response.data.SingleOrDefault(d => d.identifier == "AAPL" && d.item == DataPointTag.price_date) != null);
			Assert.True(response.data.SingleOrDefault(d => d.identifier == "AAPL" && d.item == DataPointTag.pricetoearnings) != null);
			Assert.True(response.data.SingleOrDefault(d => d.identifier == "GOOGL" && d.item == DataPointTag.price_date) != null);
			Assert.True(response.data.SingleOrDefault(d => d.identifier == "GOOGL" && d.item == DataPointTag.pricetoearnings) != null);
		}


		[Fact]
		public void CanSearchHistoricalData()
		{
			var request = new SearchHistoricalData { };
			request.identifier = "AAPL";
			request.item = DataPointTag.accruedexpenses;
			//request.type = HistoricalDataType.QTR;
			var requestUrl = request.ToGetUrl();
			var response = ApiClient.SearchHistoricalData(request);
			Assert.True(response != null);
			Assert.True(response.identifier == request.identifier);
			Assert.True(response.data.Count > 0);
			Assert.True(response != null);
		}


		[Fact]
		public void CanGetPrices()
		{
			var request = new GetPrices { identifier = "AAPL", StartDate_IaYoS = new DateTime(1999, 12, 31) };
			Assert.True(request.start_date == "1999-12-31");
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


	}
}
