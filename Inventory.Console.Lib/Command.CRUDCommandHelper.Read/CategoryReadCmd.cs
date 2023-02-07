using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Console.Lib;

public class CategoryReadCmd 
    : ReadCommand<IInventoryUnitOfWork, Category, Category>
{
    public CategoryReadCmd(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Category> textProvider) 
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Category> Get(Category model) =>
        UnitOfWork.Category.Get().ToList();
}