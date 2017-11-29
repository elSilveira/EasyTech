using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalentosEasy.Models
{
    [Table("Talento")]
    public class Talento
    {
        [Key]
        public int IdTalento { get; set; }
        public string NomeTalento { get; set; }
        public string EmailTalento { get; set; }
        public string CidadeTalento { get; set; }
        public string TelefoneTalento { get; set; }
        public string LinkedinTalento { get; set; }
        public string SkypeTalento { get; set; }
        public string EstadoTalento { get; set; }
        public string PortifolioTalento { get; set; }
        public string DisponibilidadeTalento { get; set; }
        public string HorarioTalento { get; set; }
        public string PretencaoTalento { get; set; }
        public string NomeTalentoBanco { get; set; }
        public string AgenciaTalento { get; set; }
        public string CpfTalento { get; set; }
        public string ContaTalento { get; set; }
        public string BancoTalento { get; set; }
        public string TipoContaTalento { get; set; }
        public string OutroConhecimentoTalento { get; set; }
        public string CrudTalento { get; set; }

    }
}