using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.Projeto.AutoMapper.Service.Model
{
    public class Issue
    {
        public string ID { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Project { get; set; } 
        public string Status { get; set; }
    }
}
