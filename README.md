# iayos.intrinioapi

Interface with Intrinio.com financial data API, (specifically/mainly/chiefly the Master Data and US Company data functionality). The iayos.intrinioapi library is owned & maintained by http://www.inayearorso.io but IaYoS (and associated code) in no way affiliated with Intrinio. While I encourage contributions, bug fixes and comments, this library is delivered with much enthusiasm, but zero warranty. 

Currently, master branch contains methods to access Master Data, US Company Data, Insider transactions and Institutional holdings. Develop and feature branches are... well.. you know... developy... so should be considered volatile, so don't use them (I recommend that you use the nuget package anyway)

Alternatively, to install the Nuget package of iayos.intrinioapi, it is available as a nuget package (utilizing SemVer semantic versioning style with a GitFlow source control strategy and AppVeyor for continuous integration and deployment to NuGet). As per SemVer: 

MajorVersion - breaking change that may require some refactoring when you update

MinorVersion - new backwards compatability to add new functionality without breaking existing

MiniVersion - hotfixes for urgent release patches

I will try my absolute best to make sure that these rules are followed, but don't hit me with sticks if occasionally there are hiccups (late nights and not enough coffee)

Run the following command in the Package Manager Console:

iayos.intrinioapi is [available on NuGet](https://www.nuget.org/packages/iayos.intrinioapi/) as `iayos.intrinioapi`. Install it from NuGet Package Manager Console with:
	
~~~~
Install-Package iayos.intrinioapi
~~~~

Other than some refactoring and minor bug fixes (as I discover them), work will likely largely cease as I have little need for the other data feeds (Economic Data, Sector, bank and real-time prices I am unlikely to need for my particular strategies, and I'm time-poor - sorry guys!).

That said, anyone who wants those features should be able to easily see the style of the code layout and structure, and I welcome any contributions and pull-requests!

Library is dead simple, check out the .Test project for initial examples of how to query Intrinio api. All requests inherit the Request abstract class, and all responses Response<SomeType>. Doco is copied from Intrinio for reference, but their site is authoritive.

E.g: query http://docs.intrinio.com/#companies and get back a class wrapping the payload for for http://docs.intrinio.com/#return-values42

~~~~
var intrinio = new IntrinioClient(username, password);
var companiesResponse = intrinio.GetMasterCompaniesList(new GetCompaniesMasterList { });
~~~~

voila!


Note: To build the tests, create the AppSettings.Private.config file in the same directory as the .Test/App.Config with an appsettings section, with tokens for Intrinio username and password. You'll see what I mean.

Finally, www.inayearorso.io is currently fairly empty, but I plan to blog about my adventures in algorithmically-applied fundamentals-based investing... anyone with similar interests, please reach out, I'm looking for likeminded peers of all shapes and sizes!