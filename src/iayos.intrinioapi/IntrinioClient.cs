using iayos.intrinioapi.servicemodel.message;
using iayos.intrinioapi.servicemodel.message.Messages;
using ServiceStack;

namespace iayos.intrinioapi
{

	/// <summary>
	/// Client to query Intrinio Financial Market Data Api (http://docs.intrinio.com/#introduction).
	/// Uses the ServiceStack IJsonServiceClient approach, and so errors will be bundled into WebServiceException s.
	/// </summary>
	public class IntrinioClient
	{

		private readonly string _apiBaseUrl = "https://api.intrinio.com";

		private readonly string _username;

		private readonly string _password;

		private readonly IJsonServiceClient _jsonClient;

		public IntrinioClient(string username, string password)
		{
			_username = username;
			_password = password;
			_jsonClient = new JsonServiceClient(_apiBaseUrl) {AlwaysSendBasicAuthHeader = true, UserName = _username, Password = _password};
		}



		#region Generic methods

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TRequest"></typeparam>
		/// <typeparam name="TResponse"></typeparam>
		/// <param name="request"></param>
		/// <exception cref="WebServiceException">
		///  Eg:
		///   webEx.StatusCode        = 400
		///	  webEx.StatusDescription = ArgumentNullException
		///	  webEx.ErrorCode         = ArgumentNullException
		///	  webEx.ErrorMessage      = Value cannot be null. Parameter name: Name
		///	  webEx.StackTrace        = (your Server Exception StackTrace - in DebugMode)
		///	  webEx.ResponseDto       = (your populated Response DTO)
		///	  webEx.ResponseStatus    = (your populated Response Status DTO)
		///	  webEx.GetFieldErrors()  = (individual errors for each field if any)</exception>
		/// <returns></returns>
		private TResponse BaseUrlGet<TRequest, TResponse>(TRequest request)
			where TRequest : Request
			where TResponse : new()
		{
			return _jsonClient.Get<TResponse>(request);
			//try
			//{
			//	return _jsonClient.Get<TResponse>(request);
			//}
			//catch (Exception e)
			//{
			//	// What was the request that was sent, so we can report this issue to Intrinio? Maybe use logging?
			//	var requestUrl = request.ToGetUrl();
			//	throw;
			//}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TRequest"></typeparam>
		/// <typeparam name="TResponse"></typeparam>
		/// <param name="request"></param>
		/// <exception cref="WebServiceException">
		///  Eg:
		///   webEx.StatusCode        = 400
		///	  webEx.StatusDescription = ArgumentNullException
		///	  webEx.ErrorCode         = ArgumentNullException
		///	  webEx.ErrorMessage      = Value cannot be null. Parameter name: Name
		///	  webEx.StackTrace        = (your Server Exception StackTrace - in DebugMode)
		///	  webEx.ResponseDto       = (your populated Response DTO)
		///	  webEx.ResponseStatus    = (your populated Response Status DTO)
		///	  webEx.GetFieldErrors()  = (individual errors for each field if any)</exception>
		/// <returns></returns>
		private TResponse BaseUrlPost<TRequest, TResponse>(TRequest request)
			where TRequest : Request
			where TResponse : new()
		{
			return _jsonClient.Post<TResponse>(request);
		}

		#endregion


		#region Master Data Feed

		/// <summary>
		/// http://docs.intrinio.com/#company-master
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetCompaniesMasterListResponse GetMasterCompaniesList(GetCompaniesMasterList request)
		{
			return BaseUrlGet<GetCompaniesMasterList, GetCompaniesMasterListResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#security-master
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetSecuritiesMasterListResponse GetMasterSecuritiesList(GetSecuritiesMasterList request)
		{
			return BaseUrlGet<GetSecuritiesMasterList, GetSecuritiesMasterListResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#index-master
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetIndicesMasterListResponse GetMasterIndicesList(GetIndicesMasterList request)
		{
			return BaseUrlGet<GetIndicesMasterList, GetIndicesMasterListResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#owner-master
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetOwnersMasterListResponse GetMasterOwnersList(GetOwnersMasterList request)
		{
			return BaseUrlGet<GetOwnersMasterList, GetOwnersMasterListResponse>(request);
		}

		#endregion


		#region U.S. Public Company Data Feed

		/// <summary>
		/// http://docs.intrinio.com/#companies
		/// Returns company list and information for all companies covered by Intrinio.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetCompanyDetailsResponse GetCompanyDetails(GetCompanyDetails request)
		{
			return BaseUrlGet<GetCompanyDetails, GetCompanyDetailsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#securities
		///Returns security list and information for all securities covered by Intrinio.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetSecurityDetailsResponse GetSecurityDetails(GetSecurityDetails request)
		{
			return BaseUrlGet<GetSecurityDetails, GetSecurityDetailsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#indices47
		/// Returns indices list and information for all indices covered by Intrinio.
		/// </summary>
		/// <param name="request"></param>
		public GetIndexDetailsResponse GetIndexDetails(GetIndexDetails request)
		{
			return BaseUrlGet<GetIndexDetails, GetIndexDetailsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#securities-search-screener
		/// Returns security list and information all securities that match the given conditions. The API call 
		/// credits required for each call is equal to the number of conditions specified.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public SearchSecuritiesResponse SearchSecurities(SearchSecurities request)
		{
			return BaseUrlGet<SearchSecurities, SearchSecuritiesResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#data-point
		/// Returns that most recent data point for a selected identifier (ticker symbol, stock market 
		/// index symbol, CIK ID, etc.) for a selected tag. The complete list of tags available through 
		/// this function are available here. Income statement, cash flow statement, and ratios are 
		/// returned as trailing twelve months values. All other data points are returned as their most 
		/// recent value, either as of the last release financial statement or the most recent reported value.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public SearchDataPointsResponse SearchDataPoints(SearchDataPoints request)
		{
			return BaseUrlGet<SearchDataPoints, SearchDataPointsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#historical-data
		/// Returns that historical data for for a selected identifier (ticker symbol or index symbol) 
		/// for a selected tag. The complete list of tags available through this function are available 
		/// here. Income statement, cash flow statement, and ratios are returned as trailing twelve months 
		/// values by default, but can be changed with the type parameter. All other historical data points 
		/// are returned as their value on a certain day based on filings reported as of that date.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public SearchHistoricalDataResponse SearchHistoricalData(SearchHistoricalData request)
		{
			return BaseUrlGet<SearchHistoricalData, SearchHistoricalDataResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#prices
		/// Returns professional-grade historical stock prices for a security or stock market index. New EOD prices 
		/// are available at 5p.m. EST and intraday prices are updated every minute during the trading day from 
		/// IEX. Historical prices are available back to 1996 or the IPO data in most cases, with some companies 
		/// with data back to the 1970s. Stock market index historical price data is available back to the 1950s at
		/// the earliest. Data from Quandl, QuoteMedia and the Federal Reserve Economic Data.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetPricesResponse GetPrices(GetPrices request)
		{
			return BaseUrlGet<GetPrices, GetPricesResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#company-sec-filings
		/// Returns the complete list of SEC filings for a company.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetCompanySecFilingsResponse GetCompanySecFilings(GetCompanySecFilings request)
		{
			return BaseUrlGet<GetCompanySecFilings, GetCompanySecFilingsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#company-news
		/// Returns the most recent news stories for a company.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetCompanyNewsResponse GetCompanyNews(GetCompanyNews request)
		{
			return BaseUrlGet<GetCompanyNews, GetCompanyNewsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#standardized-fundamentals
		/// Returns a list of available standardized fundamentals (fiscal year and fiscal period) for a given ticker and statement.
		/// Also, you may add a date and type parameter to specify the fundamentals you wish to be returned in the response.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetStandardizedFundamentalsResponse GetStandardizedFundamentals(GetStandardizedFundamentals request)
		{
			return BaseUrlGet<GetStandardizedFundamentals, GetStandardizedFundamentalsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#standardized-tags-and-labels
		/// Returns the (dcos say 'As Reported'? I think typo, should be standardized) XBRL tags and labels for a given ticker, statement, and date or fiscal year/fiscal quarter.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetStandardizedTagsResponse GetStandardizedTags(GetStandardizedTags request)
		{
			return BaseUrlGet<GetStandardizedTags, GetStandardizedTagsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#standardized-financials
		/// Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the 
		/// highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials 
		/// are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals.
		/// For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a 
		/// single company across multiple time periods.This is not possible using the as reported financial statements because of 
		/// the inherent complexity of reporting standards.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetStandardizedFinancialsResponse GetStandardizedFinancials(GetStandardizedFinancials request)
		{
			return BaseUrlGet<GetStandardizedFinancials, GetStandardizedFinancialsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#as-reported-fundamentals
		/// Returns a list of available as reported fundamentals (fiscal year, fiscal period, start date, and end date) for a 
		/// given ticker and statement. Also, you may add a date and type parameter to specify the fundamentals you wish to be
		/// returned in the response.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetAsReportedFundamentalsResponse GetAsReportedFundamentals(GetAsReportedFundamentals request)
		{
			return BaseUrlGet<GetAsReportedFundamentals, GetAsReportedFundamentalsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#as-reported-xbrl-tags-and-labels
		/// Returns the As Reported XBRL tags and labels for a given ticker, statement, and date or fiscal year/fiscal quarter.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetAsReportedXbrlTagsResponse GetAsReportedXbrlTags(GetAsReportedXbrlTags request)
		{
			return BaseUrlGet<GetAsReportedXbrlTags, GetAsReportedXbrlTagsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#as-reported-financials
		/// Returns the As Reported Financials directly from the financial statements of the XBRL filings from the company.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetAsReportedFinancialsResponse GetAsReportedFinancials(GetAsReportedFinancials request)
		{
			return BaseUrlGet<GetAsReportedFinancials, GetAsReportedFinancialsResponse>(request);
		}

		#endregion


		#region Insider Transactions & Ownership Data

		/// <summary>
		/// http://docs.intrinio.com/#owners121
		/// Returns owners list and information for all insider and institutional owners of securities covered by Intrinio. Includes detailed 
		/// info for a single owner and the ability to query by name.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetInsiderOwnersResponse GetInsiderOwners(GetInsiderOwners request)
		{
			return BaseUrlGet<GetInsiderOwners, GetInsiderOwnersResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#insider-transactions-by-company
		/// Returns a list of all insider transactions in a company. Criteria for being an insider include being a director, officer, 
		/// or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetCompanyInsiderTransactionsResponse GetCompanyInsiderTransactions(GetCompanyInsiderTransactions request)
		{
			return BaseUrlGet<GetCompanyInsiderTransactions, GetCompanyInsiderTransactionsResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#insider-ownership-by-company
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetCompanyInsiderOwnershipResponse GetCompanyInsiderOwnership(GetCompanyInsiderOwnership request)
		{
			return BaseUrlGet<GetCompanyInsiderOwnership, GetCompanyInsiderOwnershipResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#insider-transactions-by-owner
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetOwnerInsiderTransactionsResponse GetOwnerInsiderTransactions(GetOwnerInsiderTransactions request)
		{
			return BaseUrlGet<GetOwnerInsiderTransactions, GetOwnerInsiderTransactionsResponse>(request);
		}



		/// <summary>
		/// http://docs.intrinio.com/#insider-holdings-by-owner
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetOwnerInsiderHoldingsResponse GetOwnerInsiderHoldings(GetOwnerInsiderHoldings request)
		{
			return BaseUrlGet<GetOwnerInsiderHoldings, GetOwnerInsiderHoldingsResponse>(request);
		}

		#endregion

	}
}
	
