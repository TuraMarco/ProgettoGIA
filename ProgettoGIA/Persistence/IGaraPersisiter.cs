﻿using ProgettoGIA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGIA.Persistence
{
    interface IGaraPersisiter
    {
        void SaveGara(List<SpecialitàGara> sg);
    }
}
