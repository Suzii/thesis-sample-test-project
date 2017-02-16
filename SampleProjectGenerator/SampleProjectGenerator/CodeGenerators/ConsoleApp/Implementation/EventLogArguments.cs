﻿namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class EventLogArguments : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName(int index)
        {
            return $"{nameof(EventLogArguments)}{index}";
        }

        // TODO 
        protected override int NumberOfDiagnosticsInBody { get; } = 3;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethod{iterationNumber}()
        {{
            CMS.EventLog.EventLogProvider.LogEvent(""I"", ""source"", ""eventCode"", ""eventDescription"");
            CMS.EventLog.EventLogProvider.LogEvent(""E"", ""source"", ""eventCode"", ""eventDescription"");
            CMS.EventLog.EventLogProvider.LogEvent(""W"", ""source"", ""eventCode"", ""eventDescription"");
            // CMS.EventLog.EventLogProvider.LogEvent(""S"", ""source"", ""eventCode"", ""eventDescription"");
            // CMS.EventLog.EventLogProvider.LogEvent(CMS.EventLog.EventType.ERROR, ""source"", ""eventCode"", ""eventDescription"");
            // CMS.EventLog.EventLogProvider.LogEvent(CMS.EventLog.EventType.INFORMATION, ""source"", ""eventCode"", ""eventDescription"");
            // CMS.EventLog.EventLogProvider.LogEvent(CMS.EventLog.EventType.WARNING, ""source"", ""eventCode"", ""eventDescription"");
        }}";
        }
    }
}