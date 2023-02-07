using Config.Wrapper;
using DIHelper;
using Serilog.Wrapper;
using Unity;

namespace Inventory.Modern.ConsoleApp;

public class InventoryBootstraper
    : IBootstraper
{
    private IDependencySuite? suite;
    private IBootstraper? booter;

    public IDependencySuite? Suite => suite;
    public Guid AppId { get; private set; }

    public void CreateApp()
    {
        var unity = new UnityContainer()
            .AddExtension(new Diagnostic());
        var suites = new List<IDependencySuite>
        {
            new ConfigSuite(unity)
            , new SerilogSuite(unity)
        }; 
        suites.ForEach(s => s.Register());
        suite = new SuiteConfig(
            unity.Resolve<IConfigReader>())
                .GetSuite(unity);
        booter = new Bootstraper(suite);
        booter.CreateApp();
        AppId = Guid.NewGuid();
    }

    public void RunApp(params string[] args)
    {  
        ArgumentNullException.ThrowIfNull(booter);
        booter.RunApp(args);
    }
}