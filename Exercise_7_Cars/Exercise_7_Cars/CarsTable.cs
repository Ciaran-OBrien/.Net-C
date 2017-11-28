namespace Exercise_7_Cars
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarsTable")]
    public partial class CarsTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string brand { get; set; }

        [StringLength(255)]
        public string model { get; set; }

        [StringLength(255)]
        public string color { get; set; }

        public int? year { get; set; }

        public int? id_owner { get; set; }
    }
}
