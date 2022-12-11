namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Categories_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Categories_Product()
        {
            Table_Products = new HashSet<Table_Products>();
        }

        [Key]
        public int Categories_Product_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Categories_Product_Name { get; set; }

        [StringLength(50)]
        public string Categories_Product_Icon { get; set; }

        [Required]
        [StringLength(50)]
        public string Categories_Product_Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Products> Table_Products { get; set; }
    }
}
