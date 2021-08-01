namespace gof_visitor
{
    public class Mercury : IPlanet
    {
        public void Accept(IExplorer explorer)
        {
            explorer.Visit(this);

        }
    }
}
