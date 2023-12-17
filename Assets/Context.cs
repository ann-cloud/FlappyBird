using UnityEngine;

namespace DefaultNamespace
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public GameObject Request()
        {
            return _state.Handle();
        }
    }
}