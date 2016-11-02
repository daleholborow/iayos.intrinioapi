namespace iayos.intrinioapi.servicemodel.flag
{
	public enum HistoricalDataType
	{
		/// <summary>
		/// Default: Did you forget to specify which Historical Data Type to use? I bet you did...
		/// </summary>
		IaYoS_Warning_Unset,

		/// <summary>
		/// Financial year
		/// </summary>
		FY,

		/// <summary>
		/// Quarterly
		/// </summary>
		QTR,

		/// <summary>
		/// Trailing 12 months
		/// </summary>
		TTM,

		/// <summary>
		/// Year to Date
		/// </summary>
		YTD
	}
}