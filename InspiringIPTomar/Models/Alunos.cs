using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InspiringIPTomar.Models
{
    public class Alunos
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlunoID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public string Concelho { get; set; }
        public string Email { get; set; }
        public int Telemovel { get; set; }
        public string Sexo { get; set; }
        public string Data_Nascimento { get; set; }
        public string HabAcademicas { get; set; }
        public string InforSobre { get; set; }
        public string AreasInteresse { get; set; }
        [StringLength(5000)]
        public string Observacoes { get; set; }

    }

}