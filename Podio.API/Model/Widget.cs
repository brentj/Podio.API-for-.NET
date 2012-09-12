using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Widget 
	{


		[DataMember(Name = "widget_id", IsRequired=false)]
		public int? WidgetId { get; set; }


		[DataMember(Name = "ref_type", IsRequired=false)]
		public string RefType { get; set; }


		[DataMember(Name = "ref_id", IsRequired=false)]
		public int? RefId { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


        //[DataMember(Name = "config", IsRequired=false)]
        //public  Config { get; set; }


        //[DataMember(Name = "ref", IsRequired=false)]
        //public  Ref { get; set; }


		[DataMember(Name = "rights", IsRequired=false)]
		public string[] Rights { get; set; }


        //[DataMember(Name = "data", IsRequired=false)]
        //public  Data { get; set; }


	}
}

