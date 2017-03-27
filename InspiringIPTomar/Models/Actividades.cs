namespace InspiringIPTomar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;
    public partial class Actividades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [Key]
        public int ActividadeID { get; set; }

        [Display(Name = "Categoria Actividade")]
        public string TipoActividade { get; set; }
        [Display(Name = "Descrição da Actividade")]
        public string Descricao { get; set; }
        [Display(Name = "Upload de Foto")]
        public string ImagePath { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    }
}
