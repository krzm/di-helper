using System;
using System.Collections.Generic;

namespace DIHelper.Tests.Helper;

public class UnityContainerMock : IUnityContainerMock
{
	private readonly IDictionary<string, object> containerMock
		= new Dictionary<string, object>();

	public void Register<TType>(
		string key
		, TType instance)
	{
		ArgumentNullException.ThrowIfNull(instance);
		containerMock.Add(key, instance);
	}

	public TType GetInstance<TType>(string key)
	{
		return (TType)containerMock[key];
	}
}