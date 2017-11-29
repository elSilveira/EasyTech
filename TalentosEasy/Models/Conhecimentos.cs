using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalentosEasy.Models
{
    [Table("Conhecimentos")]
    public class Conhecimentos
    {
        [Key]
        public int IdTalento { get; set; }
        [ForeignKey("idConhecimento")]
        public int IdConhecimento { get; set; }

        public virtual Talentos Talentos { get; set; }

        public string NomeConhecimento { get; set; }
    }
}