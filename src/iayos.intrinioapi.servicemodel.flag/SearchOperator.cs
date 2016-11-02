namespace iayos.intrinioapi.servicemodel.flag
{
	public enum SearchOperator
	{
		/// <summary>
		/// Default: Did you forget to specify which Search Operator to use? I bet you did...
		/// </summary>
		IaYoS_Warning_Unset,

		/// <summary>
		/// Equals
		/// </summary>
		eq,


		/// <summary>
		/// Greater than
		/// </summary>
		gt,

		/// <summary>
		/// Greater than or equal to
		/// </summary>
		gte,

		/// <summary>
		/// Less than
		/// </summary>
		lt,

		/// <summary>
		/// Less than or equal to
		/// </summary>
		lte,

		/// <summary>
		/// Contains
		/// </summary>
		contains
	}
}