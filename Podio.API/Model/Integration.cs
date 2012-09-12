using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Integration 
	{


		[DataMember(Name = "integration_id", IsRequired=false)]
		public int? IntegrationId { get; set; }


		[DataMember(Name = "app_id", IsRequired=false)]
		public int? AppId { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "silent", IsRequired=false)]
		public bool Silent { get; set; }


        //[DataMember(Name = "config", IsRequired=false)]
        //public  Config { get; set; }


        //[DataMember(Name = "mapping", IsRequired=false)]
        //public  Mapping { get; set; }


		[DataMember(Name = "updating", IsRequired=false)]
		public bool Updating { get; set; }


		[DataMember(Name = "last_updated_on", IsRequired=false)]
		public string LastUpdatedOn { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public string CreatedOn { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


	}
}

