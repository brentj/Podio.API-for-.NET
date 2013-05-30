using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Podio.API.Model
{
	[DataContract]
	public partial class DateElection
	{
        [DataMember(Name = "date_election_id", IsRequired = false)]
        public int? DateElectionId { get; set; }

        [DataMember(Name = "votes", IsRequired = false)]
        public List<DateElectionVote> Votes { get; set; }

        [DataMember(Name = "options", IsRequired = false)]
        public List<DateElectionOption> Options { get; set; }		
	}
}

