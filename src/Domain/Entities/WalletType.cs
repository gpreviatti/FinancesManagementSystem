﻿using System.Collections.Generic;

namespace Domain.Entities
{
    public class WalletType : Entity
    {
        public string Name { get; set; }

        public IEnumerable<Wallet> Wallets { get; set; }
    }
}
