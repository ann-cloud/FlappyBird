using UnityEngine;

namespace DefaultNamespace
{
    public abstract class BaseDecorator : IEasyMode
    {
        private IEasyMode _moderateMode;

        public BaseDecorator(IEasyMode moderateMode)
        {
            _moderateMode = moderateMode;
        }

        public void load()
        {
            _moderateMode.load();
        }
    }
}