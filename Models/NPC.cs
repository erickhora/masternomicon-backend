using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasternomiconBackend.Models
{
    public class NPC
    {
        public int Id { get; set; }
        public string Alignment { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Appearance { get; set; }
        public string BestAbility { get; set; }
        public string WorstAbility { get; set; }
        public string Mannerism { get; set; }
        public string WayOfSpeak { get; set; }
        public string Ideal { get; set; }
        public string Network { get; set; }
        public string Talent { get; set; }
        public string FlawOrSecret { get; set; }

    }
}
