﻿using Xunit;

namespace iayos.intrinioapi.Api.Test
{
    public class Class1
    {
	    private IntrinioClient _client;

		public Class1()
	    {
		    var username = "";
		    var password = "";

			_client = new IntrinioClient(username, password);
	    }


	    [Fact]
	    public void DoSomeStuff()
	    {
			   
	    }

    }
}
