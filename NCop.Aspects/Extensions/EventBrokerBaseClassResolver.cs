﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by NCop Copyright ©
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated
// ------------------------------------------------------------------------------
namespace NCop.Aspects.Extensions
{
	using System;
	using Engine;
	using System.Collections.Generic;

	internal static class EventBrokerBaseClassResolver
	{
		internal static readonly IDictionary<int, Type> ActionMap = null;
		internal static readonly IDictionary<int, Type> FunctionMap = null;
 
 		static EventBrokerBaseClassResolver() {
			ActionMap = new Dictionary<int, Type>();
			FunctionMap = new Dictionary<int, Type>();

			ActionMap.Add(0, typeof(AbstractActionEventBroker<>));				

			ActionMap.Add(1, typeof(AbstractActionEventBroker<,>));	
			FunctionMap.Add(1, typeof(AbstractFunctionEventBroker<,>));	

			ActionMap.Add(2, typeof(AbstractActionEventBroker<,,>));	
			FunctionMap.Add(2, typeof(AbstractFunctionEventBroker<,,>));	

			ActionMap.Add(3, typeof(AbstractActionEventBroker<,,,>));	
			FunctionMap.Add(3, typeof(AbstractFunctionEventBroker<,,,>));	

			ActionMap.Add(4, typeof(AbstractActionEventBroker<,,,,>));	
			FunctionMap.Add(4, typeof(AbstractFunctionEventBroker<,,,,>));	

			ActionMap.Add(5, typeof(AbstractActionEventBroker<,,,,,>));	
			FunctionMap.Add(5, typeof(AbstractFunctionEventBroker<,,,,,>));	

			ActionMap.Add(6, typeof(AbstractActionEventBroker<,,,,,,>));	
			FunctionMap.Add(6, typeof(AbstractFunctionEventBroker<,,,,,,>));	

			ActionMap.Add(7, typeof(AbstractActionEventBroker<,,,,,,,>));	
			FunctionMap.Add(7, typeof(AbstractFunctionEventBroker<,,,,,,,>));	

			ActionMap.Add(8, typeof(AbstractActionEventBroker<,,,,,,,,>));	
			FunctionMap.Add(8, typeof(AbstractFunctionEventBroker<,,,,,,,,>));	

			FunctionMap.Add(9, typeof(AbstractFunctionEventBroker<,,,,,,,,,>));	
		}
	}
}