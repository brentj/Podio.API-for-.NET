using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class Via
	{


		[DataMember(Name = "id", IsRequired=false)]
		public int? Id { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "url", IsRequired=false)]
		public string Url { get; set; }


		[DataMember(Name = "display", IsRequired=false)]
		public bool? Display { get; set; }

        [DataMember(Name = "auth_client_id", IsRequired = false)]
        public int? AuthClientId { get; set; }
	}
}

