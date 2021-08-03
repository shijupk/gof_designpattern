namespace gof_observer
{
    public interface IObserver
    {
        string Name { get; set; }
        /// <summary>
        /// Recieve updates from observables
        /// </summary>
        void Update(INews message);
    }
}
