using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_
{
    public class patientDAO
    {
        public int userId { get; set; }
        public string patientId { get; set; }
        public string dob { get; set; }
        public string note { get; set; }

        public patientDAO()
        {
        }

        public patientDAO(int userId, string patientId, string dob, string note)
        {
            this.userId = userId;
            this.patientId = patientId;
            this.dob = dob;
            this.note = note;
        }
    }
}
