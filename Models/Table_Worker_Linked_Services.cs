namespace E_WORKERS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Worker_Linked_Services
    {
        [Key]
        public int Worker_Linked_ServiceID { get; set; }

        public int Worker_FID { get; set; }

        public int Service_FID { get; set; }

        public virtual Table_Service Table_Service { get; set; }

        public virtual Table_Worker Table_Worker { get; set; }
    }
}
