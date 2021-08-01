
namespace gof_visitor
{
    public interface IExplorer
    {
        public void Visit(Mercury mercury);
        public void Visit(Mars mars);
        public void Visit(Saturn saturn);

    }
}
