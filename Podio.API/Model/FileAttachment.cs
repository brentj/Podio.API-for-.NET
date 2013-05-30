using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class FileAttachment
	{


		[DataMember(Name = "file_id", IsRequired=false)]
		public int? FileId { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "perma_link", IsRequired=false)]
		public string PermaLink { get; set; }


		[DataMember(Name = "thumbnail_link", IsRequired=false)]
		public string ThumbnailLink { get; set; }


		[DataMember(Name = "hosted_by", IsRequired=false)]
		public string HostedBy { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "description", IsRequired=false)]
		public string Description { get; set; }


		[DataMember(Name = "mimetype", IsRequired=false)]
		public string Mimetype { get; set; }


		[DataMember(Name = "size", IsRequired=false)]
		public int? Size { get; set; }


		[DataMember(Name = "context", IsRequired=false)]
		public Dictionary<string,object> Context { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime? CreatedOn { get; set; }


		[DataMember(Name = "rights", IsRequired=false)]
		public string[] Rights { get; set; }


		[DataMember(Name = "subscribed", IsRequired=false)]
		public bool? Subscribed { get; set; }


		[DataMember(Name = "subscribed_count", IsRequired=false)]
		public int? SubscribedCount { get; set; }


		[DataMember(Name = "push", IsRequired=false)]
		public Dictionary<string,object> Push { get; set; }


		[DataMember(Name = "presence", IsRequired=false)]
		public Dictionary<string,object> Presence { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "created_via", IsRequired=false)]
		public Via CreatedVia { get; set; }


		[DataMember(Name = "replaces", IsRequired=false)]
		public List<FileAttachment> Replaces { get; set; }


		[DataMember(Name = "comments", IsRequired=false)]
		public List<Comment> Comments { get; set; }


	}
}

