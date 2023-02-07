using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ImageInsertCommand 
    : InsertCommand<Image>
{
    public ImageInsertCommand(
        TextCommand textCommand
        , IInsertWizard<Image> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}