using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Exam.Dto
{
    public class CreateMusicDto
    {
        
        public string Name { get; set; }
        public double MB { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public int Quentitylikes { get; set; }
    }
}
