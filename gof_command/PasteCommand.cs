namespace gof_command
{
    public class PasteCommand : ICommand
    {
        private readonly Document _document;

        public PasteCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Paste();
        }
    }
}
