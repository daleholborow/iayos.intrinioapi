namespace iayos.intrinioapi.ServiceModel.Enums
{

	/// <summary>
	/// http://docs.intrinio.com/tags/intrinio-public#data-point
	/// </summary>
	public enum DataPointTag
	{
		/// <summary>
		/// Default: Did you forget to specify which DataPointTag to use? I bet you did...
		/// </summary>
		IaYoS_Warning_Unset,

		/// <summary>
		/// 52 Week High
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		//52_week_high,

		/// <summary>
		/// 52 Week Low
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		//52_week_low,

		/// <summary>
		/// Accounts Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		accountspayable,

		/// <summary>
		/// Accounts Payable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		apturnover,

		/// <summary>
		/// Accounts Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		accountsreceivable,

		/// <summary>
		/// Accounts Receivable Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		arturnover,

		/// <summary>
		/// Accrued Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		accruedexpenses,

		/// <summary>
		/// Accrued Interest Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		accruedinterestpayable,

		/// <summary>
		/// Accrued Investment Income
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		accruedinvestmentincome,

		/// <summary>
		/// Accumulated Depreciation
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		accumulateddepreciation,

		/// <summary>
		/// Accumulated Other Comprehensive Income / (Loss)
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		aoci,

		/// <summary>
		/// Acquisitions
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		acquisitions,

		/// <summary>
		/// Adjusted Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		adj_close_price,

		/// <summary>
		/// Adjusted High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		adj_high_price,

		/// <summary>
		/// Adjusted Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		adj_low_price,

		/// <summary>
		/// Adjusted Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		adj_open_price,

		/// <summary>
		/// Adjusted Volume
		/// Statement code: current, type: prices, units: shares 
		/// </summary>
		adj_volume,

		/// <summary>
		/// Allowance for Loan and Lease Losses
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		allowanceforloanandleaselosses,

		/// <summary>
		/// Altman Z-Score
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		altmanzscore,

		/// <summary>
		/// Amortization Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		amortizationexpense,

		/// <summary>
		/// Amortization of Deferred Policy Acquisition Costs
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		amortizationofdeferredpolicyacquisitioncosts,

		/// <summary>
		/// Ask Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		ask_price,

		/// <summary>
		/// Ask Size
		/// Statement code: current, type: prices, units: integer 
		/// </summary>
		ask_size,

		/// <summary>
		/// Ask Timestamp
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		ask_timestamp,

		/// <summary>
		/// Asset Retirement Reserve & Litigation Obligation
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		assetretirementandlitigationobligation,

		/// <summary>
		/// Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		assetturnover,

		/// <summary>
		/// Augmented Payout Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		augmentedpayoutratio,

		/// <summary>
		/// Average Daily Volume
		/// Statement code: current, type: short_interest, units: shares 
		/// </summary>
		average_daily_volume,

		/// <summary>
		/// Bankers Acceptance Outstanding
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		bankersacceptances,

		/// <summary>
		/// Basic & Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		basicdilutedeps,

		/// <summary>
		/// Basic Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		basiceps,

		/// <summary>
		/// Beta
		/// Statement code: current, type: info, units: float 
		/// </summary>
		beta,

		/// <summary>
		/// Bid Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		bid_price,

		/// <summary>
		/// Bid Size
		/// Statement code: current, type: prices, units: integer 
		/// </summary>
		bid_size,

		/// <summary>
		/// Bid Timestamp
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		bid_timestamp,

		/// <summary>
		/// Book Value per Share
		/// Statement code: calculations, type: metric, units: usdpershare 
		/// </summary>
		bookvaluepershare,

		/// <summary>
		/// Business Address
		/// Statement code: current, type: info, units: string 
		/// </summary>
		business_address,

		/// <summary>
		/// Business Phone Number
		/// Statement code: current, type: info, units: string 
		/// </summary>
		business_phone_no,

		/// <summary>
		/// Capital Expenditures (CapEx)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		capex,

		/// <summary>
		/// Capital Lease Obligations
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		capitalleaseobligations,

		/// <summary>
		/// Capitalized Lease Obligations Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		capitalizedleaseobligationinterestexpense,

		/// <summary>
		/// Cash & Equivalents
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		cashandequivalents,

		/// <summary>
		/// Cash Conversion Cycle (CCC)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		ccc,

		/// <summary>
		/// Cash Dividends to Common per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		cashdividendspershare,

		/// <summary>
		/// Cash Income Taxes Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		cashincometaxespaid,

		/// <summary>
		/// Cash Interest Paid
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		cashinterestpaid,

		/// <summary>
		/// Cash Interest Received
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		cashinterestreceived,

		/// <summary>
		/// Cash Return on Invested Capital (CROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		croic,

		/// <summary>
		/// Change in Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		change,

		/// <summary>
		/// Changes in Operating Assets and Liabilities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		increasedecreaseinoperatingcapital,

		/// <summary>
		/// Chief Executive Officer (CEO)
		/// Statement code: current, type: info, units: string 
		/// </summary>
		ceo,

		/// <summary>
		/// Claims and Claim Expense
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		claimsandclaimexpenses,

		/// <summary>
		/// Close Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		close_price,

		/// <summary>
		/// Commitments & Contingencies
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		commitmentsandcontingencies,

		/// <summary>
		/// Common Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		commontocap,

		/// <summary>
		/// Common Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		commonequity,

		/// <summary>
		/// Company Legal Name
		/// Statement code: current, type: info, units: string 
		/// </summary>
		legal_name,

		/// <summary>
		/// Company Name
		/// Statement code: current, type: info, units: string 
		/// </summary>
		name,

		/// <summary>
		/// Company Website
		/// Statement code: current, type: info, units: string 
		/// </summary>
		company_url,

		/// <summary>
		/// Compound Leverage Factor
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		compoundleveragefactor,

		/// <summary>
		/// Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		netincome,

		/// <summary>
		/// Cost of Revenue to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		costofrevtorevenue,

		/// <summary>
		/// Country
		/// Statement code: current, type: info, units: string 
		/// </summary>
		country,

		/// <summary>
		/// Current and Future Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		currentandfuturebenefits,

		/// <summary>
		/// Current Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		currentdeferredtaxliabilities,

		/// <summary>
		/// Current Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		currentdeferredtaxassets,

		/// <summary>
		/// Current Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		currentdeferredrevenue,

		/// <summary>
		/// Current Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		currentemployeebenefitliabilities,

		/// <summary>
		/// Current Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		currentratio,

		/// <summary>
		/// Current Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		currentyearearningsyield,

		/// <summary>
		/// Customer and Other Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		customerandotherreceivables,

		/// <summary>
		/// Customer Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		customerdeposits,

		/// <summary>
		/// Days Inventory Outstanding (DIO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		dio,

		/// <summary>
		/// Days Payable Outstanding (DPO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		dpo,

		/// <summary>
		/// Days Sales Outstanding (DSO)
		/// Statement code: calculations, type: efficiency, units: days 
		/// </summary>
		dso,

		/// <summary>
		/// Days to Cover
		/// Statement code: current, type: short_interest, units: days 
		/// </summary>
		days_to_cover,

		/// <summary>
		/// Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		debttoebitda,

		/// <summary>
		/// Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		debttoequity,

		/// <summary>
		/// Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		debttonopat,

		/// <summary>
		/// Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		debttototalcapital,

		/// <summary>
		/// Debt-free Net Working Capital (DFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		dfnwc,

		/// <summary>
		/// Debt-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		dfnwctorev,

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital (DFCFNWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		dfcfnwc,

		/// <summary>
		/// Debt-free, Cash-free Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		dfcfnwctorev,

		/// <summary>
		/// Deferred Acquisition Cost
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		deferredacquisitioncost,

		/// <summary>
		/// Depletion Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		depletionexpense,

		/// <summary>
		/// Deposits and Money Market Investments Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		depositsinterestincome,

		/// <summary>
		/// Deposits Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		depositsinterestexpense,

		/// <summary>
		/// Depreciation Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		depreciationexpense,

		/// <summary>
		/// Diluted Earnings per Share
		/// Statement code: income_statement, type: , units: usdpershare 
		/// </summary>
		dilutedeps,

		/// <summary>
		/// Divestitures
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		divestitures,

		/// <summary>
		/// Dividend Ex Date
		/// Statement code: current, type: dividend, units: string 
		/// </summary>
		dividend_ex_date,

		/// <summary>
		/// Dividend Pay Date
		/// Statement code: current, type: dividend, units: string 
		/// </summary>
		dividend_pay_date,

		/// <summary>
		/// Dividend Payout Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		divpayoutratio,

		/// <summary>
		/// Dividend per Share
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		dividend,

		/// <summary>
		/// Dividend Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		dividendyield,

		/// <summary>
		/// Dividends Payable
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		dividendspayable,

		/// <summary>
		/// Earnings before Interest and Taxes (EBIT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		ebit,

		/// <summary>
		/// Earnings before Interest, Taxes, Depreciation and Amortization (EBITDA)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		ebitda,

		/// <summary>
		/// Earnings Yield
		/// Statement code: calculations, type: valuation, units: percentage 
		/// </summary>
		earningsyield,

		/// <summary>
		/// EBIT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		ebitgrowth,

		/// <summary>
		/// EBIT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		ebitlesscapextointerestex,

		/// <summary>
		/// EBIT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		ebitmargin,

		/// <summary>
		/// EBIT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		ebitqoqgrowth,

		/// <summary>
		/// EBIT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		ebittointerestex,

		/// <summary>
		/// EBITDA Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		ebitdagrowth,

		/// <summary>
		/// EBITDA Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		ebitdamargin,

		/// <summary>
		/// EBITDA Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		ebitdaqoqgrowth,

		/// <summary>
		/// Effect of Exchange Rate Changes
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		effectofexchangeratechanges,

		/// <summary>
		/// Effective Tax Rate
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		efftaxrate,

		/// <summary>
		/// Employee Benefit Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		employeebenefitassets,

		/// <summary>
		/// Employees
		/// Statement code: current, type: info, units: integer 
		/// </summary>
		employees,

		/// <summary>
		/// Enterprise Value (EV)
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		enterprisevalue,

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		evtocurrentyearrevenue,

		/// <summary>
		/// Enterprise Value to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		evtonextyearrevenue,

		/// <summary>
		/// Enterprise Value to EBIT (EV/EBIT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		evtoebit,

		/// <summary>
		/// Enterprise Value to EBITDA (EV/EBITDA)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		evtoebitda,

		/// <summary>
		/// Enterprise Value to Free Cash Flow (EV/FCFF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		evtofcff,

		/// <summary>
		/// Enterprise Value to Invested Capital (EV/IC)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		evtoinvestedcapital,

		/// <summary>
		/// Enterprise Value to NOPAT (EV/NOPAT)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		evtonopat,

		/// <summary>
		/// Enterprise Value to Operating Cash Flow (EV/OCF)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		evtoocf,

		/// <summary>
		/// Enterprise Value to Revenue (EV/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		evtorevenue,

		/// <summary>
		/// EPS Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		epsgrowth,

		/// <summary>
		/// EPS Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		epsqoqgrowth,

		/// <summary>
		/// Ex Dividend
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		ex_dividend,

		/// <summary>
		/// Exchange Financial Status
		/// Statement code: current, type: security, units: boolean 
		/// </summary>
		exchange_status,

		/// <summary>
		/// Exploration Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		explorationexpense,

		/// <summary>
		/// Extraordinary Income / (Loss), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		extraordinaryincome,

		/// <summary>
		/// Federal Funds Purchased and Securities Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		fedfundspurchased,

		/// <summary>
		/// Federal Funds Purchased and Securities Sold Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		fedfundsandrepointerestexpense,

		/// <summary>
		/// Federal Funds Sold
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		fedfundssold,

		/// <summary>
		/// Federal Funds Sold and Securities Borrowed Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		fedfundsandrepointerestincome,

		/// <summary>
		/// Financial Leverage
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		finleverage,

		/// <summary>
		/// Five Year Average Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		five_yr_ave_dividend_yield,

		/// <summary>
		/// Five Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		five_yr_monthly_beta,

		/// <summary>
		/// Five Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		five_yr_weekly_beta,

		/// <summary>
		/// Fixed Asset Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		faturnover,

		/// <summary>
		/// Forward Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		forward_dividend_rate,

		/// <summary>
		/// Forward Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		forward_dividend_yield,

		/// <summary>
		/// Free Cash Flow Firm Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		fcffgrowth,

		/// <summary>
		/// Free Cash Flow Firm Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		fcffqoqgrowth,

		/// <summary>
		/// Free Cash Flow to Firm (FCFF)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		freecashflow,

		/// <summary>
		/// Free Cash Flow to Firm to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		fcfftointerestex,

		/// <summary>
		/// Future Policy Benefits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		futurepolicybenefits,

		/// <summary>
		/// Goodwill
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		goodwill,

		/// <summary>
		/// Gross Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		grossmargin,

		/// <summary>
		/// High Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		high_price,

		/// <summary>
		/// Impairment Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		impairmentexpense,

		/// <summary>
		/// Income Tax Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		incometaxexpense,

		/// <summary>
		/// Incorporated Country
		/// Statement code: current, type: info, units: string 
		/// </summary>
		inc_country,

		/// <summary>
		/// Incorporated State
		/// Statement code: current, type: info, units: string 
		/// </summary>
		inc_state,

		/// <summary>
		/// Increase / (Decrease) in Invested Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		investedcapitalincreasedecrease,

		/// <summary>
		/// Industry Category
		/// Statement code: current, type: info, units: string 
		/// </summary>
		industry_category,

		/// <summary>
		/// Industry Group
		/// Statement code: current, type: info, units: string 
		/// </summary>
		industry_group,

		/// <summary>
		/// Insurance Policy Acquisition Costs
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		policyacquisitioncosts,

		/// <summary>
		/// Intangible Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		intangibleassets,

		/// <summary>
		/// Interest & Investment Income
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		totalinterestincome,

		/// <summary>
		/// Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		interestbearingdeposits,

		/// <summary>
		/// Interest Bearing Deposits at Other Banks
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		interestbearingdepositsatotherbanks,

		/// <summary>
		/// Interest Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		interestburdenpct,

		/// <summary>
		/// Interest Expense
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		totalinterestexpense,

		/// <summary>
		/// Inventories, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		netinventory,

		/// <summary>
		/// Inventory Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		invturnover,

		/// <summary>
		/// Invested Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		investedcapital,

		/// <summary>
		/// Invested Capital Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		investedcapitalgrowth,

		/// <summary>
		/// Invested Capital Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		investedcapitalqoqgrowth,

		/// <summary>
		/// Invested Capital Turnover
		/// Statement code: calculations, type: efficiency, units: float 
		/// </summary>
		investedcapitalturnover,

		/// <summary>
		/// Investment Banking Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		investmentbankingincome,

		/// <summary>
		/// Investment Securities Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		investmentsecuritiesinterestincome,

		/// <summary>
		/// Issuance of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		issuanceofcommonequity,

		/// <summary>
		/// Issuance of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		issuanceofdebt,

		/// <summary>
		/// Issuance of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		issuanceofpreferredequity,

		/// <summary>
		/// Leverage Ratio
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		leverageratio,

		/// <summary>
		/// Listing Exchange
		/// Statement code: current, type: security, units: string 
		/// </summary>
		listing_exchange,

		/// <summary>
		/// Loans and Leases
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		loansandleases,

		/// <summary>
		/// Loans and Leases Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		loansandleaseinterestincome,

		/// <summary>
		/// Loans and Leases, Net of Allowance
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		netloansandleases,

		/// <summary>
		/// Loans Held for Sale
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		loansheldforsale,

		/// <summary>
		/// Loans Held for Sale, Net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		loansheldforsalenet,

		/// <summary>
		/// Long Description
		/// Statement code: current, type: info, units: string 
		/// </summary>
		long_description,

		/// <summary>
		/// Long-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		longtermdebt,

		/// <summary>
		/// Long-Term Debt Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		longtermdebtinterestexpense,

		/// <summary>
		/// Long-Term Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		ltdebttoebitda,

		/// <summary>
		/// Long-Term Debt to Equity
		/// Statement code: calculations, type: leverage, units: float 
		/// </summary>
		ltdebttoequity,

		/// <summary>
		/// Long-Term Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		ltdebttonopat,

		/// <summary>
		/// Long-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		ltdebttocap,

		/// <summary>
		/// Long-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		longterminvestments,

		/// <summary>
		/// Low Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		low_price,

		/// <summary>
		/// Mailing Address
		/// Statement code: current, type: info, units: string 
		/// </summary>
		mailing_address,

		/// <summary>
		/// Market Capitalization
		/// Statement code: calculations, type: valuation, units: usd 
		/// </summary>
		marketcap,

		/// <summary>
		/// Market Category
		/// Statement code: current, type: security, units: string 
		/// </summary>
		market_category,

		/// <summary>
		/// Marketing Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		marketingexpense,

		/// <summary>
		/// Mortgage Servicing Rights
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		mortgageservicingrights,

		/// <summary>
		/// Net Cash From Continuing Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromcontinuingfinancingactivities,

		/// <summary>
		/// Net Cash From Continuing Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromcontinuinginvestingactivities,

		/// <summary>
		/// Net Cash From Continuing Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromcontinuingoperatingactivities,

		/// <summary>
		/// Net Cash From Discontinued Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromdiscontinuedfinancingactivities,

		/// <summary>
		/// Net Cash From Discontinued Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromdiscontinuedinvestingactivities,

		/// <summary>
		/// Net Cash From Discontinued Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromdiscontinuedoperatingactivities,

		/// <summary>
		/// Net Cash From Financing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromfinancingactivities,

		/// <summary>
		/// Net Cash From Investing Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfrominvestingactivities,

		/// <summary>
		/// Net Cash From Operating Activities
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netcashfromoperatingactivities,

		/// <summary>
		/// Net Change in Cash & Equivalents
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netchangeincash,

		/// <summary>
		/// Net Change in Deposits
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netchangeindeposits,

		/// <summary>
		/// Net Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		netdebt,

		/// <summary>
		/// Net Debt to EBITDA
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		netdebttoebitda,

		/// <summary>
		/// Net Debt to NOPAT
		/// Statement code: calculations, type: solvency, units: float 
		/// </summary>
		netdebttonopat,

		/// <summary>
		/// Net Income / (Loss) Attributable to Common Shareholders
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		netincometocommon,

		/// <summary>
		/// Net Income / (Loss) Attributable to Noncontrolling Interest
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		netincometononcontrollinginterest,

		/// <summary>
		/// Net Income / (Loss) Continuing Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		netincomecontinuing,

		/// <summary>
		/// Net Income / (Loss) Discontinued Operations
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		netincomediscontinued,

		/// <summary>
		/// Net Income Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		netincomegrowth,

		/// <summary>
		/// Net Income Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		netincomeqoqgrowth,

		/// <summary>
		/// Net Increase in Fed Funds Sold
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		netincreaseinfedfundssold,

		/// <summary>
		/// Net Interest Income / (Expense)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		netinterestincome,

		/// <summary>
		/// Net Nonoperating Expense (NNE)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		netnonopex,

		/// <summary>
		/// Net Nonoperating Expense Percent (NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		nnep,

		/// <summary>
		/// Net Nonoperating Obligations (NNO)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		netnonopobligations,

		/// <summary>
		/// Net Occupancy & Equipment Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		netoccupancyequipmentexpense,

		/// <summary>
		/// Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		nopat,

		/// <summary>
		/// Net Realized & Unrealized Capital Gains on Investments
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		netrealizedcapitalgains,

		/// <summary>
		/// Net Working Capital (NWC)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		nwc,

		/// <summary>
		/// Net Working Capital to Revenue
		/// Statement code: calculations, type: liquidity, units: percentage 
		/// </summary>
		nwctorev,

		/// <summary>
		/// Next Year Forecasted Earnings Yield
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		nextyearearningsyield,

		/// <summary>
		/// Non-Cash Adjustments To Reconcile Net Income
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		noncashadjustmentstonetincome,

		/// <summary>
		/// Non-Interest Bearing Deposits
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		noninterestbearingdeposits,

		/// <summary>
		/// Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		noncontrollinginterests,

		/// <summary>
		/// Noncontrolling Interest Sharing Ratio
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		noncontrollinginterestsharingratio,

		/// <summary>
		/// Noncontrolling Interests to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		noncontrolinttocap,

		/// <summary>
		/// Noncurrent Deferred & Payable Income Tax Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		noncurrentdeferredtaxliabilities,

		/// <summary>
		/// Noncurrent Deferred & Refundable Income Taxes
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		noncurrentdeferredtaxassets,

		/// <summary>
		/// Noncurrent Deferred Revenue
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		noncurrentdeferredrevenue,

		/// <summary>
		/// Noncurrent Employee Benefit Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		noncurrentemployeebenefitliabilities,

		/// <summary>
		/// Noncurrent Note & Lease Receivables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		noncurrentnotereceivables,

		/// <summary>
		/// Nonoperating Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		nonoperatingincome,

		/// <summary>
		/// NOPAT Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		nopatgrowth,

		/// <summary>
		/// NOPAT Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		nopatlesscapextointex,

		/// <summary>
		/// NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		nopatmargin,

		/// <summary>
		/// NOPAT Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		nopatqoqgrowth,

		/// <summary>
		/// NOPAT to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		nopattointerestex,

		/// <summary>
		/// Normalized Net Operating Profit after Tax (NOPAT)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		normalizednopat,

		/// <summary>
		/// Normalized NOPAT Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		normalizednopatmargin,

		/// <summary>
		/// Note & Lease Receivable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		notereceivable,

		/// <summary>
		/// One Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		one_yr_monthly_beta,

		/// <summary>
		/// One Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		one_yr_weekly_beta,

		/// <summary>
		/// Open Price
		/// Statement code: current, type: prices, units: usdpershare 
		/// </summary>
		open_price,

		/// <summary>
		/// Operating Cash Flow Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		ocfgrowth,

		/// <summary>
		/// Operating Cash Flow Less CapEx to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		ocflesscapextointerestex,

		/// <summary>
		/// Operating Cash Flow Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		ocfqoqgrowth,

		/// <summary>
		/// Operating Cash Flow to CapEx
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		ocftocapex,

		/// <summary>
		/// Operating Cash Flow to Interest Expense
		/// Statement code: calculations, type: coverage, units: float 
		/// </summary>
		ocftointerestex,

		/// <summary>
		/// Operating Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		operatingcostofrevenue,

		/// <summary>
		/// Operating Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		opextorevenue,

		/// <summary>
		/// Operating Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		operatingmargin,

		/// <summary>
		/// Operating Return on Assets (OROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		oroa,

		/// <summary>
		/// Operating Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		operatingrevenue,

		/// <summary>
		/// Other Adjustments to Consolidated Net Income / (Loss)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		otheradjustmentstoconsolidatednetincome,

		/// <summary>
		/// Other Adjustments to Net Income / (Loss) Attributable to Common Shareholders)
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		otheradjustmentstonetincometocommon,

		/// <summary>
		/// Other Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		otherassets,

		/// <summary>
		/// Other Cost of Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		othercostofrevenue,

		/// <summary>
		/// Other Current Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		othercurrentassets,

		/// <summary>
		/// Other Current Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		othercurrentliabilities,

		/// <summary>
		/// Other Current Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		othercurrentnonoperatingassets,

		/// <summary>
		/// Other Current Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		othercurrentnonoperatingliabilities,

		/// <summary>
		/// Other Equity Adjustments
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		otherequity,

		/// <summary>
		/// Other Financing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		otherfinancingactivitiesnet,

		/// <summary>
		/// Other Gains / (Losses), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		othergains,

		/// <summary>
		/// Other Income / (Expense), net
		/// Statement code: income_statement, type: nonoperating, units: usd 
		/// </summary>
		otherincome,

		/// <summary>
		/// Other Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		otherinterestexpense,

		/// <summary>
		/// Other Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		otherinterestincome,

		/// <summary>
		/// Other Investing Activities, net
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		otherinvestingactivitiesnet,

		/// <summary>
		/// Other Long-Term Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		otherlongtermliabilities,

		/// <summary>
		/// Other Net Changes in Cash
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		othernetchangesincash,

		/// <summary>
		/// Other Non-Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		othernoninterestincome,

		/// <summary>
		/// Other Noncurrent Nonoperating Assets
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		othernoncurrentnonoperatingassets,

		/// <summary>
		/// Other Noncurrent Nonoperating Liabilities
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		othernoncurrentnonoperatingliabilities,

		/// <summary>
		/// Other Noncurrent Operating Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		othernoncurrentassets,

		/// <summary>
		/// Other Noncurrent Operating Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		othernoncurrentliabilities,

		/// <summary>
		/// Other Operating Expenses / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		otheroperatingexpenses,

		/// <summary>
		/// Other Revenue
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		otherrevenue,

		/// <summary>
		/// Other Service Charges
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		otherservicechargeincome,

		/// <summary>
		/// Other Short-Term Payables
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		othershorttermpayables,

		/// <summary>
		/// Other Special Charges / (Income)
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		otherspecialcharges,

		/// <summary>
		/// Other Taxes Payable
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		othertaxespayable,

		/// <summary>
		/// Participating Policy Holder Equity
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		participatingpolicyholderequity,

		/// <summary>
		/// Payment of Dividends
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		paymentofdividends,

		/// <summary>
		/// Percent Change in Price
		/// Statement code: current, type: prices, units: percentage 
		/// </summary>
		percent_change,

		/// <summary>
		/// Plant, Property & Equipment, gross
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		grossppe,

		/// <summary>
		/// Plant, Property, & Equipment, net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		netppe,

		/// <summary>
		/// Policy Holder Funds
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		policyholderfunds,

		/// <summary>
		/// Pre Tax Income Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		pretaxincomemargin,

		/// <summary>
		/// Preferred Equity to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		preferredtocap,

		/// <summary>
		/// Preferred Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalpreferredequity,

		/// <summary>
		/// Preferred Stock Dividends Declared
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		preferreddividends,

		/// <summary>
		/// Premises and Equipment, Net
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		netpremisesandequipment,

		/// <summary>
		/// Premiums Earned
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		premiumsearned,

		/// <summary>
		/// Prepaid Expenses
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		prepaidexpenses,

		/// <summary>
		/// Price Date
		/// Statement code: current, type: prices, units: date 
		/// </summary>
		price_date,

		/// <summary>
		/// Price Time
		/// Statement code: current, type: prices, units: time 
		/// </summary>
		price_time,

		/// <summary>
		/// Price to Book Value (P/BV)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		pricetobook,

		/// <summary>
		/// Price to Current Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		pricetocurrentyearearnings,

		/// <summary>
		/// Price to Current Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		pricetocurrentyearrevenue,

		/// <summary>
		/// Price to Earnings (P/E)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		pricetoearnings,

		/// <summary>
		/// Price to Next Year Forecasted Earnings
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		pricetonextyearearnings,

		/// <summary>
		/// Price to Next Year Forecasted Revenue
		/// Statement code: current, type: valuation, units: multiple 
		/// </summary>
		pricetonextyearrevenue,

		/// <summary>
		/// Price to Revenue (P/Rev)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		pricetorevenue,

		/// <summary>
		/// Price to Tangible Book Value (P/TBV)
		/// Statement code: calculations, type: valuation, units: multiple 
		/// </summary>
		pricetotangiblebook,

		/// <summary>
		/// Profit (Net Income) Margin
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		profitmargin,

		/// <summary>
		/// Property & Liability Insurance Claims
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		propertyliabilityinsuranceclaims,

		/// <summary>
		/// Provision for Credit Losses
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		provisionforcreditlosses,

		/// <summary>
		/// Provision For Loan Losses
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		provisionforloanlosses,

		/// <summary>
		/// Purchase of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		purchaseofinvestments,

		/// <summary>
		/// Purchase of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		purchaseofplantpropertyandequipment,

		/// <summary>
		/// Quick Ratio
		/// Statement code: calculations, type: liquidity, units: float 
		/// </summary>
		quickratio,

		/// <summary>
		/// R&D to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		rdextorevenue,

		/// <summary>
		/// Redeemable Noncontrolling Interest
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		redeemablenoncontrollinginterest,

		/// <summary>
		/// Repayment of Debt
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		repaymentofdebt,

		/// <summary>
		/// Repurchase of Common Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		repurchaseofcommonequity,

		/// <summary>
		/// Repurchase of Preferred Equity
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		repurchaseofpreferredequity,

		/// <summary>
		/// Research & Development Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		rdexpense,

		/// <summary>
		/// Restricted Cash
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		restrictedcash,

		/// <summary>
		/// Restructuring Charge
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		restructuringcharge,

		/// <summary>
		/// Retained Earnings
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		retainedearnings,

		/// <summary>
		/// Return on Assets (ROA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		roa,

		/// <summary>
		/// Return on Common Equity (ROCE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		roce,

		/// <summary>
		/// Return on Equity (ROE)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		roe,

		/// <summary>
		/// Return on Invested Capital (ROIC)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		roic,

		/// <summary>
		/// Return on Net Nonoperating Assets (RNNOA)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		rnnoa,

		/// <summary>
		/// Revenue Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		revenuegrowth,

		/// <summary>
		/// Revenue Q/Q Growth
		/// Statement code: calculations, type: growth, units: percentage 
		/// </summary>
		revenueqoqgrowth,

		/// <summary>
		/// ROIC Less NNEP Spread (ROIC-NNEP)
		/// Statement code: calculations, type: effectiveness, units: percentage 
		/// </summary>
		roicnnepspread,

		/// <summary>
		/// Salaries and Employee Benefits
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		salariesandemployeebenefitsexpense,

		/// <summary>
		/// Sale and/or Maturity of Investments
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		saleofinvestments,

		/// <summary>
		/// Sale of Property, Plant & Equipment
		/// Statement code: cash_flow_statement, type: , units: usd 
		/// </summary>
		saleofplantpropertyandequipment,

		/// <summary>
		/// SEC Centeral Index Key (CIK)
		/// Statement code: current, type: info, units: string 
		/// </summary>
		cik,

		/// <summary>
		/// Sector
		/// Statement code: current, type: info, units: string 
		/// </summary>
		sector,

		/// <summary>
		/// Security Class
		/// Statement code: current, type: security, units: string 
		/// </summary>
		security_class,

		/// <summary>
		/// Security Name
		/// Statement code: current, type: security, units: string 
		/// </summary>
		security_name,

		/// <summary>
		/// Security Round Lot Size
		/// Statement code: current, type: security, units: shares 
		/// </summary>
		security_round_lot_size,

		/// <summary>
		/// Security Ticker Symbol
		/// Statement code: current, type: security, units: string 
		/// </summary>
		security_ticker,

		/// <summary>
		/// Security Type
		/// Statement code: current, type: security, units: string 
		/// </summary>
		security_type,

		/// <summary>
		/// Selling, General & Admin Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		sgaexpense,

		/// <summary>
		/// Separate Account Business Assets
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		separateaccountbusinessassets,

		/// <summary>
		/// Separate Account Business Liabilities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		separateaccountbusinessliabilities,

		/// <summary>
		/// Service Charges on Deposit Accounts
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		servicechargesondepositsincome,

		/// <summary>
		/// Seven Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		seven_yr_monthly_beta,

		/// <summary>
		/// Seven Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		seven_yr_weekly_beta,

		/// <summary>
		/// SG&A Expenses to Revenue
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		sgaextorevenue,

		/// <summary>
		/// Short Description
		/// Statement code: current, type: info, units: string 
		/// </summary>
		short_description,

		/// <summary>
		/// Short Interest
		/// Statement code: current, type: short_interest, units: shares 
		/// </summary>
		short_interest,

		/// <summary>
		/// Short-Term Borrowings Interest Expense
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		shorttermborrowinginterestexpense,

		/// <summary>
		/// Short-Term Debt
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		shorttermdebt,

		/// <summary>
		/// Short-Term Debt to Total Capital
		/// Statement code: calculations, type: capital_structure, units: percentage 
		/// </summary>
		stdebttocap,

		/// <summary>
		/// Short-Term Investments
		/// Statement code: balance_sheet, type: nonoperating, units: usd 
		/// </summary>
		shortterminvestments,

		/// <summary>
		/// Split Ratio
		/// Statement code: current, type: prices, units: float 
		/// </summary>
		split_ratio,

		/// <summary>
		/// Standard Industrial Classification Code (SIC)
		/// Statement code: current, type: info, units: integer 
		/// </summary>
		sic,

		/// <summary>
		/// State
		/// Statement code: current, type: info, units: string 
		/// </summary>
		state,

		/// <summary>
		/// Stock Exchange
		/// Statement code: current, type: info, units: string 
		/// </summary>
		stock_exchange,

		/// <summary>
		/// Tangible Book Value per Share
		/// Statement code: calculations, type: metric, units: usdpershare 
		/// </summary>
		tangbookvaluepershare,

		/// <summary>
		/// Tax Burden Percent
		/// Statement code: calculations, type: profitability, units: percentage 
		/// </summary>
		taxburdenpct,

		/// <summary>
		/// Template
		/// Statement code: current, type: info, units: string 
		/// </summary>
		template,

		/// <summary>
		/// Ten Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		ten_yr_monthly_beta,

		/// <summary>
		/// Ten Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		ten_yr_weekly_beta,

		/// <summary>
		/// Three Year Monthly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		three_yr_monthly_beta,

		/// <summary>
		/// Three Year Weekly Beta
		/// Statement code: current, type: betas, units: float 
		/// </summary>
		three_yr_weekly_beta,

		/// <summary>
		/// Ticker Symbol
		/// Statement code: current, type: info, units: string 
		/// </summary>
		ticker,

		/// <summary>
		/// Time Deposits Placed and Other Short-Term Investments
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		timedepositsplaced,

		/// <summary>
		/// Total Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalassets,

		/// <summary>
		/// Total Capital
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		totalcapital,

		/// <summary>
		/// Total Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalcommonequity,

		/// <summary>
		/// Total Cost of Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totalcostofrevenue,

		/// <summary>
		/// Total Current Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalcurrentassets,

		/// <summary>
		/// Total Current Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalcurrentliabilities,

		/// <summary>
		/// Total Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		debt,

		/// <summary>
		/// Total Depreciation and Amortization (D&A)
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		depreciationandamortization,

		/// <summary>
		/// Total Equity & Noncontrolling Interests
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalequityandnoncontrollinginterests,

		/// <summary>
		/// Total Gross Profit
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totalgrossprofit,

		/// <summary>
		/// Total Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalliabilities,

		/// <summary>
		/// Total Liabilities & Shareholders’ Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalliabilitiesandequity,

		/// <summary>
		/// Total Long-Term Debt
		/// Statement code: calculations, type: metric, units: usd 
		/// </summary>
		ltdebtandcapleases,

		/// <summary>
		/// Total Non-Interest Expense
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totalnoninterestexpense,

		/// <summary>
		/// Total Non-Interest Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totalnoninterestincome,

		/// <summary>
		/// Total Noncurrent Assets
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalnoncurrentassets,

		/// <summary>
		/// Total Noncurrent Liabilities
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalnoncurrentliabilities,

		/// <summary>
		/// Total Operating Expenses
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totaloperatingexpenses,

		/// <summary>
		/// Total Operating Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totaloperatingincome,

		/// <summary>
		/// Total Other Income / (Expense), net
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totalotherincome,

		/// <summary>
		/// Total Pre-Tax Income
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totalpretaxincome,

		/// <summary>
		/// Total Preferred & Common Equity
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		totalequity,

		/// <summary>
		/// Total Revenue
		/// Statement code: income_statement, type: , units: usd 
		/// </summary>
		totalrevenue,

		/// <summary>
		/// Trading Account Interest Income
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		tradingaccountinterestincome,

		/// <summary>
		/// Trading Account Securities
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		tradingaccountsecurities,

		/// <summary>
		/// Trailing Dividend Rate
		/// Statement code: current, type: dividend, units: usdpershare 
		/// </summary>
		dividend_rate,

		/// <summary>
		/// Trailing Dividend Yield
		/// Statement code: current, type: dividend, units: percentage 
		/// </summary>
		trailing_dividend_yield,

		/// <summary>
		/// Treasury Stock
		/// Statement code: balance_sheet, type: , units: usd 
		/// </summary>
		treasurystock,

		/// <summary>
		/// Trust Fees by Commissions
		/// Statement code: income_statement, type: operating, units: usd 
		/// </summary>
		trustfeeincome,

		/// <summary>
		/// Unearned Premiums Asset
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		unearnedpremiumsdebit,

		/// <summary>
		/// Unearned Premiums Liability
		/// Statement code: balance_sheet, type: operating, units: usd 
		/// </summary>
		unearnedpremiumscredit,

		/// <summary>
		/// Volume
		/// Statement code: current, type: prices, units: shares 
		/// </summary>
		volume,

		/// <summary>
		/// Weighted Average Basic & Diluted Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		weightedavebasicdilutedsharesos,

		/// <summary>
		/// Weighted Average Basic Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		weightedavebasicsharesos,

		/// <summary>
		/// Weighted Average Diluted Shares Outstanding
		/// Statement code: income_statement, type: , units: shares 
		/// </summary>
		weightedavedilutedsharesos

	}
}
