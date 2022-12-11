namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Worker()
        {
            Table_Order = new HashSet<Table_Order>();
            Table_Order_Assign = new HashSet<Table_Order_Assign>();
            Table_Worker_Linked_Services = new HashSet<Table_Worker_Linked_Services>();
        }

        [Key]
        public int Worker_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Worker_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Worker_Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Worker_Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Worker_Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Worker_Phone { get; set; }

        
        [StringLength(500)]
        public string Worker_Image { get; set; }

        [StringLength(50)]
        public string Worker_Status { get; set; }


        public int City_FID { get; set; }

        public virtual Table_City Table_City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Order> Table_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Order_Assign> Table_Order_Assign { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Worker_Linked_Services> Table_Worker_Linked_Services { get; set; }
    }
}
