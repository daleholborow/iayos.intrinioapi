using System;
using iayos.intrinioapi.ServiceModel.Enums;

namespace iayos.intrinioapi.ServiceModel.Dtos
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
		public bool etf { get; set; }

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
				public decimal? 52_week_high { get; set; }

				/// <summary>
				/// 52 Week Low
				/// Statement code: current, type: prices, units: usdpershare 
				/// </summary>
				public decimal? 52_week_low { get; set; }
		*/

		/// <summary>
		/// Accounts Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? accountspayable { get; set; }

		/// <summary>
		/// Accounts Payable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public decimal? apturnover { get; set; }

		/// <summary>
		/// Accounts Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? accountsreceivable { get; set; }

		/// <summary>
		/// Accounts Receivable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public decimal? arturnover { get; set; }

		/// <summary>
		/// Accrued Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? accruedexpenses { get; set; }

		/// <summary>
		/// Accrued Interest Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? accruedinterestpayable { get; set; }

		/// <summary>
		/// Accrued Investment Income
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? accruedinvestmentincome { get; set; }

		/// <summary>
		/// Accumulated Depreciation
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? accumulateddepreciation { get; set; }

		/// <summary>
		/// Accumulated Other Comprehensive Income / (Loss)
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? aoci { get; set; }

		/// <summary>
		/// Acquisitions
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? acquisitions { get; set; }

		/// <summary>
		/// Adjusted Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? adj_close_price { get; set; }

		/// <summary>
		/// Adjusted High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? adj_high_price { get; set; }

		/// <summary>
		/// Adjusted Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? adj_low_price { get; set; }

		/// <summary>
		/// Adjusted Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? adj_open_price { get; set; }

		/// <summary>
		/// Adjusted Volume
		/// Statement code: current, type: prices, units: shares 
		/// </summary>
		public long? adj_volume { get; set; }

		/// <summary>
		/// Allowance for Loan and Lease Losses
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? allowanceforloanandleaselosses { get; set; }

		/// <summary>
		/// Altman Z-Score
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public decimal? altmanzscore { get; set; }

		/// <summary>
		/// Amortization Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? amortizationexpense { get; set; }

		/// <summary>
		/// Amortization of Deferred Policy Acquisition Costs
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? amortizationofdeferredpolicyacquisitioncosts { get; set; }

		/// <summary>
		/// Ask Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? ask_price { get; set; }

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
		public decimal? assetretirementandlitigationobligation { get; set; }

		/// <summary>
		/// Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public decimal? assetturnover { get; set; }

		/// <summary>
		/// Augmented Payout Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? augmentedpayoutratio { get; set; }

		/// <summary>
		/// Average Daily Volume
		/// Statement code: current, type: short_interest, units: shares 
		/// </summary>
		public long? average_daily_volume { get; set; }

		/// <summary>
		/// Bankers Acceptance Outstanding
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? bankersacceptances { get; set; }

		/// <summary>
		/// Basic & Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public decimal? basicdilutedeps { get; set; }

		/// <summary>
		/// Basic Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public decimal? basiceps { get; set; }

		/// <summary>
		/// Beta
		/// Statement code: current, type: info, units: float 
		/// </summary>
		public decimal? beta { get; set; }

		/// <summary>
		/// Bid Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? bid_price { get; set; }

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
		public decimal? bookvaluepershare { get; set; }

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
		public decimal? capex { get; set; }

		/// <summary>
		/// Capital Lease Obligations
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? capitalleaseobligations { get; set; }

		/// <summary>
		/// Capitalized Lease Obligations Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? capitalizedleaseobligationinterestexpense { get; set; }

		/// <summary>
		/// Cash & Equivalents
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? cashandequivalents { get; set; }

		/// <summary>
		/// Cash Conversion Cycle (CCC)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public int ccc { get; set; }

		/// <summary>
		/// Cash Dividends to Common per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public decimal? cashdividendspershare { get; set; }

		/// <summary>
		/// Cash Income Taxes Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? cashincometaxespaid { get; set; }

		/// <summary>
		/// Cash Interest Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? cashinterestpaid { get; set; }

		/// <summary>
		/// Cash Interest Received
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? cashinterestreceived { get; set; }

		/// <summary>
		/// Cash Return on Invested Capital (CROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? croic { get; set; }

		/// <summary>
		/// Change in Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? change { get; set; }

		/// <summary>
		/// Changes in Operating Assets and Liabilities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? increasedecreaseinoperatingcapital { get; set; }

		/// <summary>
		/// Chief Executive Officer (CEO)
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string ceo { get; set; }

		/// <summary>
		/// Claims and Claim Expense
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? claimsandclaimexpenses { get; set; }

		/// <summary>
		/// Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? close_price { get; set; }

		/// <summary>
		/// Commitments & Contingencies
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? commitmentsandcontingencies { get; set; }

		/// <summary>
		/// Common Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public decimal? commontocap { get; set; }

		/// <summary>
		/// Common Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? commonequity { get; set; }

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
		public decimal? compoundleveragefactor { get; set; }

		/// <summary>
		/// Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? netincome { get; set; }

		/// <summary>
		/// Cost of Revenue to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? costofrevtorevenue { get; set; }

		/// <summary>
		/// Country
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string country { get; set; }

		/// <summary>
		/// Current and Future Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? currentandfuturebenefits { get; set; }

		/// <summary>
		/// Current Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? currentdeferredtaxliabilities { get; set; }

		/// <summary>
		/// Current Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? currentdeferredtaxassets { get; set; }

		/// <summary>
		/// Current Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? currentdeferredrevenue { get; set; }

		/// <summary>
		/// Current Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? currentemployeebenefitliabilities { get; set; }

		/// <summary>
		/// Current Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		public decimal? currentratio { get; set; }

		/// <summary>
		/// Current Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? currentyearearningsyield { get; set; }

		/// <summary>
		/// Customer and Other Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? customerandotherreceivables { get; set; }

		/// <summary>
		/// Customer Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? customerdeposits { get; set; }

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
		public decimal? debttoebitda { get; set; }

		/// <summary>
		/// Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public decimal? debttoequity { get; set; }

		/// <summary>
		/// Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public decimal? debttonopat { get; set; }

		/// <summary>
		/// Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public decimal? debttototalcapital { get; set; }

		/// <summary>
		/// Debt-free Net Working Capital (DFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? dfnwc { get; set; }

		/// <summary>
		/// Debt-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public decimal? dfnwctorev { get; set; }

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital (DFCFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? dfcfnwc { get; set; }

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public decimal? dfcfnwctorev { get; set; }

		/// <summary>
		/// Deferred Acquisition Cost
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? deferredacquisitioncost { get; set; }

		/// <summary>
		/// Depletion Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? depletionexpense { get; set; }

		/// <summary>
		/// Deposits and Money Market Investments Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? depositsinterestincome { get; set; }

		/// <summary>
		/// Deposits Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? depositsinterestexpense { get; set; }

		/// <summary>
		/// Depreciation Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? depreciationexpense { get; set; }

		/// <summary>
		/// Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public decimal? dilutedeps { get; set; }

		/// <summary>
		/// Divestitures
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? divestitures { get; set; }

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
		public decimal? divpayoutratio { get; set; }

		/// <summary>
		/// Dividend per Share
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public decimal? dividend { get; set; }

		/// <summary>
		/// Dividend Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		public decimal? dividendyield { get; set; }

		/// <summary>
		/// Dividends Payable
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? dividendspayable { get; set; }

		/// <summary>
		/// Earnings before Interest and Taxes (EBIT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? ebit { get; set; }

		/// <summary>
		/// Earnings before Interest, Taxes, Depreciation and Amortization (EBITDA)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? ebitda { get; set; }

		/// <summary>
		/// Earnings Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		public decimal? earningsyield { get; set; }

		/// <summary>
		/// EBIT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? ebitgrowth { get; set; }

		/// <summary>
		/// EBIT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public decimal? ebitlesscapextointerestex { get; set; }

		/// <summary>
		/// EBIT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? ebitmargin { get; set; }

		/// <summary>
		/// EBIT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? ebitqoqgrowth { get; set; }

		/// <summary>
		/// EBIT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public decimal? ebittointerestex { get; set; }

		/// <summary>
		/// EBITDA Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? ebitdagrowth { get; set; }

		/// <summary>
		/// EBITDA Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? ebitdamargin { get; set; }

		/// <summary>
		/// EBITDA Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? ebitdaqoqgrowth { get; set; }

		/// <summary>
		/// Effect of Exchange Rate Changes
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? effectofexchangeratechanges { get; set; }

		/// <summary>
		/// Effective Tax Rate
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? efftaxrate { get; set; }

		/// <summary>
		/// Employee Benefit Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? employeebenefitassets { get; set; }

		/// <summary>
		/// Employees
		/// Statement code: current, type: info, units: integer 
		/// </summary>
		public int employees { get; set; }

		/// <summary>
		/// Enterprise Value (EV)
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		public decimal? enterprisevalue { get; set; }

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtocurrentyearrevenue { get; set; }

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtonextyearrevenue { get; set; }

		/// <summary>
		/// Enterprise Value to EBIT (EV/EBIT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtoebit { get; set; }

		/// <summary>
		/// Enterprise Value to EBITDA (EV/EBITDA)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtoebitda { get; set; }

		/// <summary>
		/// Enterprise Value to Free Cash Flow (EV/FCFF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtofcff { get; set; }

		/// <summary>
		/// Enterprise Value to Invested Capital (EV/IC)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtoinvestedcapital { get; set; }

		/// <summary>
		/// Enterprise Value to NOPAT (EV/NOPAT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtonopat { get; set; }

		/// <summary>
		/// Enterprise Value to Operating Cash Flow (EV/OCF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtoocf { get; set; }

		/// <summary>
		/// Enterprise Value to Revenue (EV/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? evtorevenue { get; set; }

		/// <summary>
		/// EPS Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? epsgrowth { get; set; }

		/// <summary>
		/// EPS Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? epsqoqgrowth { get; set; }

		/// <summary>
		/// Ex Dividend
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		public decimal? ex_dividend { get; set; }

		/// <summary>
		/// Exchange Financial Status
		/// Statement code: current, type: security, units: boolean 
		/// </summary>
		public bool exchange_status { get; set; }

		/// <summary>
		/// Exploration Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? explorationexpense { get; set; }

		/// <summary>
		/// Extraordinary Income / (Loss), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public decimal? extraordinaryincome { get; set; }

		/// <summary>
		/// Federal Funds Purchased and Securities Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? fedfundspurchased { get; set; }

		/// <summary>
		/// Federal Funds Purchased and Securities Sold Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? fedfundsandrepointerestexpense { get; set; }

		/// <summary>
		/// Federal Funds Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? fedfundssold { get; set; }

		/// <summary>
		/// Federal Funds Sold and Securities Borrowed Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? fedfundsandrepointerestincome { get; set; }

		/// <summary>
		/// Financial Leverage
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public decimal? finleverage { get; set; }

		/// <summary>
		/// Five Year Average Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public decimal? five_yr_ave_dividend_yield { get; set; }

		/// <summary>
		/// Five Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? five_yr_monthly_beta { get; set; }

		/// <summary>
		/// Five Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? five_yr_weekly_beta { get; set; }

		/// <summary>
		/// Fixed Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public decimal? faturnover { get; set; }

		/// <summary>
		/// Forward Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public decimal? forward_dividend_rate { get; set; }

		/// <summary>
		/// Forward Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public decimal? forward_dividend_yield { get; set; }

		/// <summary>
		/// Free Cash Flow Firm Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? fcffgrowth { get; set; }

		/// <summary>
		/// Free Cash Flow Firm Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? fcffqoqgrowth { get; set; }

		/// <summary>
		/// Free Cash Flow to Firm (FCFF)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? freecashflow { get; set; }

		/// <summary>
		/// Free Cash Flow to Firm to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public decimal? fcfftointerestex { get; set; }

		/// <summary>
		/// Future Policy Benefits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? futurepolicybenefits { get; set; }

		/// <summary>
		/// Goodwill
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? goodwill { get; set; }

		/// <summary>
		/// Gross Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? grossmargin { get; set; }

		/// <summary>
		/// High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? high_price { get; set; }

		/// <summary>
		/// Impairment Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? impairmentexpense { get; set; }

		/// <summary>
		/// Income Tax Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? incometaxexpense { get; set; }

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
		public decimal? investedcapitalincreasedecrease { get; set; }

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
		public decimal? policyacquisitioncosts { get; set; }

		/// <summary>
		/// Intangible Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? intangibleassets { get; set; }

		/// <summary>
		/// Interest & Investment Income
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public decimal? totalinterestincome { get; set; }

		/// <summary>
		/// Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? interestbearingdeposits { get; set; }

		/// <summary>
		/// Interest Bearing Deposits at Other Banks
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? interestbearingdepositsatotherbanks { get; set; }

		/// <summary>
		/// Interest Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? interestburdenpct { get; set; }

		/// <summary>
		/// Interest Expense
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public decimal? totalinterestexpense { get; set; }

		/// <summary>
		/// Inventories, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? netinventory { get; set; }

		/// <summary>
		/// Inventory Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public decimal? invturnover { get; set; }

		/// <summary>
		/// Invested Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? investedcapital { get; set; }

		/// <summary>
		/// Invested Capital Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? investedcapitalgrowth { get; set; }

		/// <summary>
		/// Invested Capital Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? investedcapitalqoqgrowth { get; set; }

		/// <summary>
		/// Invested Capital Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public decimal? investedcapitalturnover { get; set; }

		/// <summary>
		/// Investment Banking Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? investmentbankingincome { get; set; }

		/// <summary>
		/// Investment Securities Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? investmentsecuritiesinterestincome { get; set; }

		/// <summary>
		/// Issuance of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? issuanceofcommonequity { get; set; }

		/// <summary>
		/// Issuance of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? issuanceofdebt { get; set; }

		/// <summary>
		/// Issuance of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? issuanceofpreferredequity { get; set; }

		/// <summary>
		/// Leverage Ratio
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public decimal? leverageratio { get; set; }

		/// <summary>
		/// Listing Exchange
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string listing_exchange { get; set; }

		/// <summary>
		/// Loans and Leases
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? loansandleases { get; set; }

		/// <summary>
		/// Loans and Leases Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? loansandleaseinterestincome { get; set; }

		/// <summary>
		/// Loans and Leases, Net of Allowance
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? netloansandleases { get; set; }

		/// <summary>
		/// Loans Held for Sale
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? loansheldforsale { get; set; }

		/// <summary>
		/// Loans Held for Sale, Net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? loansheldforsalenet { get; set; }

		/// <summary>
		/// Long Description
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string long_description { get; set; }

		/// <summary>
		/// Long-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? longtermdebt { get; set; }

		/// <summary>
		/// Long-Term Debt Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? longtermdebtinterestexpense { get; set; }

		/// <summary>
		/// Long-Term Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public decimal? ltdebttoebitda { get; set; }

		/// <summary>
		/// Long-Term Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public decimal? ltdebttoequity { get; set; }

		/// <summary>
		/// Long-Term Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public decimal? ltdebttonopat { get; set; }

		/// <summary>
		/// Long-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public decimal? ltdebttocap { get; set; }

		/// <summary>
		/// Long-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? longterminvestments { get; set; }

		/// <summary>
		/// Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? low_price { get; set; }

		/// <summary>
		/// Mailing Address
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string mailing_address { get; set; }

		/// <summary>
		/// Market Capitalization
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		public decimal? marketcap { get; set; }

		/// <summary>
		/// Market Category
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public string market_category { get; set; }

		/// <summary>
		/// Marketing Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? marketingexpense { get; set; }

		/// <summary>
		/// Mortgage Servicing Rights
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? mortgageservicingrights { get; set; }

		/// <summary>
		/// Net Cash From Continuing Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromcontinuingfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Continuing Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromcontinuinginvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Continuing Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromcontinuingoperatingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromdiscontinuedfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromdiscontinuedinvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromdiscontinuedoperatingactivities { get; set; }

		/// <summary>
		/// Net Cash From Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfrominvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netcashfromoperatingactivities { get; set; }

		/// <summary>
		/// Net Change in Cash & Equivalents
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netchangeincash { get; set; }

		/// <summary>
		/// Net Change in Deposits
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netchangeindeposits { get; set; }

		/// <summary>
		/// Net Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? netdebt { get; set; }

		/// <summary>
		/// Net Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public decimal? netdebttoebitda { get; set; }

		/// <summary>
		/// Net Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public decimal? netdebttonopat { get; set; }

		/// <summary>
		/// Net Income / (Loss) Attributable to Common Shareholders
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? netincometocommon { get; set; }

		/// <summary>
		/// Net Income / (Loss) Attributable to Noncontrolling Interest
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? netincometononcontrollinginterest { get; set; }

		/// <summary>
		/// Net Income / (Loss) Continuing Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? netincomecontinuing { get; set; }

		/// <summary>
		/// Net Income / (Loss) Discontinued Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? netincomediscontinued { get; set; }

		/// <summary>
		/// Net Income Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? netincomegrowth { get; set; }

		/// <summary>
		/// Net Income Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? netincomeqoqgrowth { get; set; }

		/// <summary>
		/// Net Increase in Fed Funds Sold
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? netincreaseinfedfundssold { get; set; }

		/// <summary>
		/// Net Interest Income / (Expense)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? netinterestincome { get; set; }

		/// <summary>
		/// Net Nonoperating Expense (NNE)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? netnonopex { get; set; }

		/// <summary>
		/// Net Nonoperating Expense Percent (NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? nnep { get; set; }

		/// <summary>
		/// Net Nonoperating Obligations (NNO)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? netnonopobligations { get; set; }

		/// <summary>
		/// Net Occupancy & Equipment Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? netoccupancyequipmentexpense { get; set; }

		/// <summary>
		/// Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? nopat { get; set; }

		/// <summary>
		/// Net Realized & Unrealized Capital Gains on Investments
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? netrealizedcapitalgains { get; set; }

		/// <summary>
		/// Net Working Capital (NWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? nwc { get; set; }

		/// <summary>
		/// Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public decimal? nwctorev { get; set; }

		/// <summary>
		/// Next Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? nextyearearningsyield { get; set; }

		/// <summary>
		/// Non-Cash Adjustments To Reconcile Net Income
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? noncashadjustmentstonetincome { get; set; }

		/// <summary>
		/// Non-Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? noninterestbearingdeposits { get; set; }

		/// <summary>
		/// Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? noncontrollinginterests { get; set; }

		/// <summary>
		/// Noncontrolling Interest Sharing Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? noncontrollinginterestsharingratio { get; set; }

		/// <summary>
		/// Noncontrolling Interests to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public decimal? noncontrolinttocap { get; set; }

		/// <summary>
		/// Noncurrent Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? noncurrentdeferredtaxliabilities { get; set; }

		/// <summary>
		/// Noncurrent Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? noncurrentdeferredtaxassets { get; set; }

		/// <summary>
		/// Noncurrent Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? noncurrentdeferredrevenue { get; set; }

		/// <summary>
		/// Noncurrent Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? noncurrentemployeebenefitliabilities { get; set; }

		/// <summary>
		/// Noncurrent Note & Lease Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? noncurrentnotereceivables { get; set; }

		/// <summary>
		/// Nonoperating Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public decimal? nonoperatingincome { get; set; }

		/// <summary>
		/// NOPAT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? nopatgrowth { get; set; }

		/// <summary>
		/// NOPAT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public decimal? nopatlesscapextointex { get; set; }

		/// <summary>
		/// NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? nopatmargin { get; set; }

		/// <summary>
		/// NOPAT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? nopatqoqgrowth { get; set; }

		/// <summary>
		/// NOPAT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public decimal? nopattointerestex { get; set; }

		/// <summary>
		/// Normalized Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? normalizednopat { get; set; }

		/// <summary>
		/// Normalized NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? normalizednopatmargin { get; set; }

		/// <summary>
		/// Note & Lease Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? notereceivable { get; set; }

		/// <summary>
		/// One Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? one_yr_monthly_beta { get; set; }

		/// <summary>
		/// One Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? one_yr_weekly_beta { get; set; }

		/// <summary>
		/// Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public decimal? open_price { get; set; }

		/// <summary>
		/// Operating Cash Flow Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? ocfgrowth { get; set; }

		/// <summary>
		/// Operating Cash Flow Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public decimal? ocflesscapextointerestex { get; set; }

		/// <summary>
		/// Operating Cash Flow Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? ocfqoqgrowth { get; set; }

		/// <summary>
		/// Operating Cash Flow to CapEx
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? ocftocapex { get; set; }

		/// <summary>
		/// Operating Cash Flow to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public decimal? ocftointerestex { get; set; }

		/// <summary>
		/// Operating Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? operatingcostofrevenue { get; set; }

		/// <summary>
		/// Operating Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? opextorevenue { get; set; }

		/// <summary>
		/// Operating Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? operatingmargin { get; set; }

		/// <summary>
		/// Operating Return on Assets (OROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? oroa { get; set; }

		/// <summary>
		/// Operating Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? operatingrevenue { get; set; }

		/// <summary>
		/// Other Adjustments to Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? otheradjustmentstoconsolidatednetincome { get; set; }

		/// <summary>
		/// Other Adjustments to Net Income / (Loss) Attributable to Common Shareholders)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? otheradjustmentstonetincometocommon { get; set; }

		/// <summary>
		/// Other Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? otherassets { get; set; }

		/// <summary>
		/// Other Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? othercostofrevenue { get; set; }

		/// <summary>
		/// Other Current Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? othercurrentassets { get; set; }

		/// <summary>
		/// Other Current Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? othercurrentliabilities { get; set; }

		/// <summary>
		/// Other Current Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? othercurrentnonoperatingassets { get; set; }

		/// <summary>
		/// Other Current Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? othercurrentnonoperatingliabilities { get; set; }

		/// <summary>
		/// Other Equity Adjustments
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? otherequity { get; set; }

		/// <summary>
		/// Other Financing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? otherfinancingactivitiesnet { get; set; }

		/// <summary>
		/// Other Gains / (Losses), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public decimal? othergains { get; set; }

		/// <summary>
		/// Other Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public decimal? otherincome { get; set; }

		/// <summary>
		/// Other Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? otherinterestexpense { get; set; }

		/// <summary>
		/// Other Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? otherinterestincome { get; set; }

		/// <summary>
		/// Other Investing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? otherinvestingactivitiesnet { get; set; }

		/// <summary>
		/// Other Long-Term Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? otherlongtermliabilities { get; set; }

		/// <summary>
		/// Other Net Changes in Cash
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? othernetchangesincash { get; set; }

		/// <summary>
		/// Other Non-Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? othernoninterestincome { get; set; }

		/// <summary>
		/// Other Noncurrent Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? othernoncurrentnonoperatingassets { get; set; }

		/// <summary>
		/// Other Noncurrent Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? othernoncurrentnonoperatingliabilities { get; set; }

		/// <summary>
		/// Other Noncurrent Operating Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? othernoncurrentassets { get; set; }

		/// <summary>
		/// Other Noncurrent Operating Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? othernoncurrentliabilities { get; set; }

		/// <summary>
		/// Other Operating Expenses / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? otheroperatingexpenses { get; set; }

		/// <summary>
		/// Other Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? otherrevenue { get; set; }

		/// <summary>
		/// Other Service Charges
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? otherservicechargeincome { get; set; }

		/// <summary>
		/// Other Short-Term Payables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? othershorttermpayables { get; set; }

		/// <summary>
		/// Other Special Charges / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? otherspecialcharges { get; set; }

		/// <summary>
		/// Other Taxes Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? othertaxespayable { get; set; }

		/// <summary>
		/// Participating Policy Holder Equity
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? participatingpolicyholderequity { get; set; }

		/// <summary>
		/// Payment of Dividends
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? paymentofdividends { get; set; }

		/// <summary>
		/// Percent Change in Price
		/// Statement code: current, type: prices, units: percentage 
		/// </summary>
		public decimal? percent_change { get; set; }

		/// <summary>
		/// Plant, Property & Equipment, gross
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? grossppe { get; set; }

		/// <summary>
		/// Plant, Property, & Equipment, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? netppe { get; set; }

		/// <summary>
		/// Policy Holder Funds
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? policyholderfunds { get; set; }

		/// <summary>
		/// Pre Tax Income Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? pretaxincomemargin { get; set; }

		/// <summary>
		/// Preferred Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public decimal? preferredtocap { get; set; }

		/// <summary>
		/// Preferred Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalpreferredequity { get; set; }

		/// <summary>
		/// Preferred Stock Dividends Declared
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? preferreddividends { get; set; }

		/// <summary>
		/// Premises and Equipment, Net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? netpremisesandequipment { get; set; }

		/// <summary>
		/// Premiums Earned
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? premiumsearned { get; set; }

		/// <summary>
		/// Prepaid Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? prepaidexpenses { get; set; }

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
		public decimal? pricetobook { get; set; }

		/// <summary>
		/// Price to Current Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? pricetocurrentyearearnings { get; set; }

		/// <summary>
		/// Price to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? pricetocurrentyearrevenue { get; set; }

		/// <summary>
		/// Price to Earnings (P/E)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? pricetoearnings { get; set; }

		/// <summary>
		/// Price to Next Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? pricetonextyearearnings { get; set; }

		/// <summary>
		/// Price to Next Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public decimal? pricetonextyearrevenue { get; set; }

		/// <summary>
		/// Price to Revenue (P/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? pricetorevenue { get; set; }

		/// <summary>
		/// Price to Tangible Book Value (P/TBV)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public decimal? pricetotangiblebook { get; set; }

		/// <summary>
		/// Profit (Net Income) Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? profitmargin { get; set; }

		/// <summary>
		/// Property & Liability Insurance Claims
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? propertyliabilityinsuranceclaims { get; set; }

		/// <summary>
		/// Provision for Credit Losses
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? provisionforcreditlosses { get; set; }

		/// <summary>
		/// Provision For Loan Losses
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? provisionforloanlosses { get; set; }

		/// <summary>
		/// Purchase of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? purchaseofinvestments { get; set; }

		/// <summary>
		/// Purchase of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? purchaseofplantpropertyandequipment { get; set; }

		/// <summary>
		/// Quick Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		public decimal? quickratio { get; set; }

		/// <summary>
		/// R&D to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? rdextorevenue { get; set; }

		/// <summary>
		/// Redeemable Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? redeemablenoncontrollinginterest { get; set; }

		/// <summary>
		/// Repayment of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? repaymentofdebt { get; set; }

		/// <summary>
		/// Repurchase of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? repurchaseofcommonequity { get; set; }

		/// <summary>
		/// Repurchase of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? repurchaseofpreferredequity { get; set; }

		/// <summary>
		/// Research & Development Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? rdexpense { get; set; }

		/// <summary>
		/// Restricted Cash
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? restrictedcash { get; set; }

		/// <summary>
		/// Restructuring Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? restructuringcharge { get; set; }

		/// <summary>
		/// Retained Earnings
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? retainedearnings { get; set; }

		/// <summary>
		/// Return on Assets (ROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? roa { get; set; }

		/// <summary>
		/// Return on Common Equity (ROCE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? roce { get; set; }

		/// <summary>
		/// Return on Equity (ROE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? roe { get; set; }

		/// <summary>
		/// Return on Invested Capital (ROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? roic { get; set; }

		/// <summary>
		/// Return on Net Nonoperating Assets (RNNOA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? rnnoa { get; set; }

		/// <summary>
		/// Revenue Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? revenuegrowth { get; set; }

		/// <summary>
		/// Revenue Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public decimal? revenueqoqgrowth { get; set; }

		/// <summary>
		/// ROIC Less NNEP Spread (ROIC-NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public decimal? roicnnepspread { get; set; }

		/// <summary>
		/// Salaries and Employee Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? salariesandemployeebenefitsexpense { get; set; }

		/// <summary>
		/// Sale and/or Maturity of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? saleofinvestments { get; set; }

		/// <summary>
		/// Sale of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public decimal? saleofplantpropertyandequipment { get; set; }

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
		public decimal? sgaexpense { get; set; }

		/// <summary>
		/// Separate Account Business Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? separateaccountbusinessassets { get; set; }

		/// <summary>
		/// Separate Account Business Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? separateaccountbusinessliabilities { get; set; }

		/// <summary>
		/// Service Charges on Deposit Accounts
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? servicechargesondepositsincome { get; set; }

		/// <summary>
		/// Seven Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? seven_yr_monthly_beta { get; set; }

		/// <summary>
		/// Seven Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? seven_yr_weekly_beta { get; set; }

		/// <summary>
		/// SG&A Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? sgaextorevenue { get; set; }

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
		public decimal? shorttermborrowinginterestexpense { get; set; }

		/// <summary>
		/// Short-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? shorttermdebt { get; set; }

		/// <summary>
		/// Short-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public decimal? stdebttocap { get; set; }

		/// <summary>
		/// Short-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public decimal? shortterminvestments { get; set; }

		/// <summary>
		/// Split Ratio
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		public decimal? split_ratio { get; set; }

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
		public decimal? tangbookvaluepershare { get; set; }

		/// <summary>
		/// Tax Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public decimal? taxburdenpct { get; set; }

		/// <summary>
		/// Template
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string template { get; set; }

		/// <summary>
		/// Ten Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? ten_yr_monthly_beta { get; set; }

		/// <summary>
		/// Ten Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? ten_yr_weekly_beta { get; set; }

		/// <summary>
		/// Three Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? three_yr_monthly_beta { get; set; }

		/// <summary>
		/// Three Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public decimal? three_yr_weekly_beta { get; set; }

		/// <summary>
		/// Ticker Symbol
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		/// Time Deposits Placed and Other Short-Term Investments
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? timedepositsplaced { get; set; }

		/// <summary>
		/// Total Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalassets { get; set; }

		/// <summary>
		/// Total Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? totalcapital { get; set; }

		/// <summary>
		/// Total Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalcommonequity { get; set; }

		/// <summary>
		/// Total Cost of Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totalcostofrevenue { get; set; }

		/// <summary>
		/// Total Current Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalcurrentassets { get; set; }

		/// <summary>
		/// Total Current Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalcurrentliabilities { get; set; }

		/// <summary>
		/// Total Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? debt { get; set; }

		/// <summary>
		/// Total Depreciation and Amortization (D&A)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? depreciationandamortization { get; set; }

		/// <summary>
		/// Total Equity & Noncontrolling Interests
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalequityandnoncontrollinginterests { get; set; }

		/// <summary>
		/// Total Gross Profit
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totalgrossprofit { get; set; }

		/// <summary>
		/// Total Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalliabilities { get; set; }

		/// <summary>
		/// Total Liabilities & Shareholders’ Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalliabilitiesandequity { get; set; }

		/// <summary>
		/// Total Long-Term Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public decimal? ltdebtandcapleases { get; set; }

		/// <summary>
		/// Total Non-Interest Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totalnoninterestexpense { get; set; }

		/// <summary>
		/// Total Non-Interest Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totalnoninterestincome { get; set; }

		/// <summary>
		/// Total Noncurrent Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalnoncurrentassets { get; set; }

		/// <summary>
		/// Total Noncurrent Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalnoncurrentliabilities { get; set; }

		/// <summary>
		/// Total Operating Expenses
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totaloperatingexpenses { get; set; }

		/// <summary>
		/// Total Operating Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totaloperatingincome { get; set; }

		/// <summary>
		/// Total Other Income / (Expense), net
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totalotherincome { get; set; }

		/// <summary>
		/// Total Pre-Tax Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totalpretaxincome { get; set; }

		/// <summary>
		/// Total Preferred & Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? totalequity { get; set; }

		/// <summary>
		/// Total Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public decimal? totalrevenue { get; set; }

		/// <summary>
		/// Trading Account Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? tradingaccountinterestincome { get; set; }

		/// <summary>
		/// Trading Account Securities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? tradingaccountsecurities { get; set; }

		/// <summary>
		/// Trailing Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public decimal? dividend_rate { get; set; }

		/// <summary>
		/// Trailing Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public decimal? trailing_dividend_yield { get; set; }

		/// <summary>
		/// Treasury Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public decimal? treasurystock { get; set; }

		/// <summary>
		/// Trust Fees by Commissions
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public decimal? trustfeeincome { get; set; }

		/// <summary>
		/// Unearned Premiums Asset
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? unearnedpremiumsdebit { get; set; }

		/// <summary>
		/// Unearned Premiums Liability
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public decimal? unearnedpremiumscredit { get; set; }

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
