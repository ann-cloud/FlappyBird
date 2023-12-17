using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
    public class HardPipeFactory : PipeAbstractFactory
    {
        public override GameObject CreatePipe()
        {
            var hardPipePrefab = Resources.Load<GameObject>("HardPipe");
            return hardPipePrefab;
        }
    }
}