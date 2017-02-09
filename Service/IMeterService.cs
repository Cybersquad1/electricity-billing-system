﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Service
{
    public interface IMeterService
    {
        IQueryable<Meter> GetMeters();
        MeterService GetMeter(string id);
    }
}
