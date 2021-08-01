namespace gof_visitor
{
    interface IPlanet
    {
        public void Accept(IExplorer explorer);
    }
}
