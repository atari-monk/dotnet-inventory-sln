using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ImageUpdateCommand 
	: UpdateCommand<Image>
{
	public ImageUpdateCommand(
		TextCommand command
		, IUpdateWizard<Image> updateWizard)
			: base(command, updateWizard)
	{
	}
}