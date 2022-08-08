
namespace DAO_layer
{
    public class patientDAO
    {
        public int userId { get; set; }
        public int patientId { get; set; }
        public string dob { get; set; }
        public string note { get; set; }

        public patientDAO()
        {
        }

        public patientDAO(int userId, int patientId, string dob, string note)
        {
            this.userId = userId;
            this.patientId = patientId;
            this.dob = dob;
            this.note = note;
        }
    }
}
