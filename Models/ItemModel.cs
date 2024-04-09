using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocEducativ.Models
{
    public class ItemModel
    {
        public string Enunt {  get; set; }
        public string Raspuns1 { get; set; }
        public string Raspuns2 { get; set; }
        public string Raspuns3 { get; set; }
        public int RaspunsCorect { get; set; }
        public int Punctaj {  get; set; }
    }
}
