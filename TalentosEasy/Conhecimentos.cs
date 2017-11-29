namespace TalentosEasy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conhecimentos
    {
        public int? idTalento { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idConhecimento { get; set; }

        [StringLength(254)]
        public string nomeConhecimento { get; set; }

        public virtual Talentos Talentos { get; set; }
    }
}
