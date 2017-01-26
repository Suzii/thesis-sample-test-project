namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class WhereLikeMethod : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(WhereLikeMethod);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 4;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var whereCondition = new CMS.DataEngine.WhereCondition();
            var yesWhereCondition = whereCondition.WhereLike(""columnName"", ""value"");
            var noWhereCondition = whereCondition.WhereNotLike(""columnName"", ""value"");
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var yesWhereCondition = new CMS.DataEngine.WhereCondition().WhereLike(""columnName"", ""value"");
            var noWhereCondition = new CMS.DataEngine.WhereCondition().WhereNotLike(""columnName"", ""value"");
        }}";
        }
    }
}