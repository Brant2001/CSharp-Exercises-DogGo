using System.Collections.Generic;

namespace Doggo.Models.ViewModels
{
    public class WalkerProfileViewModel
    {
        public Walker walker { get; set; }
        public List<Walk> walks { get; set; }
        public int TotalDurationOfWalks { get; set; }
    }
}
