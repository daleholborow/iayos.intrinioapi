namespace iayos.intrinioapi.servicemodel.flag
{
	public enum SecurityFinancialStatus
	{
		/// <summary>
		/// Default: Did you forget to specify which SecurityFinancialStatus to use? I bet you did...
		/// </summary>
		IaYoS_Warning_Unset,

		/// <summary>
		/// Deficient: Issuer Failed to Meet NASDAQ Continued Listing Requirements, 
		/// </summary>
		D,

		/// <summary>
		/// Delinquent: Issuer Missed Regulatory Filing Deadline,
		/// </summary>
		E,

		/// <summary>
		/// Bankrupt: Issuer Has Filed for Bankruptcy, 
		/// </summary>
		Q,

		/// <summary>
		/// Normal (Default): Issuer Is NOT Deficient, Delinquent, or Bankrupt., 
		/// </summary>
		N,

		/// <summary>
		/// Deficient and Bankrupt, 
		/// </summary>
		G,

		/// <summary>
		/// Deficient and Delinquent, 
		/// </summary>
		H,

		/// <summary>
		/// Delinquent and Bankrupt, 
		/// </summary>
		J,

		/// <summary>
		/// Deficient, Delinquent, and Bankrupt
		/// </summary>
		K
	}
}