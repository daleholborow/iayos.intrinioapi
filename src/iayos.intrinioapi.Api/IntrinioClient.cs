using iayos.intrinioapi.ServiceModel;
using iayos.intrinioapi.ServiceModel.Messages;
using ServiceStack;

namespace iayos.intrinioapi.Api
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
			_jsonClient = new JsonServiceClient(_apiBaseUrl) { AlwaysSendBasicAuthHeader = true, UserName = _username, Password = _password };
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
		public GetMasterCompaniesListResponse GetMasterCompaniesList(GetMasterCompaniesList request)
		{
			return BaseUrlGet<GetMasterCompaniesList, GetMasterCompaniesListResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#security-master
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetSecuritiesResponse GetMasterSecuritiesList(GetMasterSecuritiesList request)
		{
			return BaseUrlGet<GetMasterSecuritiesList, GetSecuritiesResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#index-master
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetIndicesResponse GetMasterIndicesList(GetMasterIndicesList request)
		{
			return BaseUrlGet<GetMasterIndicesList, GetIndicesResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#owner-master
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public GetOwnersResponse GetMasterOwnersList(GetMasterOwnersList request)
		{
			return BaseUrlGet<GetMasterOwnersList, GetOwnersResponse>(request);
		}

		#endregion


		#region U.S. Public Company Data Feed

		/// <summary>
		/// http://docs.intrinio.com/#companies
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public SearchCompaniesResponse SearchCompanies(SearchCompanies request)
		{
			return BaseUrlGet<SearchCompanies, SearchCompaniesResponse>(request);
		}


		/// <summary>
		/// http://docs.intrinio.com/#securities
		/// Returns security list and information all securities that match the given conditions. The API 
		/// call credits required for each call is equal to the number of conditions specified.
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

		#endregion

	}

}
