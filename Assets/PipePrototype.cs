using UnityEngine;
namespace DefaultNamespace
{
    public class PipePrototype : Prototype
    {
        private readonly GameObject _pipePrefab;

        public PipePrototype(GameObject prototype)
        {
            _pipePrefab = prototype;
        }
        public GameObject Clone(Vector3 position)
        {
            GameObject clone = _pipePrefab;
            clone.transform.position = position;
            clone.transform.rotation = _pipePrefab.transform.rotation;
            return clone;
        }
    }
}