using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Console.Lib;

public class ImageReadCmd 
    : ReadCommand<IInventoryUnitOfWork, Image, Image>
{
    public ImageReadCmd(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Image> textProvider) 
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<Image> Get(Image model) =>
        UnitOfWork.Image.Get().ToList();
}