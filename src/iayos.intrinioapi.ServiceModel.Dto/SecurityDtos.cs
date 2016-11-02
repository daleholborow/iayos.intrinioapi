using System;
using iayos.intrinioapi.servicemodel.@enum;

namespace iayos.intrinioapi.servicemodel.dto
{

	/// <summary>
	/// Both:
	/// http://docs.intrinio.com/#security-master
	/// and
	/// http://docs.intrinio.com/#securities
	/// </summary>
	public class SecurityDetailDto
	{
		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		/// the security description as provided by the exchange
		/// </summary>
		public string security_name { get; set; }

		/// <summary>
		/// the type of security, such as Common Stock, Preferred Stock, Warrants, Limited Partnership Interests, etc.
		/// </summary>
		public string security_type { get; set; }

		/// <summary>
		/// if a company has multiple securities, the security class is a single letter description of the class of a certain type of security.
		/// </summary>
		public string security_class { get; set; }

		/// <summary>
		/// the Stock Exchange (and market category) where the company’s common stock is primarily traded
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		/// the Stock Exchange where the company’s common stock is primarily traded
		/// </summary>
		public string listing_exchange { get; set; }

		/// <summary>
		///  the NASDAQ market category for a NASDAQ listed company.
		/// </summary>
		public object market_category { get; set; }

		/// <summary>
		/// true or false, depending on whether the security is an ETF or not.
		/// </summary>
		public bool? etf { get; set; }

		/// <summary>
		///  the round lot size for the security.
		/// </summary>
		public int round_lot_size { get; set; }

		/// <summary>
		/// indicates when an issuer has failed to submit its regulatory filings on a timely basis, has failed 
		/// to meet NASDAQ’s continuing listing standards, and/or has filed for bankruptcy. 
		/// </summary>
		public SecurityFinancialStatus financial_status { get; set; }

		/// <summary>
		/// true if the subject security is the primary security for the company. If a security is the default, 
		/// the ticker symbol for the security is the same as the ticker for the company (see /Companies endpoint).
		/// </summary>
		public bool primary_security { get; set; }

		/// <summary>
		/// if the security is no longer traded on public exchanges, the security will be considered delisted 
		/// and the security no longer will report pricing data.
		/// </summary>
		public bool delisted_security { get; set; }

		/// <summary>
		/// the last recorded date (“YYYY-MM-DD”) of an CRSP adjustment made to prior prices due to a stock split or dividend event.
		/// </summary>
		public DateTime last_crsp_adj_date { get; set; }
	}


	/// <summary>
	/// http://docs.intrinio.com/#securities-search-screener
	/// </summary>
	public class SecurityScreenerDetailDto
	{


		/*
				/// <summary>
				/// 52 Week High
				/// Statement code: current, type: prices, units: usdpershare 
				/// </summary>
				public double? 52_week_high { get; set; }

				/// <summary>
				/// 52 Week Low
				/// Statement code: current, type: prices, units: usdpershare 
				/// </summary>
				public double? 52_week_low { get; set; }
		*/

		/// <summary>
		/// Accounts Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? accountspayable { get; set; }

		/// <summary>
		/// Accounts Payable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public double? apturnover { get; set; }

		/// <summary>
		/// Accounts Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? accountsreceivable { get; set; }

		/// <summary>
		/// Accounts Receivable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public double? arturnover { get; set; }

		/// <summary>
		/// Accrued Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? accruedexpenses { get; set; }

		/// <summary>
		/// Accrued Interest Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? accruedinterestpayable { get; set; }

		/// <summary>
		/// Accrued Investment Income
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? accruedinvestmentincome { get; set; }

		/// <summary>
		/// Accumulated Depreciation
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? accumulateddepreciation { get; set; }

		/// <summary>
		/// Accumulated Other Comprehensive Income / (Loss)
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? aoci { get; set; }

		/// <summary>
		/// Acquisitions
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? acquisitions { get; set; }

		/// <summary>
		/// Adjusted Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? adj_close_price { get; set; }

		/// <summary>
		/// Adjusted High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? adj_high_price { get; set; }

		/// <summary>
		/// Adjusted Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? adj_low_price { get; set; }

		/// <summary>
		/// Adjusted Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? adj_open_price { get; set; }

		/// <summary>
		/// Adjusted Volume
		/// Statement code: current, type: prices, units: shares 
		/// </summary>
		public long? adj_volume { get; set; }

		/// <summary>
		/// Allowance for Loan and Lease Losses
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? allowanceforloanandleaselosses { get; set; }

		/// <summary>
		/// Altman Z-Score
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public double? altmanzscore { get; set; }

		/// <summary>
		/// Amortization Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? amortizationexpense { get; set; }

		/// <summary>
		/// Amortization of Deferred Policy Acquisition Costs
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? amortizationofdeferredpolicyacquisitioncosts { get; set; }

		/// <summary>
		/// Ask Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? ask_price { get; set; }

