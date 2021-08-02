using System;

namespace gof_command
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            ICommand copyCommand = new CopyCommand(document);
            ICommand pasteCommand = new PasteCommand(document);

            MenuOptions menuOptions = new MenuOptions(copyCommand, pasteCommand);

            menuOptions.OnCopy();
            menuOptions.OnPaste();

            Console.ReadKey();

        }
    }
}
