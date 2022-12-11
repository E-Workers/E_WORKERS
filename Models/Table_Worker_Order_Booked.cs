namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Worker_Order_Booked
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Worker_Order_BookedID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal Worker_Order_Booked_Date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Worker_Order_Booked_Status { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal Worker_Order_Booked_Price { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Service_FID { get; set; }

        [Key]
        [Column(Order = 5)]
        public int Customer_FID { get; set; }

        public virtual Table_Customer Table_Customer { get; set; }

        public virtual Table_Service Table_Service { get; set; }
    }
}