		/// <summary>
		/// Ask Size
		/// Statement code: current, type: prices, units: integer 
		/// </summary>
		public int ask_size { get; set; }

		/// <summary>
		/// Ask Timestamp
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		public DateTime? ask_timestamp { get; set; }

		/// <summary>
		/// Asset Retirement Reserve & Litigation Obligation
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? assetretirementandlitigationobligation { get; set; }

		/// <summary>
		/// Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public double? assetturnover { get; set; }

		/// <summary>
		/// Augmented Payout Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? augmentedpayoutratio { get; set; }

		/// <summary>
		/// Average Daily Volume
		/// Statement code: current, type: short_interest, units: shares 
		/// </summary>
		public long? average_daily_volume { get; set; }

		/// <summary>
		/// Bankers Acceptance Outstanding
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? bankersacceptances { get; set; }

		/// <summary>
		/// Basic & Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public double? basicdilutedeps { get; set; }

		/// <summary>
		/// Basic Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public double? basiceps { get; set; }

		/// <summary>
		/// Beta
		/// Statement code: current, type: info, units: float 
		/// </summary>
		public double? beta { get; set; }

		/// <summary>
		/// Bid Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? bid_price { get; set; }

		/// <summary>
		/// Bid Size
		/// Statement code: current, type: prices, units: integer 
		/// </summary>
		public int bid_size { get; set; }

		/// <summary>
		/// Bid Timestamp
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		public DateTime? bid_timestamp { get; set; }

		/// <summary>
		/// Book Value per Share
		/// Statement code: calculations, type: metric, units: usdpershare 
		/// </summary>
		public double? bookvaluepershare { get; set; }

		/// <summary>
		/// Business Address
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string business_address { get; set; }

		/// <summary>
		/// Business Phone Number
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string business_phone_no { get; set; }

		/// <summary>
		/// Capital Expenditures (CapEx)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? capex { get; set; }

		/// <summary>
		/// Capital Lease Obligations
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? capitalleaseobligations { get; set; }

		/// <summary>
		/// Capitalized Lease Obligations Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? capitalizedleaseobligationinterestexpense { get; set; }

		/// <summary>
		/// Cash & Equivalents
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? cashandequivalents { get; set; }

		/// <summary>
		/// Cash Conversion Cycle (CCC)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public int ccc { get; set; }

		/// <summary>
		/// Cash Dividends to Common per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public double? cashdividendspershare { get; set; }

		/// <summary>
		/// Cash Income Taxes Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? cashincometaxespaid { get; set; }

		/// <summary>
		/// Cash Interest Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? cashinterestpaid { get; set; }

		/// <summary>
		/// Cash Interest Received
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? cashinterestreceived { get; set; }

		/// <summary>
		/// Cash Return on Invested Capital (CROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? croic { get; set; }

		/// <summary>
		/// Change in Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? change { get; set; }

		/// <summary>
		/// Changes in Operating Assets and Liabilities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? increasedecreaseinoperatingcapital { get; set; }

		/// <summary>
		/// Chief Executive Officer (CEO)
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string ceo { get; set; }

		/// <summary>
		/// Claims and Claim Expense
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? claimsandclaimexpenses { get; set; }

		/// <summary>
		/// Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? close_price { get; set; }

		/// <summary>
		/// Commitments & Contingencies
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? commitmentsandcontingencies { get; set; }

		/// <summary>
		/// Common Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public double? commontocap { get; set; }

		/// <summary>
		/// Common Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? commonequity { get; set; }

		/// <summary>
		/// Company Legal Name
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string legal_name { get; set; }

		/// <summary>
		/// Company Name
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// Company Website
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string company_url { get; set; }

		/// <summary>
		/// Compound Leverage Factor
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public double? compoundleveragefactor { get; set; }

		/// <summary>
		/// Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? netincome { get; set; }

		/// <summary>
		/// Cost of Revenue to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? costofrevtorevenue { get; set; }

		/// <summary>
		/// Country
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string country { get; set; }

		/// <summary>
		/// Current and Future Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? currentandfuturebenefits { get; set; }

		/// <summary>
		/// Current Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? currentdeferredtaxliabilities { get; set; }

		/// <summary>
		/// Current Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? currentdeferredtaxassets { get; set; }

		/// <summary>
		/// Current Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? currentdeferredrevenue { get; set; }

		/// <summary>
		/// Current Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? currentemployeebenefitliabilities { get; set; }

		/// <summary>
		/// Current Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		public double? currentratio { get; set; }

		/// <summary>
		/// Current Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? currentyearearningsyield { get; set; }

		/// <summary>
		/// Customer and Other Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? customerandotherreceivables { get; set; }

		/// <summary>
		/// Customer Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? customerdeposits { get; set; }

		/// <summary>
		/// Days Inventory Outstanding (DIO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public int dio { get; set; }

		/// <summary>
		/// Days Payable Outstanding (DPO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public int dpo { get; set; }

		/// <summary>
		/// Days Sales Outstanding (DSO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public int dso { get; set; }

