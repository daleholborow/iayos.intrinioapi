using System;
using System.Net;
using iayos.intrinioapi.ServiceModel.Messages;
using ServiceStack;

namespace iayos.intrinioapi.Api
{

	/// <summary>
	/// 
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
			_jsonClient = new JsonServiceClient(_apiBaseUrl);
		}


	    public GetCompaniesResponse GetCompanyMaster(GetCompanies request)
	    {
		    //var response = _jsonClient.
			throw new NotImplementedException();
	    }

	    //public static class MasterData
	    //{
		    
	    //}


		private TResponse BaseUrlGet<TRequest, TResponse>(TRequest request)
			where TRequest : new()
			where TResponse : new()
		{

			var requestRoute = request.ToGetUrl();
			//var targetUrl = AttachApiKey(ApiUriEndpoint + requestRoute);
			var targetUrl = _apiBaseUrl;
			try
			{
				var jsonResponse = targetUrl.GetJsonFromUrl();
				return jsonResponse.FromJson<TResponse>();
			}
			catch (WebException wse)
			{
				throw;
			}
		}


		private TResponse BaseUrlPost<TRequest, TResponse>(TRequest request)
			where TRequest : new()
			where TResponse : new()
		{

			var requestRoute = request.ToPostUrl();
			//var targetUrl = AttachApiKey(ApiUriEndpoint + requestRoute);
			var targetUrl = _apiBaseUrl;
			var jsonResponse = targetUrl.PostToUrl(request);
			return jsonResponse.FromJson<TResponse>();
		}
	}

}
