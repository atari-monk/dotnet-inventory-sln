using CLIFramework;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class CategoryReadCommand 
    : ReadCommand<Category>
{
    public CategoryReadCommand(
        TextCommand textCommand
        , IReadCommand<Category> readCommand)
            : base(textCommand, readCommand)
    {
    }
}