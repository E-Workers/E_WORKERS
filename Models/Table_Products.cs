namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Products
    {
        [Key]
        public int Products_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Products_Name { get; set; }

       
        [StringLength(500)]
        public string Products_Image { get; set; }

        [Required]
        [StringLength(500)]
        public string Products_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Products_SalePrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Products_PurchasePrice { get; set; }

        public int Category_Product_FID { get; set; }


        public virtual Table_Categories_Product Table_Categories_Product{ get; set; }
    }
}
