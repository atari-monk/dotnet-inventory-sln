using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class CategoryInsertCommand 
    : InsertCommand<Category>
{
    public CategoryInsertCommand(
        TextCommand textCommand
        , IInsertWizard<Category> itemCategoryWizard)
            : base(textCommand, itemCategoryWizard)
    {
    }
}