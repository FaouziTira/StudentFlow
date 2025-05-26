
namespace WebApplication44.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class batch
    {
        public batch()
        {
            this.registations = new HashSet<registation>();
        }
    
        public int id { get; set; }
        public string batch1 { get; set; }
        public string year { get; set; }
    
        public virtual ICollection<registation> registations { get; set; }
    }
}
