namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Order_Assign
    {
        [Key]
        [Column(Order = 0)]
        public int Worker_Order_BookedFID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Worker_FID { get; set; }

        public virtual Table_Worker Table_Worker { get; set; }
    }
}
