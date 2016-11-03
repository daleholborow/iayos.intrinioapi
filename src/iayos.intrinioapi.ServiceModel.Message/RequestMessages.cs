namespace iayos.intrinioapi.servicemodel.message
{
	
	public interface IRequest
	{
	}


	/// <summary>
	/// The base Request, typically used for requesting a single item where no metadata about paging or results lists will be returned
	/// </summary>
	public interface IRequestSingle : IRequest
	{
	}


	public interface IRequestMany : IRequest
	{
		int page_size { get; set; }

		int page_number { get; set; }
	}


	/// <summary>
	/// The base Request typically used for requesting 1+ items as a collection, with potential paging applied
	/// </summary>
	public abstract class RequestMany : IRequestMany
	{
		public int page_size { get; set; } = 250;

		public int page_number { get; set; } = 1;
	}

}
