﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelligent.OTC.Domain
{
    public class UploadLegalHisModel
    {
        public int TotalItems { get; set; }
        public List<UploadLegalHis> List { get; set; }
    }
}
