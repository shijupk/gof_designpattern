namespace gof_observer
{
    public interface IObservable
    {
        /// <summary>
        /// register with with observer
        /// </summary>
        /// <param name="observer"></param>
        void Subscribe(IObserver observer);
        /// <summary>
        /// un register with observer
        /// </summary>
        /// <param name="observer"></param>
        void Unsubscribe(IObserver observer);

        /// <summary>
        /// Notiy all observers
        /// </summary>
        void Notify(INews message);

    }
}
