namespace Proposals.API.Entities
{
    public class Experiment : EntityBase
    {
        public Guid ProposalNumber { get; set; }
        public string Abstract { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
       
    }
}
