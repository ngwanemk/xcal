﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xcal.domain.contracts.core.values;

namespace xcal.domain.contracts.core.parameters
{
    public interface ISENT_BY
    {
        ICAL_ADDRESS Address { get; set; }
    }
}
