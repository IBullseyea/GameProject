using UnityEngine;

public class StateMachine : MonoBehaviour
{
   
   public baseState activeState; 
   public PatrolState patrolState; 
    public void Initialise()
    {
        patrolState = new PatrolState(); 
        changeState(patrolState);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activeState != null)
        {
            activeState.Perform(); // Call the Perform method of the active state
        }
    }
    public void changeState(baseState newState)
    {
       if (activeState != null)
       {
          activeState.Exit(); // Exit the current state
       }
       activeState = newState; // Set the new state as the active state

       if(activeState != null)
       {
          activeState.stateMachine = this;
          activeState.enemy = GetComponent<Enemy>(); 
          activeState.Enter(); 
       }
    }
}
