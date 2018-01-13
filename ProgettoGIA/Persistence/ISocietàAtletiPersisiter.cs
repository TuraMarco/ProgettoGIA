﻿using ProgettoGIA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGIA.Persistence
{
    public interface ISocietàAtletiPersisiter
    {
        ISocietàAtletiLoader getLoader();
        void SaveSocietà(List<Società> s);
        void SaveAtleti(List<Atleta> a);
    }

    public interface ISocietàAtletiLoader
    {
        List<Società> LoadSocietà();
        List<Atleta> LoadAtleti();
    }
}
