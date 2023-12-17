using UnityEngine;

namespace DefaultNamespace
{
    public class EasyPipeStateA : State
    {
        public override GameObject Handle()
        {
            return Resources.Load<GameObject>("EasyLater");
        }
    }
}