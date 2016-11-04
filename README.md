# iayos.intrinioapi

Interface with Intrinio.com financial data API, (specifically/mainly/chiefly the Master Data and US Company data functionality). The iayos.intrinioapi library is owned & maintained by http://www.inayearorso.io but IaYoS (and associated code) in no way affiliated with Intrinio. While I encourage contributions, bug fixes and comments, this library is delivered with much enthusiasm, but zero warranty. 

Currently, master branch contains methods to access Master Data, US Company Data, Insider transactions and Institutional holdings. Develop and feature branches are... well.. you know... developy... so should be considered volatile, so don't use them (I recommend that you use the nuget package anyway)

Alternatively, to install the Nuget package of iayos.intrinioapi, it is available as a nuget package (utilizing SemVer semantic versioning style with a GitFlow source control strategy and AppVeyor for continuous integration and deployment to NuGet). As per SemVer: 

MajorVersion - breaking change that may require some refactoring when you update

MinorVersion - new backwards compatability to add new functionality without breaking existing

MiniVersion - hotfixes for urgent release patches

I will try my absolute best to make sure that these rules are followed, but don't hit me with sticks if occasionally there are hiccups (late nights and not enough coffee)

Conveniently, iayos.intrinioapi is [available on NuGet](https://www.nuget.org/packages/iayos.intrinioapi/) as `iayos.intrinioapi`. Install it from NuGet Package Manager Console with:
	
~~~~
Install-Package iayos.intrinioapi
~~~~

Other than some refactoring and minor bug fixes (as I discover them), work to wrap additional endpoints will likely largely cease as I have little need for the other data feeds (Economic Data, Sector, bank and real-time prices I am unlikely to need for my particular strategies, and I'm time-poor - sorry guys!).

That said, anyone who wants those features should be able to easily see the style of the code layout and structure, and I welcome any contributions and pull-requests!

Library is dead simple, check out the .Test project for initial examples of how to query Intrinio api. 

Generally speaking, you GetSingleOfSomething(), GetPluralsOfSomething(), SearchSomething()... most methods take that general form, depending on what data they are targetting. Note that sometimes Intrinio return a collection as an array, and sometimes they bundle collections into a "data" property and include other metadata for paging purposes.

All requests will therefore inherit the RequestSingle or RequestMultiple interfaces as required, and similarly all responses inherit a SingleResponse, ListResponse, MetaListResponse... Get familiar with Intrinion and you'll see. All doco is copied from Intrinio for reference, but their site is authoritive.

E.g: query http://docs.intrinio.com/#indices54 and get back a class wrapping the payload for http://docs.intrinio.com/#indices47

~~~~
var intrinio = new IntrinioClient(username, password);
var request = new GetSingleIndexDetails { identifier = "$TA100" };
var requestUrl = request.ToGetUrl(); // where we'll be GETTING data from, for interest's sake
var response = ApiClient.GetSingleIndexDetails(request);
~~~~

voila!


Note: To build the tests, create the AppSettings.Private.config file in the same directory as the .Test/App.Config with an appsettings section, with tokens for Intrinio username and password. You'll see what I mean.

Finally, www.inayearorso.io is currently fairly empty, but I plan to blog about my adventures in algorithmically-applied fundamentals-based investing... anyone with similar interests, please reach out, I'm looking for likeminded peers of all shapes and sizes!