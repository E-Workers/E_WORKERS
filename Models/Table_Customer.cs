namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Customer()
        {
            Table_Feedback = new HashSet<Table_Feedback>();
            Table_Order = new HashSet<Table_Order>();
            Table_Worker_Order_Booked = new HashSet<Table_Worker_Order_Booked>();
        }

        [Key]
        public int Customer_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Password { get; set; }

        public int City_FID { get; set; }

        public virtual Table_City Table_City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Feedback> Table_Feedback { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Order> Table_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Worker_Order_Booked> Table_Worker_Order_Booked { get; set; }
    }
}
