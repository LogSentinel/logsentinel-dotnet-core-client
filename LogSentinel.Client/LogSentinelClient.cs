using IO.Swagger.Api;

namespace LogSentinel.Client
{
    public class LogSentinelClient
    {
        private AuditLogControllerApi auditLogActions;
        private HashControllerApi hashActions;

        public LogSentinelClient(AuditLogControllerApi auditLogActions, HashControllerApi hashActions)
        {
            this.auditLogActions = auditLogActions;
            this.hashActions = hashActions;
        }

        public AuditLogControllerApi getAuditLogActions()
        {
            return auditLogActions;
        }

        public HashControllerApi getHashActions()
        {
            return hashActions;
        }
    }
}
