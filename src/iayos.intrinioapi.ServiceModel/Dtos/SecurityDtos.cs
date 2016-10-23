using iayos.intrinioapi.ServiceModel.Enums;

namespace iayos.intrinioapi.ServiceModel.Dtos
{
	public class SecurityMasterDto
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
		public string last_crsp_adj_date { get; set; }
	}


	/// <summary>
	/// http://docs.intrinio.com/#securities-search-screener
	/// </summary>
	public class SecurityDetailDto
	{

		/// <summary>
		/// 52 Week High
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		//public object 52_week_high { get; set; }

		/// <summary>
		/// 52 Week Low
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		//public object 52_week_low { get; set; }

		/// <summary>
		/// Accounts Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object accountspayable { get; set; }

		/// <summary>
		/// Accounts Payable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public object apturnover { get; set; }

		/// <summary>
		/// Accounts Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object accountsreceivable { get; set; }

		/// <summary>
		/// Accounts Receivable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public object arturnover { get; set; }

		/// <summary>
		/// Accrued Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object accruedexpenses { get; set; }

		/// <summary>
		/// Accrued Interest Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object accruedinterestpayable { get; set; }

		/// <summary>
		/// Accrued Investment Income
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object accruedinvestmentincome { get; set; }

		/// <summary>
		/// Accumulated Depreciation
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object accumulateddepreciation { get; set; }

		/// <summary>
		/// Accumulated Other Comprehensive Income / (Loss)
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object aoci { get; set; }

		/// <summary>
		/// Acquisitions
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object acquisitions { get; set; }

		/// <summary>
		/// Adjusted Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object adj_close_price { get; set; }

		/// <summary>
		/// Adjusted High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object adj_high_price { get; set; }

		/// <summary>
		/// Adjusted Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object adj_low_price { get; set; }

		/// <summary>
		/// Adjusted Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object adj_open_price { get; set; }

		/// <summary>
		/// Adjusted Volume
		/// Statement code: current, type: prices, units: shares 
		/// </summary>
		public object adj_volume { get; set; }

		/// <summary>
		/// Allowance for Loan and Lease Losses
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object allowanceforloanandleaselosses { get; set; }

		/// <summary>
		/// Altman Z-Score
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public object altmanzscore { get; set; }

		/// <summary>
		/// Amortization Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object amortizationexpense { get; set; }

		/// <summary>
		/// Amortization of Deferred Policy Acquisition Costs
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object amortizationofdeferredpolicyacquisitioncosts { get; set; }

		/// <summary>
		/// Ask Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object ask_price { get; set; }

		/// <summary>
		/// Ask Size
		/// Statement code: current, type: prices, units: integer 
		/// </summary>
		public object ask_size { get; set; }

		/// <summary>
		/// Ask Timestamp
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		public object ask_timestamp { get; set; }

		/// <summary>
		/// Asset Retirement Reserve & Litigation Obligation
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object assetretirementandlitigationobligation { get; set; }

		/// <summary>
		/// Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public object assetturnover { get; set; }

		/// <summary>
		/// Augmented Payout Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object augmentedpayoutratio { get; set; }

		/// <summary>
		/// Average Daily Volume
		/// Statement code: current, type: short_interest, units: shares 
		/// </summary>
		public object average_daily_volume { get; set; }

		/// <summary>
		/// Bankers Acceptance Outstanding
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object bankersacceptances { get; set; }

		/// <summary>
		/// Basic & Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public object basicdilutedeps { get; set; }

		/// <summary>
		/// Basic Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public object basiceps { get; set; }

		/// <summary>
		/// Beta
		/// Statement code: current, type: info, units: float 
		/// </summary>
		public object beta { get; set; }

		/// <summary>
		/// Bid Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object bid_price { get; set; }

		/// <summary>
		/// Bid Size
		/// Statement code: current, type: prices, units: integer 
		/// </summary>
		public object bid_size { get; set; }

		/// <summary>
		/// Bid Timestamp
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		public object bid_timestamp { get; set; }

		/// <summary>
		/// Book Value per Share
		/// Statement code: calculations, type: metric, units: usdpershare 
		/// </summary>
		public object bookvaluepershare { get; set; }

		/// <summary>
		/// Business Address
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object business_address { get; set; }

		/// <summary>
		/// Business Phone Number
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object business_phone_no { get; set; }

		/// <summary>
		/// Capital Expenditures (CapEx)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object capex { get; set; }

		/// <summary>
		/// Capital Lease Obligations
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object capitalleaseobligations { get; set; }

		/// <summary>
		/// Capitalized Lease Obligations Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object capitalizedleaseobligationinterestexpense { get; set; }

		/// <summary>
		/// Cash & Equivalents
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object cashandequivalents { get; set; }

		/// <summary>
		/// Cash Conversion Cycle (CCC)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public object ccc { get; set; }

		/// <summary>
		/// Cash Dividends to Common per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public object cashdividendspershare { get; set; }

		/// <summary>
		/// Cash Income Taxes Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object cashincometaxespaid { get; set; }

		/// <summary>
		/// Cash Interest Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object cashinterestpaid { get; set; }

		/// <summary>
		/// Cash Interest Received
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object cashinterestreceived { get; set; }

		/// <summary>
		/// Cash Return on Invested Capital (CROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object croic { get; set; }

		/// <summary>
		/// Change in Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object change { get; set; }

		/// <summary>
		/// Changes in Operating Assets and Liabilities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object increasedecreaseinoperatingcapital { get; set; }

		/// <summary>
		/// Chief Executive Officer (CEO)
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object ceo { get; set; }

		/// <summary>
		/// Claims and Claim Expense
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object claimsandclaimexpenses { get; set; }

		/// <summary>
		/// Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object close_price { get; set; }

		/// <summary>
		/// Commitments & Contingencies
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object commitmentsandcontingencies { get; set; }

		/// <summary>
		/// Common Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public object commontocap { get; set; }

		/// <summary>
		/// Common Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object commonequity { get; set; }

		/// <summary>
		/// Company Legal Name
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object legal_name { get; set; }

		/// <summary>
		/// Company Name
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object name { get; set; }

		/// <summary>
		/// Company Website
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object company_url { get; set; }

		/// <summary>
		/// Compound Leverage Factor
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public object compoundleveragefactor { get; set; }

		/// <summary>
		/// Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object netincome { get; set; }

		/// <summary>
		/// Cost of Revenue to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object costofrevtorevenue { get; set; }

		/// <summary>
		/// Country
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object country { get; set; }

		/// <summary>
		/// Current and Future Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object currentandfuturebenefits { get; set; }

		/// <summary>
		/// Current Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object currentdeferredtaxliabilities { get; set; }

		/// <summary>
		/// Current Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object currentdeferredtaxassets { get; set; }

		/// <summary>
		/// Current Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object currentdeferredrevenue { get; set; }

		/// <summary>
		/// Current Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object currentemployeebenefitliabilities { get; set; }

		/// <summary>
		/// Current Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		public object currentratio { get; set; }

		/// <summary>
		/// Current Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object currentyearearningsyield { get; set; }

		/// <summary>
		/// Customer and Other Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object customerandotherreceivables { get; set; }

		/// <summary>
		/// Customer Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object customerdeposits { get; set; }

		/// <summary>
		/// Days Inventory Outstanding (DIO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public object dio { get; set; }

		/// <summary>
		/// Days Payable Outstanding (DPO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public object dpo { get; set; }

		/// <summary>
		/// Days Sales Outstanding (DSO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		public object dso { get; set; }

		/// <summary>
		/// Days to Cover
		/// Statement code: current, type: short_interest, units: days 
		/// </summary>
		public object days_to_cover { get; set; }

		/// <summary>
		/// Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public object debttoebitda { get; set; }

		/// <summary>
		/// Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public object debttoequity { get; set; }

		/// <summary>
		/// Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public object debttonopat { get; set; }

		/// <summary>
		/// Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public object debttototalcapital { get; set; }

		/// <summary>
		/// Debt-free Net Working Capital (DFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object dfnwc { get; set; }

		/// <summary>
		/// Debt-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public object dfnwctorev { get; set; }

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital (DFCFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object dfcfnwc { get; set; }

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public object dfcfnwctorev { get; set; }

		/// <summary>
		/// Deferred Acquisition Cost
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object deferredacquisitioncost { get; set; }

		/// <summary>
		/// Depletion Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object depletionexpense { get; set; }

		/// <summary>
		/// Deposits and Money Market Investments Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object depositsinterestincome { get; set; }

		/// <summary>
		/// Deposits Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object depositsinterestexpense { get; set; }

		/// <summary>
		/// Depreciation Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object depreciationexpense { get; set; }

		/// <summary>
		/// Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		public object dilutedeps { get; set; }

		/// <summary>
		/// Divestitures
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object divestitures { get; set; }

		/// <summary>
		/// Dividend Ex Date
		/// Statement code: current, type: dividend, units: string 
		/// </summary>
		public object dividend_ex_date { get; set; }

		/// <summary>
		/// Dividend Pay Date
		/// Statement code: current, type: dividend, units: string 
		/// </summary>
		public object dividend_pay_date { get; set; }

		/// <summary>
		/// Dividend Payout Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object divpayoutratio { get; set; }

		/// <summary>
		/// Dividend per Share
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public object dividend { get; set; }

		/// <summary>
		/// Dividend Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		public object dividendyield { get; set; }

		/// <summary>
		/// Dividends Payable
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object dividendspayable { get; set; }

		/// <summary>
		/// Earnings before Interest and Taxes (EBIT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object ebit { get; set; }

		/// <summary>
		/// Earnings before Interest, Taxes, Depreciation and Amortization (EBITDA)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object ebitda { get; set; }

		/// <summary>
		/// Earnings Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		public object earningsyield { get; set; }

		/// <summary>
		/// EBIT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object ebitgrowth { get; set; }

		/// <summary>
		/// EBIT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public object ebitlesscapextointerestex { get; set; }

		/// <summary>
		/// EBIT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object ebitmargin { get; set; }

		/// <summary>
		/// EBIT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object ebitqoqgrowth { get; set; }

		/// <summary>
		/// EBIT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public object ebittointerestex { get; set; }

		/// <summary>
		/// EBITDA Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object ebitdagrowth { get; set; }

		/// <summary>
		/// EBITDA Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object ebitdamargin { get; set; }

		/// <summary>
		/// EBITDA Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object ebitdaqoqgrowth { get; set; }

		/// <summary>
		/// Effect of Exchange Rate Changes
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object effectofexchangeratechanges { get; set; }

		/// <summary>
		/// Effective Tax Rate
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object efftaxrate { get; set; }

		/// <summary>
		/// Employee Benefit Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object employeebenefitassets { get; set; }

		/// <summary>
		/// Employees
		/// Statement code: current, type: info, units: integer 
		/// </summary>
		public object employees { get; set; }

		/// <summary>
		/// Enterprise Value (EV)
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		public object enterprisevalue { get; set; }

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object evtocurrentyearrevenue { get; set; }

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object evtonextyearrevenue { get; set; }

		/// <summary>
		/// Enterprise Value to EBIT (EV/EBIT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object evtoebit { get; set; }

		/// <summary>
		/// Enterprise Value to EBITDA (EV/EBITDA)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object evtoebitda { get; set; }

		/// <summary>
		/// Enterprise Value to Free Cash Flow (EV/FCFF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object evtofcff { get; set; }

		/// <summary>
		/// Enterprise Value to Invested Capital (EV/IC)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object evtoinvestedcapital { get; set; }

		/// <summary>
		/// Enterprise Value to NOPAT (EV/NOPAT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object evtonopat { get; set; }

		/// <summary>
		/// Enterprise Value to Operating Cash Flow (EV/OCF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object evtoocf { get; set; }

		/// <summary>
		/// Enterprise Value to Revenue (EV/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object evtorevenue { get; set; }

		/// <summary>
		/// EPS Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object epsgrowth { get; set; }

		/// <summary>
		/// EPS Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object epsqoqgrowth { get; set; }

		/// <summary>
		/// Ex Dividend
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		public object ex_dividend { get; set; }

		/// <summary>
		/// Exchange Financial Status
		/// Statement code: current, type: security, units: boolean 
		/// </summary>
		public object exchange_status { get; set; }

		/// <summary>
		/// Exploration Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object explorationexpense { get; set; }

		/// <summary>
		/// Extraordinary Income / (Loss), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public object extraordinaryincome { get; set; }

		/// <summary>
		/// Federal Funds Purchased and Securities Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object fedfundspurchased { get; set; }

		/// <summary>
		/// Federal Funds Purchased and Securities Sold Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object fedfundsandrepointerestexpense { get; set; }

		/// <summary>
		/// Federal Funds Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object fedfundssold { get; set; }

		/// <summary>
		/// Federal Funds Sold and Securities Borrowed Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object fedfundsandrepointerestincome { get; set; }

		/// <summary>
		/// Financial Leverage
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public object finleverage { get; set; }

		/// <summary>
		/// Five Year Average Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public object five_yr_ave_dividend_yield { get; set; }

		/// <summary>
		/// Five Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object five_yr_monthly_beta { get; set; }

		/// <summary>
		/// Five Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object five_yr_weekly_beta { get; set; }

		/// <summary>
		/// Fixed Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public object faturnover { get; set; }

		/// <summary>
		/// Forward Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public object forward_dividend_rate { get; set; }

		/// <summary>
		/// Forward Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public object forward_dividend_yield { get; set; }

		/// <summary>
		/// Free Cash Flow Firm Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object fcffgrowth { get; set; }

		/// <summary>
		/// Free Cash Flow Firm Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object fcffqoqgrowth { get; set; }

		/// <summary>
		/// Free Cash Flow to Firm (FCFF)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object freecashflow { get; set; }

		/// <summary>
		/// Free Cash Flow to Firm to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public object fcfftointerestex { get; set; }

		/// <summary>
		/// Future Policy Benefits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object futurepolicybenefits { get; set; }

		/// <summary>
		/// Goodwill
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object goodwill { get; set; }

		/// <summary>
		/// Gross Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object grossmargin { get; set; }

		/// <summary>
		/// High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object high_price { get; set; }

		/// <summary>
		/// Impairment Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object impairmentexpense { get; set; }

		/// <summary>
		/// Income Tax Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object incometaxexpense { get; set; }

		/// <summary>
		/// Incorporated Country
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object inc_country { get; set; }

		/// <summary>
		/// Incorporated State
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object inc_state { get; set; }

		/// <summary>
		/// Increase / (Decrease) in Invested Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object investedcapitalincreasedecrease { get; set; }

		/// <summary>
		/// Industry Category
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object industry_category { get; set; }

		/// <summary>
		/// Industry Group
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object industry_group { get; set; }

		/// <summary>
		/// Insurance Policy Acquisition Costs
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object policyacquisitioncosts { get; set; }

		/// <summary>
		/// Intangible Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object intangibleassets { get; set; }

		/// <summary>
		/// Interest & Investment Income
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public object totalinterestincome { get; set; }

		/// <summary>
		/// Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object interestbearingdeposits { get; set; }

		/// <summary>
		/// Interest Bearing Deposits at Other Banks
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object interestbearingdepositsatotherbanks { get; set; }

		/// <summary>
		/// Interest Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object interestburdenpct { get; set; }

		/// <summary>
		/// Interest Expense
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public object totalinterestexpense { get; set; }

		/// <summary>
		/// Inventories, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object netinventory { get; set; }

		/// <summary>
		/// Inventory Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public object invturnover { get; set; }

		/// <summary>
		/// Invested Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object investedcapital { get; set; }

		/// <summary>
		/// Invested Capital Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object investedcapitalgrowth { get; set; }

		/// <summary>
		/// Invested Capital Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object investedcapitalqoqgrowth { get; set; }

		/// <summary>
		/// Invested Capital Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		public object investedcapitalturnover { get; set; }

		/// <summary>
		/// Investment Banking Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object investmentbankingincome { get; set; }

		/// <summary>
		/// Investment Securities Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object investmentsecuritiesinterestincome { get; set; }

		/// <summary>
		/// Issuance of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object issuanceofcommonequity { get; set; }

		/// <summary>
		/// Issuance of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object issuanceofdebt { get; set; }

		/// <summary>
		/// Issuance of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object issuanceofpreferredequity { get; set; }

		/// <summary>
		/// Leverage Ratio
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public object leverageratio { get; set; }

		/// <summary>
		/// Listing Exchange
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public object listing_exchange { get; set; }

		/// <summary>
		/// Loans and Leases
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object loansandleases { get; set; }

		/// <summary>
		/// Loans and Leases Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object loansandleaseinterestincome { get; set; }

		/// <summary>
		/// Loans and Leases, Net of Allowance
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object netloansandleases { get; set; }

		/// <summary>
		/// Loans Held for Sale
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object loansheldforsale { get; set; }

		/// <summary>
		/// Loans Held for Sale, Net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object loansheldforsalenet { get; set; }

		/// <summary>
		/// Long Description
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object long_description { get; set; }

		/// <summary>
		/// Long-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object longtermdebt { get; set; }

		/// <summary>
		/// Long-Term Debt Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object longtermdebtinterestexpense { get; set; }

		/// <summary>
		/// Long-Term Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public object ltdebttoebitda { get; set; }

		/// <summary>
		/// Long-Term Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		public object ltdebttoequity { get; set; }

		/// <summary>
		/// Long-Term Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public object ltdebttonopat { get; set; }

		/// <summary>
		/// Long-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public object ltdebttocap { get; set; }

		/// <summary>
		/// Long-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object longterminvestments { get; set; }

		/// <summary>
		/// Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object low_price { get; set; }

		/// <summary>
		/// Mailing Address
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object mailing_address { get; set; }

		/// <summary>
		/// Market Capitalization
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		public object marketcap { get; set; }

		/// <summary>
		/// Market Category
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public object market_category { get; set; }

		/// <summary>
		/// Marketing Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object marketingexpense { get; set; }

		/// <summary>
		/// Mortgage Servicing Rights
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object mortgageservicingrights { get; set; }

		/// <summary>
		/// Net Cash From Continuing Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromcontinuingfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Continuing Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromcontinuinginvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Continuing Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromcontinuingoperatingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromdiscontinuedfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromdiscontinuedinvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Discontinued Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromdiscontinuedoperatingactivities { get; set; }

		/// <summary>
		/// Net Cash From Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromfinancingactivities { get; set; }

		/// <summary>
		/// Net Cash From Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfrominvestingactivities { get; set; }

		/// <summary>
		/// Net Cash From Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netcashfromoperatingactivities { get; set; }

		/// <summary>
		/// Net Change in Cash & Equivalents
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netchangeincash { get; set; }

		/// <summary>
		/// Net Change in Deposits
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netchangeindeposits { get; set; }

		/// <summary>
		/// Net Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object netdebt { get; set; }

		/// <summary>
		/// Net Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public object netdebttoebitda { get; set; }

		/// <summary>
		/// Net Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		public object netdebttonopat { get; set; }

		/// <summary>
		/// Net Income / (Loss) Attributable to Common Shareholders
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object netincometocommon { get; set; }

		/// <summary>
		/// Net Income / (Loss) Attributable to Noncontrolling Interest
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object netincometononcontrollinginterest { get; set; }

		/// <summary>
		/// Net Income / (Loss) Continuing Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object netincomecontinuing { get; set; }

		/// <summary>
		/// Net Income / (Loss) Discontinued Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object netincomediscontinued { get; set; }

		/// <summary>
		/// Net Income Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object netincomegrowth { get; set; }

		/// <summary>
		/// Net Income Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object netincomeqoqgrowth { get; set; }

		/// <summary>
		/// Net Increase in Fed Funds Sold
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object netincreaseinfedfundssold { get; set; }

		/// <summary>
		/// Net Interest Income / (Expense)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object netinterestincome { get; set; }

		/// <summary>
		/// Net Nonoperating Expense (NNE)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object netnonopex { get; set; }

		/// <summary>
		/// Net Nonoperating Expense Percent (NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object nnep { get; set; }

		/// <summary>
		/// Net Nonoperating Obligations (NNO)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object netnonopobligations { get; set; }

		/// <summary>
		/// Net Occupancy & Equipment Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object netoccupancyequipmentexpense { get; set; }

		/// <summary>
		/// Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object nopat { get; set; }

		/// <summary>
		/// Net Realized & Unrealized Capital Gains on Investments
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object netrealizedcapitalgains { get; set; }

		/// <summary>
		/// Net Working Capital (NWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object nwc { get; set; }

		/// <summary>
		/// Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		public object nwctorev { get; set; }

		/// <summary>
		/// Next Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object nextyearearningsyield { get; set; }

		/// <summary>
		/// Non-Cash Adjustments To Reconcile Net Income
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object noncashadjustmentstonetincome { get; set; }

		/// <summary>
		/// Non-Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object noninterestbearingdeposits { get; set; }

		/// <summary>
		/// Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object noncontrollinginterests { get; set; }

		/// <summary>
		/// Noncontrolling Interest Sharing Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object noncontrollinginterestsharingratio { get; set; }

		/// <summary>
		/// Noncontrolling Interests to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public object noncontrolinttocap { get; set; }

		/// <summary>
		/// Noncurrent Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object noncurrentdeferredtaxliabilities { get; set; }

		/// <summary>
		/// Noncurrent Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object noncurrentdeferredtaxassets { get; set; }

		/// <summary>
		/// Noncurrent Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object noncurrentdeferredrevenue { get; set; }

		/// <summary>
		/// Noncurrent Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object noncurrentemployeebenefitliabilities { get; set; }

		/// <summary>
		/// Noncurrent Note & Lease Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object noncurrentnotereceivables { get; set; }

		/// <summary>
		/// Nonoperating Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public object nonoperatingincome { get; set; }

		/// <summary>
		/// NOPAT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object nopatgrowth { get; set; }

		/// <summary>
		/// NOPAT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public object nopatlesscapextointex { get; set; }

		/// <summary>
		/// NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object nopatmargin { get; set; }

		/// <summary>
		/// NOPAT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object nopatqoqgrowth { get; set; }

		/// <summary>
		/// NOPAT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public object nopattointerestex { get; set; }

		/// <summary>
		/// Normalized Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object normalizednopat { get; set; }

		/// <summary>
		/// Normalized NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object normalizednopatmargin { get; set; }

		/// <summary>
		/// Note & Lease Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object notereceivable { get; set; }

		/// <summary>
		/// One Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object one_yr_monthly_beta { get; set; }

		/// <summary>
		/// One Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object one_yr_weekly_beta { get; set; }

		/// <summary>
		/// Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		public object open_price { get; set; }

		/// <summary>
		/// Operating Cash Flow Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object ocfgrowth { get; set; }

		/// <summary>
		/// Operating Cash Flow Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public object ocflesscapextointerestex { get; set; }

		/// <summary>
		/// Operating Cash Flow Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object ocfqoqgrowth { get; set; }

		/// <summary>
		/// Operating Cash Flow to CapEx
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object ocftocapex { get; set; }

		/// <summary>
		/// Operating Cash Flow to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		public object ocftointerestex { get; set; }

		/// <summary>
		/// Operating Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object operatingcostofrevenue { get; set; }

		/// <summary>
		/// Operating Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object opextorevenue { get; set; }

		/// <summary>
		/// Operating Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object operatingmargin { get; set; }

		/// <summary>
		/// Operating Return on Assets (OROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object oroa { get; set; }

		/// <summary>
		/// Operating Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object operatingrevenue { get; set; }

		/// <summary>
		/// Other Adjustments to Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object otheradjustmentstoconsolidatednetincome { get; set; }

		/// <summary>
		/// Other Adjustments to Net Income / (Loss) Attributable to Common Shareholders)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object otheradjustmentstonetincometocommon { get; set; }

		/// <summary>
		/// Other Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object otherassets { get; set; }

		/// <summary>
		/// Other Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object othercostofrevenue { get; set; }

		/// <summary>
		/// Other Current Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object othercurrentassets { get; set; }

		/// <summary>
		/// Other Current Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object othercurrentliabilities { get; set; }

		/// <summary>
		/// Other Current Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object othercurrentnonoperatingassets { get; set; }

		/// <summary>
		/// Other Current Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object othercurrentnonoperatingliabilities { get; set; }

		/// <summary>
		/// Other Equity Adjustments
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object otherequity { get; set; }

		/// <summary>
		/// Other Financing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object otherfinancingactivitiesnet { get; set; }

		/// <summary>
		/// Other Gains / (Losses), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public object othergains { get; set; }

		/// <summary>
		/// Other Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		public object otherincome { get; set; }

		/// <summary>
		/// Other Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object otherinterestexpense { get; set; }

		/// <summary>
		/// Other Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object otherinterestincome { get; set; }

		/// <summary>
		/// Other Investing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object otherinvestingactivitiesnet { get; set; }

		/// <summary>
		/// Other Long-Term Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object otherlongtermliabilities { get; set; }

		/// <summary>
		/// Other Net Changes in Cash
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object othernetchangesincash { get; set; }

		/// <summary>
		/// Other Non-Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object othernoninterestincome { get; set; }

		/// <summary>
		/// Other Noncurrent Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object othernoncurrentnonoperatingassets { get; set; }

		/// <summary>
		/// Other Noncurrent Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object othernoncurrentnonoperatingliabilities { get; set; }

		/// <summary>
		/// Other Noncurrent Operating Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object othernoncurrentassets { get; set; }

		/// <summary>
		/// Other Noncurrent Operating Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object othernoncurrentliabilities { get; set; }

		/// <summary>
		/// Other Operating Expenses / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object otheroperatingexpenses { get; set; }

		/// <summary>
		/// Other Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object otherrevenue { get; set; }

		/// <summary>
		/// Other Service Charges
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object otherservicechargeincome { get; set; }

		/// <summary>
		/// Other Short-Term Payables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object othershorttermpayables { get; set; }

		/// <summary>
		/// Other Special Charges / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object otherspecialcharges { get; set; }

		/// <summary>
		/// Other Taxes Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object othertaxespayable { get; set; }

		/// <summary>
		/// Participating Policy Holder Equity
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object participatingpolicyholderequity { get; set; }

		/// <summary>
		/// Payment of Dividends
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object paymentofdividends { get; set; }

		/// <summary>
		/// Percent Change in Price
		/// Statement code: current, type: prices, units: percentage 
		/// </summary>
		public object percent_change { get; set; }

		/// <summary>
		/// Plant, Property & Equipment, gross
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object grossppe { get; set; }

		/// <summary>
		/// Plant, Property, & Equipment, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object netppe { get; set; }

		/// <summary>
		/// Policy Holder Funds
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object policyholderfunds { get; set; }

		/// <summary>
		/// Pre Tax Income Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object pretaxincomemargin { get; set; }

		/// <summary>
		/// Preferred Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public object preferredtocap { get; set; }

		/// <summary>
		/// Preferred Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalpreferredequity { get; set; }

		/// <summary>
		/// Preferred Stock Dividends Declared
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object preferreddividends { get; set; }

		/// <summary>
		/// Premises and Equipment, Net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object netpremisesandequipment { get; set; }

		/// <summary>
		/// Premiums Earned
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object premiumsearned { get; set; }

		/// <summary>
		/// Prepaid Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object prepaidexpenses { get; set; }

		/// <summary>
		/// Price Date
		/// Statement code: current, type: prices, units: date 
		/// </summary>
		public object price_date { get; set; }

		/// <summary>
		/// Price Time
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		public object price_time { get; set; }

		/// <summary>
		/// Price to Book Value (P/BV)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object pricetobook { get; set; }

		/// <summary>
		/// Price to Current Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object pricetocurrentyearearnings { get; set; }

		/// <summary>
		/// Price to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object pricetocurrentyearrevenue { get; set; }

		/// <summary>
		/// Price to Earnings (P/E)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object pricetoearnings { get; set; }

		/// <summary>
		/// Price to Next Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object pricetonextyearearnings { get; set; }

		/// <summary>
		/// Price to Next Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		public object pricetonextyearrevenue { get; set; }

		/// <summary>
		/// Price to Revenue (P/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object pricetorevenue { get; set; }

		/// <summary>
		/// Price to Tangible Book Value (P/TBV)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		public object pricetotangiblebook { get; set; }

		/// <summary>
		/// Profit (Net Income) Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object profitmargin { get; set; }

		/// <summary>
		/// Property & Liability Insurance Claims
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object propertyliabilityinsuranceclaims { get; set; }

		/// <summary>
		/// Provision for Credit Losses
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object provisionforcreditlosses { get; set; }

		/// <summary>
		/// Provision For Loan Losses
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object provisionforloanlosses { get; set; }

		/// <summary>
		/// Purchase of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object purchaseofinvestments { get; set; }

		/// <summary>
		/// Purchase of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object purchaseofplantpropertyandequipment { get; set; }

		/// <summary>
		/// Quick Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		public object quickratio { get; set; }

		/// <summary>
		/// R&D to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object rdextorevenue { get; set; }

		/// <summary>
		/// Redeemable Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object redeemablenoncontrollinginterest { get; set; }

		/// <summary>
		/// Repayment of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object repaymentofdebt { get; set; }

		/// <summary>
		/// Repurchase of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object repurchaseofcommonequity { get; set; }

		/// <summary>
		/// Repurchase of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object repurchaseofpreferredequity { get; set; }

		/// <summary>
		/// Research & Development Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object rdexpense { get; set; }

		/// <summary>
		/// Restricted Cash
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object restrictedcash { get; set; }

		/// <summary>
		/// Restructuring Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object restructuringcharge { get; set; }

		/// <summary>
		/// Retained Earnings
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object retainedearnings { get; set; }

		/// <summary>
		/// Return on Assets (ROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object roa { get; set; }

		/// <summary>
		/// Return on Common Equity (ROCE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object roce { get; set; }

		/// <summary>
		/// Return on Equity (ROE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object roe { get; set; }

		/// <summary>
		/// Return on Invested Capital (ROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object roic { get; set; }

		/// <summary>
		/// Return on Net Nonoperating Assets (RNNOA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object rnnoa { get; set; }

		/// <summary>
		/// Revenue Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object revenuegrowth { get; set; }

		/// <summary>
		/// Revenue Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		public object revenueqoqgrowth { get; set; }

		/// <summary>
		/// ROIC Less NNEP Spread (ROIC-NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		public object roicnnepspread { get; set; }

		/// <summary>
		/// Salaries and Employee Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object salariesandemployeebenefitsexpense { get; set; }

		/// <summary>
		/// Sale and/or Maturity of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object saleofinvestments { get; set; }

		/// <summary>
		/// Sale of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		public object saleofplantpropertyandequipment { get; set; }

		/// <summary>
		/// SEC Centeral Index Key (CIK)
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object cik { get; set; }

		/// <summary>
		/// Sector
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object sector { get; set; }

		/// <summary>
		/// Security Class
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public object security_class { get; set; }

		/// <summary>
		/// Security Name
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public object security_name { get; set; }

		/// <summary>
		/// Security Round Lot Size
		/// Statement code: current, type: security, units: shares 
		/// </summary>
		public object security_round_lot_size { get; set; }

		/// <summary>
		/// Security Ticker Symbol
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public object security_ticker { get; set; }

		/// <summary>
		/// Security Type
		/// Statement code: current, type: security, units: string 
		/// </summary>
		public object security_type { get; set; }

		/// <summary>
		/// Selling, General & Admin Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object sgaexpense { get; set; }

		/// <summary>
		/// Separate Account Business Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object separateaccountbusinessassets { get; set; }

		/// <summary>
		/// Separate Account Business Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object separateaccountbusinessliabilities { get; set; }

		/// <summary>
		/// Service Charges on Deposit Accounts
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object servicechargesondepositsincome { get; set; }

		/// <summary>
		/// Seven Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object seven_yr_monthly_beta { get; set; }

		/// <summary>
		/// Seven Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object seven_yr_weekly_beta { get; set; }

		/// <summary>
		/// SG&A Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object sgaextorevenue { get; set; }

		/// <summary>
		/// Short Description
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object short_description { get; set; }

		/// <summary>
		/// Short Interest
		/// Statement code: current, type: short_interest, units: shares 
		/// </summary>
		public object short_interest { get; set; }

		/// <summary>
		/// Short-Term Borrowings Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object shorttermborrowinginterestexpense { get; set; }

		/// <summary>
		/// Short-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object shorttermdebt { get; set; }

		/// <summary>
		/// Short-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		public object stdebttocap { get; set; }

		/// <summary>
		/// Short-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		public object shortterminvestments { get; set; }

		/// <summary>
		/// Split Ratio
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		public object split_ratio { get; set; }

		/// <summary>
		/// Standard Industrial Classification Code (SIC)
		/// Statement code: current, type: info, units: integer 
		/// </summary>
		public object sic { get; set; }

		/// <summary>
		/// State
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object state { get; set; }

		/// <summary>
		/// Stock Exchange
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object stock_exchange { get; set; }

		/// <summary>
		/// Tangible Book Value per Share
		/// Statement code: calculations, type: metric, units: usdpershare 
		/// </summary>
		public object tangbookvaluepershare { get; set; }

		/// <summary>
		/// Tax Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		public object taxburdenpct { get; set; }

		/// <summary>
		/// Template
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object template { get; set; }

		/// <summary>
		/// Ten Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object ten_yr_monthly_beta { get; set; }

		/// <summary>
		/// Ten Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object ten_yr_weekly_beta { get; set; }

		/// <summary>
		/// Three Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object three_yr_monthly_beta { get; set; }

		/// <summary>
		/// Three Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		public object three_yr_weekly_beta { get; set; }

		/// <summary>
		/// Ticker Symbol
		/// Statement code: current, type: info, units: string 
		/// </summary>
		public object ticker { get; set; }

		/// <summary>
		/// Time Deposits Placed and Other Short-Term Investments
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object timedepositsplaced { get; set; }

		/// <summary>
		/// Total Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalassets { get; set; }

		/// <summary>
		/// Total Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object totalcapital { get; set; }

		/// <summary>
		/// Total Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalcommonequity { get; set; }

		/// <summary>
		/// Total Cost of Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totalcostofrevenue { get; set; }

		/// <summary>
		/// Total Current Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalcurrentassets { get; set; }

		/// <summary>
		/// Total Current Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalcurrentliabilities { get; set; }

		/// <summary>
		/// Total Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object debt { get; set; }

		/// <summary>
		/// Total Depreciation and Amortization (D&A)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object depreciationandamortization { get; set; }

		/// <summary>
		/// Total Equity & Noncontrolling Interests
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalequityandnoncontrollinginterests { get; set; }

		/// <summary>
		/// Total Gross Profit
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totalgrossprofit { get; set; }

		/// <summary>
		/// Total Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalliabilities { get; set; }

		/// <summary>
		/// Total Liabilities & Shareholders’ Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalliabilitiesandequity { get; set; }

		/// <summary>
		/// Total Long-Term Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		public object ltdebtandcapleases { get; set; }

		/// <summary>
		/// Total Non-Interest Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totalnoninterestexpense { get; set; }

		/// <summary>
		/// Total Non-Interest Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totalnoninterestincome { get; set; }

		/// <summary>
		/// Total Noncurrent Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalnoncurrentassets { get; set; }

		/// <summary>
		/// Total Noncurrent Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalnoncurrentliabilities { get; set; }

		/// <summary>
		/// Total Operating Expenses
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totaloperatingexpenses { get; set; }

		/// <summary>
		/// Total Operating Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totaloperatingincome { get; set; }

		/// <summary>
		/// Total Other Income / (Expense), net
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totalotherincome { get; set; }

		/// <summary>
		/// Total Pre-Tax Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totalpretaxincome { get; set; }

		/// <summary>
		/// Total Preferred & Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object totalequity { get; set; }

		/// <summary>
		/// Total Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		public object totalrevenue { get; set; }

		/// <summary>
		/// Trading Account Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object tradingaccountinterestincome { get; set; }

		/// <summary>
		/// Trading Account Securities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object tradingaccountsecurities { get; set; }

		/// <summary>
		/// Trailing Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		public object dividend_rate { get; set; }

		/// <summary>
		/// Trailing Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		public object trailing_dividend_yield { get; set; }

		/// <summary>
		/// Treasury Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		public object treasurystock { get; set; }

		/// <summary>
		/// Trust Fees by Commissions
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		public object trustfeeincome { get; set; }

		/// <summary>
		/// Unearned Premiums Asset
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object unearnedpremiumsdebit { get; set; }

		/// <summary>
		/// Unearned Premiums Liability
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		public object unearnedpremiumscredit { get; set; }

		/// <summary>
		/// Volume
		/// Statement code: current, type: prices, units: shares 
		/// </summary>
		public object volume { get; set; }

		/// <summary>
		/// Weighted Average Basic & Diluted Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		public object weightedavebasicdilutedsharesos { get; set; }

		/// <summary>
		/// Weighted Average Basic Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		public object weightedavebasicsharesos { get; set; }

		/// <summary>
		/// Weighted Average Diluted Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		public object weightedavedilutedsharesos { get; set; }

	}

	/*public class SecurityMasterListDto
	{
		/// <summary>
		/// the stock market ticker symbol associated with the companies common stock securities
		/// </summary>
		public string ticker { get; set; }

		/// <summary>
		///  the security description as provided by the exchange
		/// </summary>
		public string security_name { get; set; }

		/// <summary>
		/// the type of security, such as Common Stock, Preferred Stock, Warrants, Limited Partnership Interests, etc.
		/// </summary>
		public string security_type { get; set; }

		/// <summary>
		/// if a company has multiple securities, the security class is a single letter description of the class of a certain type of security.
		/// </summary>
		public object security_class { get; set; }

		/// <summary>
		/// the Stock Exchange (and market category) where the company’s common stock is primarily traded
		/// </summary>
		public string stock_exchange { get; set; }

		/// <summary>
		/// the Stock Exchange where the company’s common stock is primarily traded
		/// </summary>
		public string listing_exchange { get; set; }

		/// <summary>
		/// the NASDAQ market category for a NASDAQ listed company.
		/// </summary>
		public string market_category { get; set; }

		/// <summary>
		/// true or false, depending on whether the security is an ETF or not.
		/// </summary>
		public bool etf { get; set; }

		/// <summary>
		/// the round lot size for the security.
		/// </summary>
		public int round_lot_size { get; set; }

		/// <summary>
		/// indicates when an issuer has failed to submit its regulatory filings on a timely basis, has failed to 
		/// meet NASDAQ’s continuing listing standards, and/or has filed for bankruptcy. 
		/// Values include: 
		/// D = Deficient: Issuer Failed to Meet NASDAQ Continued Listing Requirements, 
		/// E = Delinquent: Issuer Missed Regulatory Filing Deadline, 
		/// Q = Bankrupt: Issuer Has Filed for Bankruptcy, 
		/// N = Normal (Default): Issuer Is NOT Deficient, Delinquent, or Bankrupt., 
		/// G = Deficient and Bankrupt, 
		/// H = Deficient and Delinquent, 
		/// J = Delinquent and Bankrupt, 
		/// K = Deficient, Delinquent, and Bankrupt
		/// </summary>
		public object financial_status { get; set; }

		/// <summary>
		///  true if the subject security is the primary security for the company. If a security is the default, 
		/// the ticker symbol for the security is the same as the ticker for the company (see /Companies endpoint).
		/// </summary>
		public bool primary_security { get; set; }

		/// <summary>
		///  if the security is no longer traded on public exchanges, the security will be considered delisted and the security no longer will report pricing data.
		/// </summary>
		public bool delisted_security { get; set; }

		/// <summary>
		/// the last recorded date (“YYYY-MM-DD”) of an CRSP adjustment made to prior prices due to a stock split or dividend event.
		/// </summary>
		public string last_crsp_adj_date { get; set; }
	}*/

}
