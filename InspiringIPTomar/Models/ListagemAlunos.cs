using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InspiringIPTomar.Models
{
    public class ListagemAlunos
    {
        public int AlunoID { get; set; }
        [Display(Name = "Aluno")]
        public string Nome { get; set; }
        [Display(Name = "Concelho")]
        public string Concelho { get; set; }
        [Display(Name = "E-Mail")]
        public string EMAIL { get; set; }
        [Display(Name = "Contacto")]
        public string Contacto { get; set; }
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        [Display(Name = "Data de Nascimento")]
        public string Data_Nascimento { get; set; }
        [Display(Name = "Habilitações Académicas")]
        public string Habilitacoes { get; set; }
        [Display(Name = "Informações sobre cursos")]
        public string Informacoes { get; set; }
        [Display(Name = "Áreas de interesse")]
        public string Areas { get; set; }
        [Display(Name = "Observações")]
        public string Obs { get; set; }
        
       
    }
}