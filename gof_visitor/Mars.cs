namespace gof_visitor
{
    public class Mars : IPlanet
    {
        public void Accept(IExplorer explorer)
        {
            explorer.Visit(this);

        }
    }
}
