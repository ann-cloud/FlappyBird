namespace DefaultNamespace
{
    public class Client
    {
        private ILogic _logic;

        public Client(ILogic logic)
        {
            _logic = logic;
        }

        public void gameOver()
        {
            _logic.gameOver();
        }
    }
}