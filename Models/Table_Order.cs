namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Order()
        {
            Table_OrderDetails = new HashSet<Table_OrderDetails>();
        }

        [Key]
        public int Order_ID { get; set; }

        public DateTime Order_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Order_Status { get; set; }

        [Required]
        [StringLength(50)]
        public string Payment_Mode { get; set; }

        public int Worker_FID { get; set; }

        public int Customer_FID { get; set; }

        public virtual Table_Customer Table_Customer { get; set; }

        public virtual Table_Worker Table_Worker { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_OrderDetails> Table_OrderDetails { get; set; }
    }
}
