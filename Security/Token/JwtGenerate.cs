namespace SterenTicketsBE.Security.token
{
    public interface JwtGenerateInterface
    {
        string CreateToken(int prmNumUserId, string prmVarUserEmail, string prmVarFullName);
    }
}