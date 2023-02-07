using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemUpdateCommand 
    : UpdateCommand<Item>
{
    public ItemUpdateCommand(
        TextCommand textCommand
        , IUpdateWizard<Item> updateWizard) 
            : base(textCommand, updateWizard)
    {
    }
}