using iayos.intrinioapi.ServiceModel.Enums;

namespace iayos.intrinioapi.ServiceModel.Dtos
{
	public class TagDto
	{
		/// <summary>
		/// the readable name of the tag
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// the Intrinio standardized tag
		/// </summary>
		public DataPointTag tag { get; set; }

		/// <summary>
		///  the parent Intrinio standardized tag forming the statement relationship with the factor.
		/// </summary>
		public DataPointTag parent { get; set; }

		/// <summary>
		///  the operator forming the statement relationship between the child tag (or tags) and the parent.
		/// </summary>
		public string factor { get; set; }

		/// <summary>
		/// the accounting balance (debit or credit) of the tag
		/// </summary>
		public string balance { get; set; }

		/// <summary>
		/// the nature of the tag, operating or nonoperating
		/// </summary>
		public string type { get; set; }

		/// <summary>
		///  the unit of the tag
		/// </summary>
		public string units { get; set; }
	}
}
