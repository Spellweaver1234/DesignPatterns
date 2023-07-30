using BuilderDesignPattern;

List<Employe> employees = new()
{
    new Employe { Name = "Ivan", Salary = 100 },
    new Employe { Name = "Boris", Salary = 50 },
    new Employe { Name = "Fedor", Salary = 200 }
};

// отдаём строителю отчетов список работников
var builder = new EmployeeReportBuilder(employees);

// отдаём директору строитель отчётов
var director = new EmployeeReportDirector(builder);

// строим обычный отчет
director.Build();
var report = builder.GetReport();
Console.WriteLine(report);

// строим отчет без заголовка
director.BuildWithNoHeader();
report = builder.GetReport();
Console.WriteLine(report);

// строим отчет без концовки
director.BuildWithNoFooter();
report = builder.GetReport();
Console.WriteLine(report);

Console.ReadKey();


// Строитель - порождающий шаблон проектирования которй делает создание объектов максимально удобным и гибким 