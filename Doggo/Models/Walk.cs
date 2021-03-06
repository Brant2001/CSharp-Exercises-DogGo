﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doggo.Models
{
    public class Walk
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public Owner owner { get; set; }
        public int WalkerId { get; set; }
        public Walker walker { get; set; }
        public int DogId { get; set; }
    }
}
