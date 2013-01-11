// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by NCop Copyright � 2012
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace NCop.Aspects.Exceptions
{
	[Serializable]
	public class MissingAspectException : ArgumentException
	{
		private static string _message = "Missing aspect annotation";
		
		public MissingAspectException(string parameterName) : base(_message, parameterName) { }

		public MissingAspectException(Exception innerException) : this(_message, innerException) { }

		public MissingAspectException(string parameterName, string message) : base(message, parameterName) { }

		public MissingAspectException(string message, Exception innerException) : base(message, innerException) { }

		protected MissingAspectException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
	