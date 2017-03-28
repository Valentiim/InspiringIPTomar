namespace InspiringIPTomar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;
    public partial class Cursos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [Key]
        public int CursoID { get; set; }

        [Display(Name = "Tipo do Curso")]
        public string TipoCurso { get; set; }
        [Display(Name = "Curso")]
        public string Curso { get; set; }
        [Display(Name = "Descrição do Curso")]
        public string Descricao { get; set; }
        [Display(Name = "Upload de Foto")]
        public string ImagePath { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    }
}
