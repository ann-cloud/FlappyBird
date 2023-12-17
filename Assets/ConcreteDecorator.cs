using UnityEngine;

namespace DefaultNamespace
{
    public class ConcreteDecorator : BaseDecorator
    {
        public ConcreteDecorator(IEasyMode moderateMode) : base(moderateMode)
        {
            
        }

        public new void load()
        {
            base.load();
            extra();
        }

        public void extra()
        {
            CrossScene.GameMode = "Moderate";
            CrossScene.counter = 0;
        }
    }
}