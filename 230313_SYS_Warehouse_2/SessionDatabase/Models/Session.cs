using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionDatabase.Models
{
    public class Session
    {
        //properties
        public int SessionDato { get; set; }
        public string SessionStatus { get; set; }
        public int SessionVarighed { get; set; }
        public int SessionId { get; set; }

        // Constructor
        public Session(int sessionDato, string sessionStatus, int sessionVarighed, int sessionId)
        {
            this.SessionDato = sessionDato;
            this.SessionStatus = sessionStatus;
            this.SessionVarighed = sessionVarighed;
            this.SessionId = sessionId;

        }
    }
}
