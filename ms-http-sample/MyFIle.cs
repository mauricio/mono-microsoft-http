using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Microsoft.Http;

namespace mshttpsample
{
	[DataContract]
	public class MyFIle
	{
		public MyFIle ()
		{
		}
		
		[DataMember]
		public string Name {
			get;
			set;
		}
		
		
		public static void Main (String[] args)
		{
			HttpClient client = new HttpClient ("localhost:3000");
			HttpResponseMessage response = client.Get ("/ze/api/plans.json"); 
			
		}
		
	}
}

