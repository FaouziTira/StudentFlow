
namespace WebApplication44.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class course
    {
        public course()
        {
            this.registations = new HashSet<registation>();
        }
    
        public int id { get; set; }
        public string course1 { get; set; }
        public Nullable<int> duration { get; set; }
    
        public virtual ICollection<registation> registations { get; set; }
    }
}
