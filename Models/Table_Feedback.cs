namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Feedback
    {
        [Key]
        public int Feedback_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Feedback_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Feedback_Rating { get; set; }

        public int Customer_FID { get; set; }

        public virtual Table_Customer Table_Customer { get; set; }
    }
}
