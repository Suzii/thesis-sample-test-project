namespace WebApp
{
    public class CmsApiGuidelines
    {
        public void WhereLikeMethod()
        {
            // usages raising diagnostic 
            var whereCondition = new CMS.DataEngine.WhereCondition();
            var yesWhereConditionA = whereCondition.WhereLike("columnName", "value");
            var noWhereConditionA = whereCondition.WhereNotLike("columnName", "value");
        
            var yesWhereCondition = new CMS.DataEngine.WhereCondition().WhereLike("columnName", "value");
            var noWhereCondition1 = new CMS.DataEngine.WhereCondition().WhereNotLike("columnName", "value");
            var noWhereCondition2 = new CMS.DataEngine.WhereCondition()?.WhereNotLike("columnName", "value");
        }

        public void EventLogArguments()
        {
            // allowed usages
            CMS.EventLog.EventLogProvider.LogEvent("S", "source", "eventCode", "eventDescription");
            CMS.EventLog.EventLogProvider.LogEvent(CMS.EventLog.EventType.ERROR, "source", "eventCode", "eventDescription");
            CMS.EventLog.EventLogProvider.LogEvent(CMS.EventLog.EventType.INFORMATION, "source", "eventCode", "eventDescription");
            CMS.EventLog.EventLogProvider.LogEvent(CMS.EventLog.EventType.WARNING, "source", "eventCode", "eventDescription");
            
            // usages raising diagnostic 
            CMS.EventLog.EventLogProvider.LogEvent("I", "source", "eventCode", "eventDescription");
            CMS.EventLog.EventLogProvider.LogEvent("E", "source", "eventCode", "eventDescription");
            CMS.EventLog.EventLogProvider.LogEvent("E", "source", "eventCode", "eventDescription");
            CMS.EventLog.EventLogProvider.LogEvent("W", "source", "eventCode", "eventDescription");
            CMS.EventLog.EventLogProvider.LogEvent("W", "source", "eventCode", "eventDescription");
        }

        public void ValidationHelperGet()
        {
            // see CMSWebParts/ValidationHelperGet.cs
        }

        public void ConnectionHelperExecuteQuery()
        {
            // see ConnectionHelperExecuteQuery.aspx.cs
        }
    }
}