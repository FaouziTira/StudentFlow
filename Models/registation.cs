

namespace WebApplication44.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class registation
    {
    
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nic { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<int> batch_id { get; set; }
        public Nullable<int> telno { get; set; }
    
        public virtual batch batch { get; set; }
        public virtual course course { get; set; }
    }
}
