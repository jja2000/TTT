using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTT.Models.Classes
{
    public class File
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string Uploaddate { get; set; }
        public string Location { get; set; }

        public File(int id, string filename, string uploaddate, string location)
        {
            this.Id = id;
            this.Filename = filename;
            this.Uploaddate = uploaddate;
            this.Location = location;

        }
    }
}
