using UnityEngine;
using UnityEngine.Events;

namespace Commons
{
    public class GameEventListenerFloat : MonoBehaviour
    {
        [SerializeField] private GameEventFloat gameEvent;
        [SerializeField] private UnityEvent<float> response;

        private void OnEnable() => gameEvent.Register(this);

        private void OnDisable() => gameEvent.Unregister(this);

        public void OnEventRaised(float item) => response.Invoke(item);
    }
}