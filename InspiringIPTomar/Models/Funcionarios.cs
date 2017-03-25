using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InspiringIPTomar.Models
{
    public class Funcionarios
    {
        public Funcionarios()
        {
            this.Aluno = new HashSet<Alunos>();

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FuncionarioID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public int NIF { get; set; }
        public string Email { get; set; }
        public int Telemovel { get; set; }
        public string Morada { get; set; }
        public string Cidade { get; set; }

        public virtual ICollection<Alunos> Aluno { get; set; }

    }
}