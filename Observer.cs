using System.Collections;
using System.Collections.Generic;

namespace DP
{
    public interface IObserver
    {
        void Nortify();
    }

    public class Observable
    {
        List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void Nortify()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Nortify();
            }
        }
    }
}
