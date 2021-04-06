using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment10.Models.ViewModels
{
    //This is the viewmodel to help with the pagination
    public class IndexViewModel
    {
        public List<Bowlers> Bowlers { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string TeamName { get; set; }
    }
}
