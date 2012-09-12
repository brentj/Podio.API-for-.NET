using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Form 
	{


		[DataMember(Name = "form_id", IsRequired=false)]
		public int? FormId { get; set; }


		[DataMember(Name = "app_id", IsRequired=false)]
		public int? AppId { get; set; }


		[DataMember(Name = "space_id", IsRequired=false)]
		public int? SpaceId { get; set; }


        //[DataMember(Name = "settings", IsRequired=false)]
        //public  Settings { get; set; }


		[DataMember(Name = "domains", IsRequired=false)]
		public string[] Domains { get; set; }


		[DataMember(Name = "fields", IsRequired=false)]
		public string[] Fields { get; set; }


		[DataMember(Name = "attachments", IsRequired=false)]
		public bool Attachments { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "field_ids", IsRequired=false)]
		public string[] FieldIds { get; set; }


	}
}

