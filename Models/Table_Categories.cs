namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Categories
    {
        [Key]
        public int Categories_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Categories_Name { get; set; }
       

        public int Service_FID { get; set; }

        public virtual Table_Service Table_Service { get; set; }
    }
}
