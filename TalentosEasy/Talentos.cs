namespace TalentosEasy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Talentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Talentos()
        {
            Conhecimentos = new HashSet<Conhecimentos>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTalento { get; set; }

        [StringLength(254)]
        public string nomeTalento { get; set; }

        [StringLength(254)]
        public string emailTalento { get; set; }

        [StringLength(254)]
        public string cidadeTalento { get; set; }

        [StringLength(254)]
        public string telefoneTalento { get; set; }

        [StringLength(254)]
        public string linkedinTalento { get; set; }

        [StringLength(254)]
        public string skypeTalento { get; set; }

        [StringLength(254)]
        public string estadoTalento { get; set; }

        [StringLength(254)]
        public string portifolioTalento { get; set; }

        [StringLength(254)]
        public string disponibilidadeTalento { get; set; }

        [StringLength(254)]
        public string horarioTalento { get; set; }

        [StringLength(254)]
        public string pretencaoTalento { get; set; }

        [StringLength(254)]
        public string nomeTalentoBanco { get; set; }

        [StringLength(254)]
        public string agenciaTalento { get; set; }

        [StringLength(254)]
        public string cpfTalento { get; set; }

        [StringLength(254)]
        public string contaTalento { get; set; }

        [StringLength(254)]
        public string bancoTalento { get; set; }

        [StringLength(254)]
        public string tipoContaTalento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conhecimentos> Conhecimentos { get; set; }
    }
}
