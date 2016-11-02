namespace iayos.intrinioapi.servicemodel.flag
{
	public enum FinancialStatement
	{

		/// <summary>
		/// Default: Did you forget to specify which FinancialStatement type to use? I bet you did...
		/// </summary>
		IaYoS_Warning_Unset,

		income_statement,
		
		balance_sheet,

		cash_flow_statement,

		calculations
	}
}