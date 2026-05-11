using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker.Forms.Subject
{
    public class SubjectItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
