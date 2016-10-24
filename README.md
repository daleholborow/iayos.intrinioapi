# iayos.intrinioapi

Interface with Intrinio.com financial data API, (specifically the Master Data and US Company data functionality). Library maintained by http://www.inayearorso.io but IaYoS (and associated code) in no way affiliated with Intrinio.

Currently, master branch will contain access to Master Data and US Company Data (excluding news). Develop and feature branches are... well.. you know. 

I will publish a NuGet package for this library shortly, but other than some refactoring and minor bug fixes (as I discover them), work will largely cease as I have little need for the other data feeds (Insider transactions, Institutional holdings, Economic Data, Sector, bank and real-time prices).

That said, anyone who wants those features should be able to easily see the style of the code layout and structure, and I welcome any contributions and pull-requests!

Library is dead simple, check out the .Test project for initial examples of how to query Intrinio api.

E.g: query http://docs.intrinio.com/#companies and get back a wrapper for http://docs.intrinio.com/#return-values42

~~~~
var intrinio = new IntrinioClient(username, password);`
var companiesResponse = intrinio.GetMasterCompaniesList(new GetCompaniesMasterList { });
~~~~

voila!
