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
        public string Email { get; set; }
    }
}
