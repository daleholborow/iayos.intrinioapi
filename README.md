# iayos.intrinioapi

Interface with Intrinio.com financial data API, (specifically/mainly/chiefly the Master Data and US Company data functionality). The iayos.intrinioapi library is owned & maintained by http://www.inayearorso.io but IaYoS (and associated code) in no way affiliated with Intrinio. While I encourage contributions, bug fixes and comments, this library is delivered with much enthusiasm, but zero warranty. 

Currently, master branch contains methods to access Master Data, US Company Data, and some insider functions. Develop and feature branches are... well.. you know... developy... so should be considered volatile.

Alternatively, to install the Nuget package of iayos.intrinioapi, run the following command in the Package Manager Console:

~~~~
Install-Package iayos.intrinioapi.Api
~~~~

Other than some refactoring and minor bug fixes (as I discover them), work will largely cease as I have little need for the other data feeds (Insider transactions is partly done, but: Institutional holdings, Economic Data, Sector, bank and real-time prices I am unlikely to need for my particular strategies, and I'm time-poor - sorry guys!).

That said, anyone who wants those features should be able to easily see the style of the code layout and structure, and I welcome any contributions and pull-requests!

Library is dead simple, check out the .Test project for initial examples of how to query Intrinio api. All requests inherit the Request abstract class, and all responses Response<SomeType>. Doco is copied from Intrinio for reference, but their site is authoritive.

E.g: query http://docs.intrinio.com/#companies and get back a class wrapping the payload for for http://docs.intrinio.com/#return-values42

~~~~
var intrinio = new IntrinioClient(username, password);`
var companiesResponse = intrinio.GetMasterCompaniesList(new GetCompaniesMasterList { });
~~~~

voila!


Note: To build the tests, create the AppSettings.Private.config file in the same directory as the .Test/App.Config with an appsettings section, with tokens for Intrinio username and password. You'll see what I mean.

Finally, www.inayearorso.io is currently fairly empty, but I plan to blog about my adventures in algorithmically-applied fundamentals-based investing... anyone with similar interests, please reach out, I'm looking for likeminded peers of all shapes and sizes!