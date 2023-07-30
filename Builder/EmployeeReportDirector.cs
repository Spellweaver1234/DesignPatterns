namespace BuilderDesignPattern
{
    public class EmployeeReportDirector
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeReportDirector(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();
        }

        public void BuildWithNoHeader()
        {
            _builder
                .BuildBody()
                .BuildFooter();
        }

        public void BuildWithNoFooter()
        {
            _builder
                .BuildHeader()
                .BuildBody();
        }
    }
}
