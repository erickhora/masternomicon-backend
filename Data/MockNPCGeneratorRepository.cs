using MasternomiconBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasternomiconBackend.Data
{
    public class MockNPCGeneratorRepository : INPCGeneratorRepository
    {
        //TODO: DeleteNPCById in v1 is admin access only.
        public NPC DeleteNPCById(int id)
        {
            throw new NotImplementedException();
        }

        public NPC GetNPCById(int id)
        {
            throw new NotImplementedException();
        }

        //TODO: GetNPCs in v1 is admin access only.
        public IEnumerable<NPC> GetNPCs()
        {
            throw new NotImplementedException();
        }

        //TODO: InsertNPC in v1 is admin access only.
        public NPC InsertNPC()
        {
            throw new NotImplementedException();
        }
    }
}
