namespace RW.Scripts
{
    public class StateMashine2
    {
        public State2 currentState;

        public void Initialize(State2 startingState)
        {
            currentState = startingState;
            currentState.Enter();
        }
        public void ChangeState(State2 newState)
        {
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}