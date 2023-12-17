using UnityEngine;

namespace DefaultNamespace
{
    public class ModerateMode: MonoBehaviour
    {
        public void load()
        {
            var mode = new EasyMode();
            ConcreteDecorator moderate = new ConcreteDecorator(mode);
            moderate.load();
        }
    }
}