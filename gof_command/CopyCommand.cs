namespace gof_command
{
    public class CopyCommand : ICommand
    {
        private readonly Document _document;

        public CopyCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Copy();
        }
    }
}
