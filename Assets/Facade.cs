using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Facade 
    {
        private readonly LogicScript _logic;
        public Facade(LogicScript logic)
        {
            _logic = logic;
        }

        public void Operation()
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new ComplexCommand(_logic, 1));
            invoker.AddScoreOnMoveThrough();
            //_logic.addScore(1);
            if (CrossScene.counter % 5 == 0)
            {
                _logic.changeCharacter();
            }
        }
    }
}