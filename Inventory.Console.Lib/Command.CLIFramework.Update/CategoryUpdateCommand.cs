using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class CategoryUpdateCommand 
    : UpdateCommand<Category>
{
    public CategoryUpdateCommand(
        TextCommand textCommand
        , IUpdateWizard<Category> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}