using System;
using System.Collections.Generic;
using MasternomiconBackend.Models;

namespace MasternomiconBackend.Data
{
    interface INPCGeneratorRepository
    { 
        IEnumerable<NPC> GetNPCs();

        NPC GetNPCById(int id);

        NPC DeleteNPCById(int id);

        NPC InsertNPC();
    }
}
