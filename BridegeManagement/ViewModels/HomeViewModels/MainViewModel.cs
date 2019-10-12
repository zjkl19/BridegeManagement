using BridegeManagement.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.HomeViewModels
{
    public class MainViewModel
    {
        public IEnumerable<CombineViewModel> CombineViewModels { get; set; }
    }
}
