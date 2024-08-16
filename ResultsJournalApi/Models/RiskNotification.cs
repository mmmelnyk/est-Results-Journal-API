namespace ResultsJournalApi.Models
{
    public class RiskNotification
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string InfectionName { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime SendDate { get; set; }
        public int ReporterId { get; set; }
    }
}