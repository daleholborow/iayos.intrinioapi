namespace iayos.intrinioapi.servicemodel.flag
{
	public enum DataFrequency
	{
		/// <summary>
		/// Default: Did you forget to specify which data frequence to use? I bet you did...
		/// </summary>
		IaYoS_Warning_Unset,

		/// <summary>
		/// Default to daily data
		/// </summary>
		daily,

		/// <summary>
		/// 
		/// </summary>
		weekly,

		monthly,

		quarterly,

		yearly
	}
}