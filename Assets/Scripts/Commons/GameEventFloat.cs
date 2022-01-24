using System.Collections.Generic;
using UnityEngine;

namespace Commons
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Values/GameEventFloat", fileName = "NewEventFloat")]
    public class GameEventFloat : ScriptableObject
    {
        private readonly List<GameEventListenerFloat> _listeners = new List<GameEventListenerFloat>();

        public void Raise(float item)
        {
            foreach (var gameEventListener in _listeners)
            {
                gameEventListener.OnEventRaised(item);
            }
        }

        public void Register(GameEventListenerFloat listener) => _listeners.Add(listener);
        
        public void Unregister(GameEventListenerFloat listener) => _listeners.Remove(listener);
    }  

}
