namespace iayos.intrinioapi.servicemodel.flag
{
	public enum IndexType
	{
		/// <summary>
		/// Default: Did you forget to specify which IndexType to use? I bet you did...
		/// </summary>
		IaYoS_Warning_Unset,

		full,       // returns full list by default

		stock_market,

		economic,

		sic
	}
}