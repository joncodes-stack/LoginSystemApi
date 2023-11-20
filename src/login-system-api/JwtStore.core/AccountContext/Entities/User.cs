using JwtStore.core.AccountContext.ValueObjects;
using JwtStore.core.SharedContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtStore.core.AccountContext.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public Email Email { get; private set; }
    }
}
