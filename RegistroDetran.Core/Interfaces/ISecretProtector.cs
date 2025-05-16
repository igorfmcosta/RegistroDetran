namespace RegistroDetran.Core.Interfaces
{
    public interface ISecretProtector
    {
        string Protect(string input);
        string Unprotect(string input);
    }
}
