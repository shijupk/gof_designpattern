namespace gof_visitor
{
    public class Saturn : IPlanet
    {
        public void Accept(IExplorer explorer)
        {
            explorer.Visit(this);

        }
    }
}
