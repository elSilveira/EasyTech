using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalentosEasy.Models
{
    [Table("Conhecimento")]
    public class Conhecimento
    {
        [Key]
        public int IdConhecimento { get; set; }
        public string NomeConhecimento { get; set; }
        public int NotaConhecimento { get; set; }
    }
}