using UnityEngine;

namespace DefaultNamespace
{
    public class Invoker
    {
        private ICommand _onStart;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void AddScoreOnMoveThrough()
        {
            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }
        }
    }
}