		/// <summary>
		/// Days to Cover
		/// Statement code: current, type: short_interest, units: days 
		/// </summary>
		public int days_to_cover { get; set; }

		/// <summary>
		/// Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public double? debttoebitda { get; set; }

		/// <summary>
		/// Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public double? debttoequity { get; set; }

		/// <summary>
		/// Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public double? debttonopat { get; set; }

		/// <summary>
		/// Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public double? debttototalcapital { get; set; }

		/// <summary>
		/// Debt-free Net Working Capital (DFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? dfnwc { get; set; }

		/// <summary>
		/// Debt-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public double? dfnwctorev { get; set; }

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital (DFCFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? dfcfnwc { get; set; }

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public double? dfcfnwctorev { get; set; }

		/// <summary>
		/// Deferred Acquisition Cost
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? deferredacquisitioncost { get; set; }

		/// <summary>
		/// Depletion Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? depletionexpense { get; set; }

		/// <summary>
		/// Deposits and Money Market Investments Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? depositsinterestincome { get; set; }

		/// <summary>
		/// Deposits Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? depositsinterestexpense { get; set; }

		/// <summary>
		/// Depreciation Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? depreciationexpense { get; set; }

		/// <summary>
		/// Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public double? dilutedeps { get; set; }

		/// <summary>
		/// Divestitures
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? divestitures { get; set; }

		/// <summary>
		/// Dividend Ex Date
		/// Statement code: current, type: dividend, units: string 
		/// </summary>
		public string dividend_ex_date { get; set; }

		/// <summary>
		/// Dividend Pay Date
		/// Statement code: current, type: dividend, units: string 
		/// </summary>
		public string dividend_pay_date { get; set; }

		/// <summary>
		/// Dividend Payout Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? divpayoutratio { get; set; }

		/// <summary>
		/// Dividend per Share
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public double? dividend { get; set; }

		/// <summary>
		/// Dividend Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		public double? dividendyield { get; set; }

		/// <summary>
		/// Dividends Payable
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? dividendspayable { get; set; }

		/// <summary>
		/// Earnings before Interest and Taxes (EBIT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? ebit { get; set; }

		/// <summary>
		/// Earnings before Interest, Taxes, Depreciation and Amortization (EBITDA)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? ebitda { get; set; }

		/// <summary>
		/// Earnings Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		public double? earningsyield { get; set; }

		/// <summary>
		/// EBIT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? ebitgrowth { get; set; }

		/// <summary>
		/// EBIT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public double? ebitlesscapextointerestex { get; set; }

		/// <summary>
		/// EBIT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? ebitmargin { get; set; }

		/// <summary>
		/// EBIT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? ebitqoqgrowth { get; set; }

		/// <summary>
		/// EBIT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public double? ebittointerestex { get; set; }

		/// <summary>
		/// EBITDA Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? ebitdagrowth { get; set; }

		/// <summary>
		/// EBITDA Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? ebitdamargin { get; set; }

		/// <summary>
		/// EBITDA Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? ebitdaqoqgrowth { get; set; }

		/// <summary>
		/// Effect of Exchange Rate Changes
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? effectofexchangeratechanges { get; set; }

		/// <summary>
		/// Effective Tax Rate
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? efftaxrate { get; set; }

		/// <summary>
		/// Employee Benefit Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? employeebenefitassets { get; set; }

		/// <summary>
		/// Employees
		/// Statement code: current, type: info, units: integer 
		/// </summary>
		public int employees { get; set; }

		/// <summary>
		/// Enterprise Value (EV)
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		public double? enterprisevalue { get; set; }

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? evtocurrentyearrevenue { get; set; }

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? evtonextyearrevenue { get; set; }

		/// <summary>
		/// Enterprise Value to EBIT (EV/EBIT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? evtoebit { get; set; }

		/// <summary>
		/// Enterprise Value to EBITDA (EV/EBITDA)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? evtoebitda { get; set; }

		/// <summary>
		/// Enterprise Value to Free Cash Flow (EV/FCFF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? evtofcff { get; set; }

		/// <summary>
		/// Enterprise Value to Invested Capital (EV/IC)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? evtoinvestedcapital { get; set; }

		/// <summary>
		/// Enterprise Value to NOPAT (EV/NOPAT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? evtonopat { get; set; }

		/// <summary>
		/// Enterprise Value to Operating Cash Flow (EV/OCF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? evtoocf { get; set; }

		/// <summary>
		/// Enterprise Value to Revenue (EV/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? evtorevenue { get; set; }

		/// <summary>
		/// EPS Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? epsgrowth { get; set; }

		/// <summary>
		/// EPS Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? epsqoqgrowth { get; set; }

		/// <summary>
		/// Ex Dividend
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		public double? ex_dividend { get; set; }

		/// <summary>
		/// Exchange Financial Status
		/// Statement code: current, type: security, units: boolean 
		/// </summary>
		public bool? exchange_status { get; set; }

		/// <summary>
		/// Exploration Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? explorationexpense { get; set; }

		/// <summary>
		/// Extraordinary Income / (Loss), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public double? extraordinaryincome { get; set; }

		/// <summary>
		/// Federal Funds Purchased and Securities Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? fedfundspurchased { get; set; }

		/// <summary>
		/// Federal Funds Purchased and Securities Sold Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? fedfundsandrepointerestexpense { get; set; }

		/// <summary>
		/// Federal Funds Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? fedfundssold { get; set; }

		/// <summary>
		/// Federal Funds Sold and Securities Borrowed Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? fedfundsandrepointerestincome { get; set; }

		/// <summary>
		/// Financial Leverage
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public double? finleverage { get; set; }

		/// <summary>
		/// Five Year Average Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public double? five_yr_ave_dividend_yield { get; set; }

		/// <summary>
		/// Five Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? five_yr_monthly_beta { get; set; }

		/// <summary>
		/// Five Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? five_yr_weekly_beta { get; set; }

		/// <summary>
		/// Fixed Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public double? faturnover { get; set; }

		/// <summary>
		/// Forward Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public double? forward_dividend_rate { get; set; }

		/// <summary>
		/// Forward Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public double? forward_dividend_yield { get; set; }

		/// <summary>
		/// Free Cash Flow Firm Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? fcffgrowth { get; set; }

		/// <summary>
		/// Free Cash Flow Firm Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? fcffqoqgrowth { get; set; }

		/// <summary>
		/// Free Cash Flow to Firm (FCFF)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? freecashflow { get; set; }

		/// <summary>
		/// Free Cash Flow to Firm to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public double? fcfftointerestex { get; set; }

		/// <summary>
		/// Future Policy Benefits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? futurepolicybenefits { get; set; }

		/// <summary>
		/// Goodwill
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? goodwill { get; set; }

		/// <summary>
		/// Gross Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? grossmargin { get; set; }

		/// <summary>
		/// High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? high_price { get; set; }

		/// <summary>
		/// Impairment Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? impairmentexpense { get; set; }

		/// <summary>
		/// Income Tax Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? incometaxexpense { get; set; }

		/// <summary>
		/// Incorporated Country
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string inc_country { get; set; }

		/// <summary>
		/// Incorporated State
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string inc_state { get; set; }

		/// <summary>
		/// Increase / (Decrease) in Invested Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? investedcapitalincreasedecrease { get; set; }

		/// <summary>
		/// Industry Category
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string industry_category { get; set; }

		/// <summary>
		/// Industry Group
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string industry_group { get; set; }

		/// <summary>
		/// Insurance Policy Acquisition Costs
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? policyacquisitioncosts { get; set; }

		/// <summary>
		/// Intangible Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? intangibleassets { get; set; }

		/// <summary>
		/// Interest & Investment Income
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public double? totalinterestincome { get; set; }

		/// <summary>
		/// Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? interestbearingdeposits { get; set; }

		/// <summary>
		/// Interest Bearing Deposits at Other Banks
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? interestbearingdepositsatotherbanks { get; set; }

		/// <summary>
		/// Interest Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? interestburdenpct { get; set; }

		/// <summary>
		/// Interest Expense
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public double? totalinterestexpense { get; set; }

		/// <summary>
		/// Inventories, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? netinventory { get; set; }

		/// <summary>
		/// Inventory Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public double? invturnover { get; set; }

		/// <summary>
		/// Invested Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? investedcapital { get; set; }

		/// <summary>
		/// Invested Capital Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? investedcapitalgrowth { get; set; }

		/// <summary>
		/// Invested Capital Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? investedcapitalqoqgrowth { get; set; }

		/// <summary>
		/// Invested Capital Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public double? investedcapitalturnover { get; set; }

		/// <summary>
		/// Investment Banking Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? investmentbankingincome { get; set; }

		/// <summary>
		/// Investment Securities Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? investmentsecuritiesinterestincome { get; set; }

		/// <summary>
		/// Issuance of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? issuanceofcommonequity { get; set; }

		/// <summary>
		/// Issuance of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? issuanceofdebt { get; set; }

		/// <summary>
		/// Issuance of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? issuanceofpreferredequity { get; set; }

		/// <summary>
		/// Leverage Ratio
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public double? leverageratio { get; set; }

		/// <summary>
		/// Listing Exchange
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string listing_exchange { get; set; }

		/// <summary>
		/// Loans and Leases
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? loansandleases { get; set; }

		/// <summary>
		/// Loans and Leases Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? loansandleaseinterestincome { get; set; }

		/// <summary>
		/// Loans and Leases, Net of Allowance
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? netloansandleases { get; set; }

		/// <summary>
		/// Loans Held for Sale
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? loansheldforsale { get; set; }

		/// <summary>
		/// Loans Held for Sale, Net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? loansheldforsalenet { get; set; }

		/// <summary>
		/// Long Description
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string long_description { get; set; }

		/// <summary>
		/// Long-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? longtermdebt { get; set; }

		/// <summary>
		/// Long-Term Debt Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? longtermdebtinterestexpense { get; set; }

		/// <summary>
		/// Long-Term Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public double? ltdebttoebitda { get; set; }

		/// <summary>
		/// Long-Term Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public double? ltdebttoequity { get; set; }

		/// <summary>
		/// Long-Term Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public double? ltdebttonopat { get; set; }

		/// <summary>
		/// Long-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public double? ltdebttocap { get; set; }

		/// <summary>
		/// Long-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? longterminvestments { get; set; }

		/// <summary>
		/// Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? low_price { get; set; }

		/// <summary>
		/// Mailing Address
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string mailing_address { get; set; }

		/// <summary>
		/// Market Capitalization
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		public double? marketcap { get; set; }

		/// <summary>
		/// Market Category
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string market_category { get; set; }

		/// <summary>
		/// Marketing Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? marketingexpense { get; set; }

		/// <summary>
		/// Mortgage Servicing Rights
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? mortgageservicingrights { get; set; }

		/// <summary>
		/// Net Cash From Continuing Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromcontinuingfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Continuing Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromcontinuinginvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Continuing Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromcontinuingoperatingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromdiscontinuedfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromdiscontinuedinvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromdiscontinuedoperatingactivities { get; set; }

		/// <summary>
		/// Net Cash From Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfrominvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netcashfromoperatingactivities { get; set; }

		/// <summary>
		/// Net Change in Cash & Equivalents
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netchangeincash { get; set; }

		/// <summary>
		/// Net Change in Deposits
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netchangeindeposits { get; set; }

		/// <summary>
		/// Net Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? netdebt { get; set; }

		/// <summary>
		/// Net Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public double? netdebttoebitda { get; set; }

		/// <summary>
		/// Net Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public double? netdebttonopat { get; set; }

		/// <summary>
		/// Net Income / (Loss) Attributable to Common Shareholders
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? netincometocommon { get; set; }

		/// <summary>
		/// Net Income / (Loss) Attributable to Noncontrolling Interest
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? netincometononcontrollinginterest { get; set; }

		/// <summary>
		/// Net Income / (Loss) Continuing Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? netincomecontinuing { get; set; }

		/// <summary>
		/// Net Income / (Loss) Discontinued Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? netincomediscontinued { get; set; }

		/// <summary>
		/// Net Income Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? netincomegrowth { get; set; }

		/// <summary>
		/// Net Income Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? netincomeqoqgrowth { get; set; }

		/// <summary>
		/// Net Increase in Fed Funds Sold
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? netincreaseinfedfundssold { get; set; }

		/// <summary>
		/// Net Interest Income / (Expense)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? netinterestincome { get; set; }

		/// <summary>
		/// Net Nonoperating Expense (NNE)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? netnonopex { get; set; }

		/// <summary>
		/// Net Nonoperating Expense Percent (NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? nnep { get; set; }

		/// <summary>
		/// Net Nonoperating Obligations (NNO)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? netnonopobligations { get; set; }

		/// <summary>
		/// Net Occupancy & Equipment Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? netoccupancyequipmentexpense { get; set; }

		/// <summary>
		/// Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? nopat { get; set; }

		/// <summary>
		/// Net Realized & Unrealized Capital Gains on Investments
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? netrealizedcapitalgains { get; set; }

		/// <summary>
		/// Net Working Capital (NWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? nwc { get; set; }

		/// <summary>
		/// Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public double? nwctorev { get; set; }

		/// <summary>
		/// Next Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? nextyearearningsyield { get; set; }

		/// <summary>
		/// Non-Cash Adjustments To Reconcile Net Income
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? noncashadjustmentstonetincome { get; set; }

		/// <summary>
		/// Non-Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? noninterestbearingdeposits { get; set; }

		/// <summary>
		/// Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? noncontrollinginterests { get; set; }

		/// <summary>
		/// Noncontrolling Interest Sharing Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? noncontrollinginterestsharingratio { get; set; }

		/// <summary>
		/// Noncontrolling Interests to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public double? noncontrolinttocap { get; set; }

		/// <summary>
		/// Noncurrent Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? noncurrentdeferredtaxliabilities { get; set; }

		/// <summary>
		/// Noncurrent Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? noncurrentdeferredtaxassets { get; set; }

		/// <summary>
		/// Noncurrent Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? noncurrentdeferredrevenue { get; set; }

		/// <summary>
		/// Noncurrent Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? noncurrentemployeebenefitliabilities { get; set; }

		/// <summary>
		/// Noncurrent Note & Lease Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? noncurrentnotereceivables { get; set; }

		/// <summary>
		/// Nonoperating Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public double? nonoperatingincome { get; set; }

		/// <summary>
		/// NOPAT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? nopatgrowth { get; set; }

		/// <summary>
		/// NOPAT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public double? nopatlesscapextointex { get; set; }

		/// <summary>
		/// NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? nopatmargin { get; set; }

		/// <summary>
		/// NOPAT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? nopatqoqgrowth { get; set; }

		/// <summary>
		/// NOPAT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public double? nopattointerestex { get; set; }

		/// <summary>
		/// Normalized Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? normalizednopat { get; set; }

		/// <summary>
		/// Normalized NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? normalizednopatmargin { get; set; }

		/// <summary>
		/// Note & Lease Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? notereceivable { get; set; }

		/// <summary>
		/// One Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? one_yr_monthly_beta { get; set; }

		/// <summary>
		/// One Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? one_yr_weekly_beta { get; set; }

		/// <summary>
		/// Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public double? open_price { get; set; }

		/// <summary>
		/// Operating Cash Flow Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? ocfgrowth { get; set; }

		/// <summary>
		/// Operating Cash Flow Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public double? ocflesscapextointerestex { get; set; }

		/// <summary>
		/// Operating Cash Flow Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? ocfqoqgrowth { get; set; }

		/// <summary>
		/// Operating Cash Flow to CapEx
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? ocftocapex { get; set; }

		/// <summary>
		/// Operating Cash Flow to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public double? ocftointerestex { get; set; }

		/// <summary>
		/// Operating Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? operatingcostofrevenue { get; set; }

		/// <summary>
		/// Operating Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? opextorevenue { get; set; }

		/// <summary>
		/// Operating Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? operatingmargin { get; set; }

		/// <summary>
		/// Operating Return on Assets (OROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? oroa { get; set; }

		/// <summary>
		/// Operating Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? operatingrevenue { get; set; }

		/// <summary>
		/// Other Adjustments to Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? otheradjustmentstoconsolidatednetincome { get; set; }

		/// <summary>
		/// Other Adjustments to Net Income / (Loss) Attributable to Common Shareholders)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? otheradjustmentstonetincometocommon { get; set; }

		/// <summary>
		/// Other Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? otherassets { get; set; }

		/// <summary>
		/// Other Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? othercostofrevenue { get; set; }

		/// <summary>
		/// Other Current Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? othercurrentassets { get; set; }

		/// <summary>
		/// Other Current Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? othercurrentliabilities { get; set; }

		/// <summary>
		/// Other Current Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? othercurrentnonoperatingassets { get; set; }

		/// <summary>
		/// Other Current Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? othercurrentnonoperatingliabilities { get; set; }

		/// <summary>
		/// Other Equity Adjustments
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? otherequity { get; set; }

		/// <summary>
		/// Other Financing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? otherfinancingactivitiesnet { get; set; }

		/// <summary>
		/// Other Gains / (Losses), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public double? othergains { get; set; }

		/// <summary>
		/// Other Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public double? otherincome { get; set; }

		/// <summary>
		/// Other Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? otherinterestexpense { get; set; }

		/// <summary>
		/// Other Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? otherinterestincome { get; set; }

		/// <summary>
		/// Other Investing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? otherinvestingactivitiesnet { get; set; }

		/// <summary>
		/// Other Long-Term Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? otherlongtermliabilities { get; set; }

		/// <summary>
		/// Other Net Changes in Cash
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? othernetchangesincash { get; set; }

		/// <summary>
		/// Other Non-Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? othernoninterestincome { get; set; }

		/// <summary>
		/// Other Noncurrent Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? othernoncurrentnonoperatingassets { get; set; }

		/// <summary>
		/// Other Noncurrent Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? othernoncurrentnonoperatingliabilities { get; set; }

		/// <summary>
		/// Other Noncurrent Operating Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? othernoncurrentassets { get; set; }

		/// <summary>
		/// Other Noncurrent Operating Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? othernoncurrentliabilities { get; set; }

		/// <summary>
		/// Other Operating Expenses / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? otheroperatingexpenses { get; set; }

		/// <summary>
		/// Other Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? otherrevenue { get; set; }

		/// <summary>
		/// Other Service Charges
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? otherservicechargeincome { get; set; }

		/// <summary>
		/// Other Short-Term Payables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? othershorttermpayables { get; set; }

		/// <summary>
		/// Other Special Charges / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? otherspecialcharges { get; set; }

		/// <summary>
		/// Other Taxes Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? othertaxespayable { get; set; }

		/// <summary>
		/// Participating Policy Holder Equity
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? participatingpolicyholderequity { get; set; }

		/// <summary>
		/// Payment of Dividends
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? paymentofdividends { get; set; }

		/// <summary>
		/// Percent Change in Price
		/// Statement code: current, type: prices, units: percentage 
		/// </summary>
		public double? percent_change { get; set; }

		/// <summary>
		/// Plant, Property & Equipment, gross
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? grossppe { get; set; }

		/// <summary>
		/// Plant, Property, & Equipment, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? netppe { get; set; }

		/// <summary>
		/// Policy Holder Funds
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? policyholderfunds { get; set; }

		/// <summary>
		/// Pre Tax Income Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? pretaxincomemargin { get; set; }

		/// <summary>
		/// Preferred Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public double? preferredtocap { get; set; }

		/// <summary>
		/// Preferred Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalpreferredequity { get; set; }

		/// <summary>
		/// Preferred Stock Dividends Declared
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? preferreddividends { get; set; }

		/// <summary>
		/// Premises and Equipment, Net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? netpremisesandequipment { get; set; }

		/// <summary>
		/// Premiums Earned
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? premiumsearned { get; set; }

		/// <summary>
		/// Prepaid Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? prepaidexpenses { get; set; }

		/// <summary>
		/// Price Date
		/// Statement code: current, type: prices, units: date 
		/// </summary>
		public DateTime? price_date { get; set; }

		/// <summary>
		/// Price Time
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		public DateTime? price_time { get; set; }

		/// <summary>
		/// Price to Book Value (P/BV)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? pricetobook { get; set; }

		/// <summary>
		/// Price to Current Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? pricetocurrentyearearnings { get; set; }

		/// <summary>
		/// Price to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? pricetocurrentyearrevenue { get; set; }

		/// <summary>
		/// Price to Earnings (P/E)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? pricetoearnings { get; set; }

		/// <summary>
		/// Price to Next Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? pricetonextyearearnings { get; set; }

		/// <summary>
		/// Price to Next Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public double? pricetonextyearrevenue { get; set; }

		/// <summary>
		/// Price to Revenue (P/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? pricetorevenue { get; set; }

		/// <summary>
		/// Price to Tangible Book Value (P/TBV)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public double? pricetotangiblebook { get; set; }

		/// <summary>
		/// Profit (Net Income) Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? profitmargin { get; set; }

		/// <summary>
		/// Property & Liability Insurance Claims
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? propertyliabilityinsuranceclaims { get; set; }

		/// <summary>
		/// Provision for Credit Losses
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? provisionforcreditlosses { get; set; }

		/// <summary>
		/// Provision For Loan Losses
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? provisionforloanlosses { get; set; }

		/// <summary>
		/// Purchase of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? purchaseofinvestments { get; set; }

		/// <summary>
		/// Purchase of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? purchaseofplantpropertyandequipment { get; set; }

		/// <summary>
		/// Quick Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		public double? quickratio { get; set; }

		/// <summary>
		/// R&D to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? rdextorevenue { get; set; }

		/// <summary>
		/// Redeemable Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? redeemablenoncontrollinginterest { get; set; }

		/// <summary>
		/// Repayment of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? repaymentofdebt { get; set; }

		/// <summary>
		/// Repurchase of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? repurchaseofcommonequity { get; set; }

		/// <summary>
		/// Repurchase of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? repurchaseofpreferredequity { get; set; }

		/// <summary>
		/// Research & Development Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? rdexpense { get; set; }

		/// <summary>
		/// Restricted Cash
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? restrictedcash { get; set; }

		/// <summary>
		/// Restructuring Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? restructuringcharge { get; set; }

		/// <summary>
		/// Retained Earnings
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? retainedearnings { get; set; }

		/// <summary>
		/// Return on Assets (ROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? roa { get; set; }

		/// <summary>
		/// Return on Common Equity (ROCE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? roce { get; set; }

		/// <summary>
		/// Return on Equity (ROE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? roe { get; set; }

		/// <summary>
		/// Return on Invested Capital (ROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? roic { get; set; }

		/// <summary>
		/// Return on Net Nonoperating Assets (RNNOA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? rnnoa { get; set; }

		/// <summary>
		/// Revenue Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? revenuegrowth { get; set; }

		/// <summary>
		/// Revenue Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public double? revenueqoqgrowth { get; set; }

		/// <summary>
		/// ROIC Less NNEP Spread (ROIC-NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public double? roicnnepspread { get; set; }

		/// <summary>
		/// Salaries and Employee Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? salariesandemployeebenefitsexpense { get; set; }

		/// <summary>
		/// Sale and/or Maturity of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? saleofinvestments { get; set; }

		/// <summary>
		/// Sale of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public double? saleofplantpropertyandequipment { get; set; }

		/// <summary>
		/// SEC Centeral Index Key (CIK)
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string cik { get; set; }

		/// <summary>
		/// Sector
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string sector { get; set; }

		/// <summary>
		/// Security Class
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string security_class { get; set; }

		/// <summary>
		/// Security Name
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string security_name { get; set; }

		/// <summary>
		/// Security Round Lot Size
		/// Statement code: current, type: security, units: shares 
		/// </summary>
		public long? security_round_lot_size { get; set; }

		/// <summary>
		/// Security Ticker Symbol
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string security_ticker { get; set; }

		/// <summary>
		/// Security Type
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string security_type { get; set; }

		/// <summary>
		/// Selling, General & Admin Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? sgaexpense { get; set; }

		/// <summary>
		/// Separate Account Business Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? separateaccountbusinessassets { get; set; }

		/// <summary>
		/// Separate Account Business Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? separateaccountbusinessliabilities { get; set; }

		/// <summary>
		/// Service Charges on Deposit Accounts
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? servicechargesondepositsincome { get; set; }

		/// <summary>
		/// Seven Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? seven_yr_monthly_beta { get; set; }

		/// <summary>
		/// Seven Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? seven_yr_weekly_beta { get; set; }

		/// <summary>
		/// SG&A Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? sgaextorevenue { get; set; }

		/// <summary>
		/// Short Description
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string short_description { get; set; }

		/// <summary>
		/// Short Interest
		/// Statement code: current, type: short_interest, units: shares 
		/// </summary>
		public long? short_interest { get; set; }

		/// <summary>
		/// Short-Term Borrowings Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? shorttermborrowinginterestexpense { get; set; }

		/// <summary>
		/// Short-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? shorttermdebt { get; set; }

		/// <summary>
		/// Short-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public double? stdebttocap { get; set; }

		/// <summary>
		/// Short-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public double? shortterminvestments { get; set; }

		/// <summary>
		/// Split Ratio
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		public double? split_ratio { get; set; }

		/// <summary>
		/// Standard Industrial Classification Code (SIC)
		/// Statement code: current, type: info, units: integer 
		/// </summary>
		public int sic { get; set; }

		/// <summary>
		/// State
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string state { get; set; }

		/// <summary>
		/// Stock Exchange
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		/// Tangible Book Value per Share
		/// Statement code: calculations, type: metric, units: usdpershare 
		/// </summary>
		public double? tangbookvaluepershare { get; set; }

		/// <summary>
		/// Tax Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public double? taxburdenpct { get; set; }

		/// <summary>
		/// Template
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string template { get; set; }

		/// <summary>
		/// Ten Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? ten_yr_monthly_beta { get; set; }

		/// <summary>
		/// Ten Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? ten_yr_weekly_beta { get; set; }

		/// <summary>
		/// Three Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? three_yr_monthly_beta { get; set; }

		/// <summary>
		/// Three Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public double? three_yr_weekly_beta { get; set; }

		/// <summary>
		/// Ticker Symbol
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		/// Time Deposits Placed and Other Short-Term Investments
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? timedepositsplaced { get; set; }

		/// <summary>
		/// Total Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalassets { get; set; }

		/// <summary>
		/// Total Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? totalcapital { get; set; }

		/// <summary>
		/// Total Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalcommonequity { get; set; }

		/// <summary>
		/// Total Cost of Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totalcostofrevenue { get; set; }

		/// <summary>
		/// Total Current Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalcurrentassets { get; set; }

		/// <summary>
		/// Total Current Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalcurrentliabilities { get; set; }

		/// <summary>
		/// Total Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? debt { get; set; }

		/// <summary>
		/// Total Depreciation and Amortization (D&A)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? depreciationandamortization { get; set; }

		/// <summary>
		/// Total Equity & Noncontrolling Interests
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalequityandnoncontrollinginterests { get; set; }

		/// <summary>
		/// Total Gross Profit
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totalgrossprofit { get; set; }

		/// <summary>
		/// Total Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalliabilities { get; set; }

		/// <summary>
		/// Total Liabilities & Shareholders’ Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalliabilitiesandequity { get; set; }

		/// <summary>
		/// Total Long-Term Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public double? ltdebtandcapleases { get; set; }

		/// <summary>
		/// Total Non-Interest Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totalnoninterestexpense { get; set; }

		/// <summary>
		/// Total Non-Interest Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totalnoninterestincome { get; set; }

		/// <summary>
		/// Total Noncurrent Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalnoncurrentassets { get; set; }

		/// <summary>
		/// Total Noncurrent Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalnoncurrentliabilities { get; set; }

		/// <summary>
		/// Total Operating Expenses
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totaloperatingexpenses { get; set; }

		/// <summary>
		/// Total Operating Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totaloperatingincome { get; set; }

		/// <summary>
		/// Total Other Income / (Expense), net
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totalotherincome { get; set; }

		/// <summary>
		/// Total Pre-Tax Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totalpretaxincome { get; set; }

		/// <summary>
		/// Total Preferred & Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? totalequity { get; set; }

		/// <summary>
		/// Total Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public double? totalrevenue { get; set; }

		/// <summary>
		/// Trading Account Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? tradingaccountinterestincome { get; set; }

		/// <summary>
		/// Trading Account Securities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? tradingaccountsecurities { get; set; }

		/// <summary>
		/// Trailing Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public double? dividend_rate { get; set; }

		/// <summary>
		/// Trailing Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public double? trailing_dividend_yield { get; set; }

		/// <summary>
		/// Treasury Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public double? treasurystock { get; set; }

		/// <summary>
		/// Trust Fees by Commissions
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public double? trustfeeincome { get; set; }

		/// <summary>
		/// Unearned Premiums Asset
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? unearnedpremiumsdebit { get; set; }

		/// <summary>
		/// Unearned Premiums Liability
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public double? unearnedpremiumscredit { get; set; }

		/// <summary>
		/// Volume
		/// Statement code: current, type: prices, units: shares 
		/// </summary>
		public long? volume { get; set; }

		/// <summary>
		/// Weighted Average Basic & Diluted Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		public long? weightedavebasicdilutedsharesos { get; set; }

		/// <summary>
		/// Weighted Average Basic Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		public long? weightedavebasicsharesos { get; set; }

		/// <summary>
		/// Weighted Average Diluted Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		public long? weightedavedilutedsharesos { get; set; }


	}

}
