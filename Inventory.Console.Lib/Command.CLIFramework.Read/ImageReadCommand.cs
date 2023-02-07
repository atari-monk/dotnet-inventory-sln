using CLIFramework;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ImageReadCommand 
    : ReadCommand<Image>
{
    public ImageReadCommand(
        TextCommand textCommand
        , IReadCommand<Image> readCommand)
            : base(textCommand, readCommand)
    {
    }
}