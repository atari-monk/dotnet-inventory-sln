using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Console.Lib;

public class ItemReadCmd 
    : ReadCommand<IInventoryUnitOfWork, Item, Item>
{
    public ItemReadCmd(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Item> textProvider) 
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Item> Get(Item model) =>
        UnitOfWork.Item.Get(
            includeProperties: "ItemCategory"
        ).ToList();
}