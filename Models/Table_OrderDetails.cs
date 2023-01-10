namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_OrderDetails
    {
        [Key]
        public int Order_Detail_ID { get; set; }

        public int Products_FID { get; set; }

        [Required]
       
        public int Product_Quantity { get; set; }

        public int Order_FID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Products_Saleprice { get; set; }

          [Column(TypeName = "numeric")]
        public decimal Products_Purchaseprice { get; set; }

        public virtual Table_Order Table_Order { get; set; }
    }
}
