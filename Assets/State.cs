using UnityEngine;

namespace DefaultNamespace
{
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            _context = context;
        }

        public abstract GameObject Handle();
    }
}