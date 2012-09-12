using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class LinkedAccount 
	{


		[DataMember(Name = "linked_account_id", IsRequired=false)]
		public int? LinkedAccountId { get; set; }


		[DataMember(Name = "label", IsRequired=false)]
		public string Label { get; set; }


		[DataMember(Name = "provider", IsRequired=false)]
		public string Provider { get; set; }


		[DataMember(Name = "provider_humanized_name", IsRequired=false)]
		public string ProviderHumanizedName { get; set; }


        //[DataMember(Name = "capability_names", IsRequired=false)]
        //public  CapabilityNames { get; set; }


        //[DataMember(Name = "options", IsRequired=false)]
        //public  Options { get; set; }


	}
}

