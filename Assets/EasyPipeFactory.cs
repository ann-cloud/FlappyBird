using UnityEngine;

namespace DefaultNamespace
{
    public class EasyPipeFactory : PipeAbstractFactory
    {
        public override GameObject CreatePipe()
        {
             var easyPipePrefab = Resources.Load<GameObject>("EasyPipe");
             return easyPipePrefab;
        }
    }
}