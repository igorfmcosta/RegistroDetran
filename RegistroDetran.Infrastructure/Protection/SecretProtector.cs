using Microsoft.AspNetCore.DataProtection;
using RegistroDetran.Core.Interfaces;

namespace RegistroDetran.Infrastructure.Protection
{
    public class SecretProtector : ISecretProtector
    {
        private readonly IDataProtector _protector;

        public SecretProtector(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("5m4r7pr073c70r");
        }

        public string Protect(string input)
        {
            return _protector.Protect(input);
        }

        public string Unprotect(string input)
        {
            try
            {
                return _protector.Unprotect(input);
            }
            catch
            {
                Console.WriteLine("Failed to unprotect secret");
                throw;
            }
        }
    }
}
