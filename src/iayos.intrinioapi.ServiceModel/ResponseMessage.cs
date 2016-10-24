namespace iayos.intrinioapi.ServiceModel
{


	public abstract class Request
	{
		public int page_size { get; set; } = 250;

		public int page_number { get; set; } = 1;
	}


	public abstract class Response<TPayload> where TPayload : new()
	{
		public int result_count { get; set; }

		public int current_page { get; set; }

		public int total_pages { get; set; }

		public int api_call_credits { get; set; }

		public TPayload data { get; set; }
	}
}
