using System.Collections.Generic;
using iayos.intrinioapi.ServiceModel.Dtos;
using iayos.intrinioapi.ServiceModel.Enums;
using ServiceStack;

namespace iayos.intrinioapi.ServiceModel.Messages
{

	[Route("/tags/standardized", HttpMethods.Get)]
	public class GetStandardizedTags : Request, IReturn<GetStandardizedTagsResponse>
	{
		/// <summary>
		/// the financial statement requested, options include the income statement, balance sheet, statement 
		/// of cash flows, calculated metrics and ratios, and current data points : 
		/// income_statement | balance_sheet | cash_flow_statement | calculations | current
		/// </summary>
		public FinancialStatement statement { get; set; } = FinancialStatement.IaYoS_Warning_Unset;

		/// <summary>
		/// (optional, must include a ticker if not specified) - the financial statement tag template: industrial | financial
		/// </summary>
		public TagTemplate? template { get; set; }


		/// <summary>
		/// (optional, must include a template if not specified) - the stock market ticker symbol associated 
		/// with the companies common stock securities: TICKER SYMBOL
		/// </summary>
		public string identifier { get; set; }

		/*
		public int sequence(optional, returns full list without a sequence number) - an integer 0 or greater for calling a single tag from the first entry, based on order
		*/

	}

	public class GetStandardizedTagsResponse : Response<List<TagDto>>
	{
	}
}
