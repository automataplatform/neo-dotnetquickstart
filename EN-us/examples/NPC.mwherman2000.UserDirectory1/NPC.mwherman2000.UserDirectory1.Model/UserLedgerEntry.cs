﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC.mwherman2000.UserDirectory1.Model
{
    public interface NPCLevel0Basic { }
    public interface NPCLevel1Managed { }
    public interface NPCLevel2Persistable { }
    public interface NPCLevel3Deletable { }
    public interface NPCLevel4Collectible { }
    public interface NPCLevel4CollectibleExt { }

    public interface NPCLevel0CustomMethods { }
    public interface NPCLevel11CustomMethods { }
    public interface NPCLevel2CustomMethods { }
    public interface NPCLevel3CustomMethods { }
    public interface NPCLevel4CustomMethods { }

    public partial class UserLedgerEntry: NPCLevel0Basic,
                                        NPCLevel1Managed,
                                        NPCLevel2Persistable,
                                        NPCLevel3Deletable,
                                        NPCLevel4Collectible,
                                        NPCLevel4CollectibleExt
    {
        byte[] userScriptHash;
        byte[] passphraseScriptHash;
    }
}
