using System;
using System.Reflection;

namespace iayos.intrinioapi
{
	public static class IntrinioClientUtils
	{
		//bool IsAnyNullOrEmpty(object myObject)
		//{
		//	foreach (PropertyInfo pi in myObject.GetType().GetProperties())
		//	{
		//		string value = (string)pi.GetValue(myObject);
		//		if (String.IsNullOrEmpty(value))
		//		{
		//			return false;
		//		}
		//	}
		//	return true;
		//}

		public static bool IsAllNullOrEmpty(object myObject)
		{
			foreach (PropertyInfo pi in myObject.GetType().GetProperties())
			{
				string value = (string)pi.GetValue(myObject);
				if (String.IsNullOrEmpty(value) == false)
				{
					return false;
				}
			}
			return true;
		}
	}
}