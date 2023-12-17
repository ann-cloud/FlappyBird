namespace DefaultNamespace
{
    public class Proxy : ILogic
    {
        private readonly LogicScript _realLogic;

        public Proxy(LogicScript realLogic)
        {
            _realLogic = realLogic;
        }

        public bool checkState()
        {
            return BirdScript.Singleton.gameObject.transform.position.y > 17 ||
                   BirdScript.Singleton.gameObject.transform.position.y < -17;
        }

        public void gameOver()
        {
            if (checkState())
            {
                _realLogic.gameOver();
                BirdScript.Singleton.birdIsAlive = false;
            }
        }
    }
}