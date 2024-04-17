using System.ComponentModel.DataAnnotations.Schema;

namespace Proposals.API.Entities
{
    public class User :EntityBase
    {
        public int  OrcId { get; set; }
        public string Name { get; set; }

        public int? ExperimentId { get; set; }

        [ForeignKey("ExperimentId")]
        public virtual Experiment Experiment { get; set; }
    }
}
