namespace DefaultNamespace
{
    public class ComplexCommand : ICommand
    {
        private LogicScript _logic;
        private int _toAdd;

        public ComplexCommand(LogicScript logic, int toAdd)
        {
            _logic = logic;
            _toAdd = toAdd;
        }
        public void Execute()
        {
            _logic.addScore(_toAdd);
        }
    }
}