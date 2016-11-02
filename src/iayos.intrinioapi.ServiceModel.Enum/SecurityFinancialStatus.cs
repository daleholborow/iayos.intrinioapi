namespace iayos.intrinioapi.ServiceModel.Enum
{
	public enum SecurityFinancialStatus
	{
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