using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEnemy
{
    public abstract class Player    //注意关键字abstract
    {
        List<IObserver> observers = new List<IObserver>();//观察员列表
        protected virtual void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
        public virtual void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public virtual void Delete(IObserver observer)
        {
            observers.Remove(observer);
        }
        public abstract string Display();
    }

    //public class Player1 : Player
    //{

    //}
}
