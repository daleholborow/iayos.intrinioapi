using System;

namespace iayos.intrinioapi.servicemodel.message.Messages
{
	public class CompanyNewsDto
	{
		/// <summary>
		/// the title of the article
		/// </summary>
		public string title { get; set; }

		/// <summary>
		/// the date the article was published
		/// </summary>
		public DateTime publication_date { get; set; }


		/// <summary>
		/// the hyperlink to the article
		/// </summary>
		public string url { get; set; }


		/// <summary>
		/// a brief summary of the article
		/// </summary>
		public string summary { get; set; } 
	}
}