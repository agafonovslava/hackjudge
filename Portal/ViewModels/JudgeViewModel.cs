﻿using System.Collections.Generic;
using Portal.Models;

namespace Portal.ViewModels
{
    public class JudgeViewModel
    {
        public IEnumerable<Judge> Judges { get; set; }

        public IEnumerable<Opinion> Opinions { get; set; }
    }
}