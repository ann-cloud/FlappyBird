using UnityEngine;

namespace DefaultNamespace
{
    public interface Prototype
    {
        public GameObject Clone(Vector3 position);
    }
}