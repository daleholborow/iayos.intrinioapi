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
			_jsonClient = new JsonServiceClient(_apiBaseUrl) {AlwaysSendBasicAuthHeader = true, UserName = _username, Password = _password };
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

		public GetCompaniesResponse GetCompanyMaster(GetCompanies request)
		{
			return BaseUrlGet<GetCompanies, GetCompaniesResponse>(request);
		}


		public GetSecuritiesResponse GetSecuritiesMaster(GetSecurities request)
		{
			return BaseUrlGet<GetSecurities, GetSecuritiesResponse>(request);
		}


		public GetIndicesResponse GetIndicesMaster(GetIndices request)
		{
			return BaseUrlGet<GetIndices, GetIndicesResponse>(request);
		}


	    public GetOwnersResponse GetOwnersMaster(GetOwners request)
	    {
		    return BaseUrlGet<GetOwners, GetOwnersResponse>(request);
	    }

		#endregion


		#region U.S. Public Company Data Feed



		#endregion

	}

}
