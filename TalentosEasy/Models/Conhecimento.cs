using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalentosEasy.Models
{
    [Table("Conhecimentos")]
    public class Conhecimento
    {
        [Key]
        public int IdConhecimento { get; set; }

        public int IdTalento { get; set; }
        [ForeignKey("IdTalento")]
        public virtual Talento Talento { get; set; }

        public string NomeConhecimento { get; set; }
    }
}