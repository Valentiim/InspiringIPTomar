using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InspiringIPTomar.Models
{
    public class Admin_Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        public int Password { get; set; }

        public virtual Funcionarios funcion { get; set; }
    }
}
