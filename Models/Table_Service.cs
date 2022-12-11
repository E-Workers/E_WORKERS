namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Service()
        {
            Table_Categories = new HashSet<Table_Categories>();
            Table_Worker_Linked_Services = new HashSet<Table_Worker_Linked_Services>();
            Table_Worker_Order_Booked = new HashSet<Table_Worker_Order_Booked>();
        }

        [Key]
        public int Service_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Service_Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Service_Charges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Categories> Table_Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Worker_Linked_Services> Table_Worker_Linked_Services { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Worker_Order_Booked> Table_Worker_Order_Booked { get; set; }
    }
}
