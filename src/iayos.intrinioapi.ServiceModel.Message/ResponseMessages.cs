﻿using System.Collections;
using System.Collections.Generic;

namespace iayos.intrinioapi.servicemodel.message
{

	public interface IResponse
	{
	}


	/// <summary>
	/// The base Response, typically used for a single return item where the properties are serialised straight into the result.
	/// </summary>
	public interface IResponseSingle : IResponse
	{
	}


	public interface IResponseList : IResponse
	{
	}

	public interface IResponseList<TDto> : IList<TDto>, IResponseList
	{
	}

	public abstract class ResponseList<TDto> : List<TDto>, IResponseList<TDto>
	{
	}


	/// <summary>
	/// The base Response capturing many records returned
	/// </summary>
	public interface IResponseMetaList : IResponse
	{
		int result_count { get; set; }

		int current_page { get; set; }

		int total_pages { get; set; }

		int api_call_credits { get; set; }
	}


	public interface IResponseMetaList<TDto> : IResponseMetaList
	{
		List<TDto> data { get; set; }
	}

	
	/*/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TDto"></typeparam>
	public abstract class ResponseSingle<TDto> : IResponse 
		where TDto : new()
	{
	}*/

	
	/// <summary>
	/// The base Response class where the result is bundled into a payload, with additional metadata, used for collections of results (paged, lists)
	/// </summary>
	/// <typeparam name="TDto"></typeparam>
	public abstract class ResponseMetaList<TDto> : IResponseMetaList<TDto> where TDto : new()
	{

		public int result_count { get; set; }

		public int current_page { get; set; }

		public int total_pages { get; set; }

		public int api_call_credits { get; set; }

		public List<TDto> data { get; set; }
	}
}
