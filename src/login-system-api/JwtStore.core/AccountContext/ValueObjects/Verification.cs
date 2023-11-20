using JwtStore.core.SharedContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtStore.core.AccountContext.ValueObjects
{
    public class Verification : ValueObject
    {
        public string Code { get; } = Guid.NewGuid().ToString("N")[0..6].ToUpper();
        public DateTime? ExpireAt { get; private set; } = DateTime.UtcNow;
        public DateTime? VerifiedAt { get; private set; } = null;
        public bool IsActive => VerifiedAt != null && ExpireAt == null;
        

        public void Verify (string code)
        {
            if (IsActive)
                throw new Exception("Este item já foi ativado");

            if (ExpireAt < DateTime.UtcNow)
                throw new Exception("Este codigo já foi ativado");

            if (!string.Equals(code.Trim(), code.Trim(), StringComparison.CurrentCultureIgnoreCase))
                throw new Exception("Codigo de verificação invalido");

            ExpireAt = null;
            VerifiedAt = DateTime.UtcNow;

        }
    }
}
