using ResultsJournalApi.Models;

namespace ResultsJournalApi.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(User user);
    }
}