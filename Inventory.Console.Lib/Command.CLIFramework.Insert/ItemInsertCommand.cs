using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemInsertCommand 
    : InsertCommand<Item>
{
    public ItemInsertCommand(
        TextCommand textCommand
        , IInsertWizard<Item> modelAInsertWizard) 
            : base(textCommand, modelAInsertWizard)
    {
    }
}