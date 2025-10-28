using UnityEditor.AI;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

// The ": MonoBehaviour" after the class name is what makes it useable as a Component.
public class DeerW5 : MonoBehaviour
{
    // This is a member variable.
    // The "[SerializeField] private" is what makes this variable tunable from
    //      the Inspector.
    // "Transform" defines the type of this variable - it's a Transform, the
    //      Component that stores each GameObject's position, rotation, and scale.
    [SerializeField] private Transform _destination;
    [SerializeField] private NavMeshAgent agent;

    // ------------------------------------------------------------------------
    // The Start method is called when the game begins.
    private void Start()
    {
        // This is how we use GetComponent to get the NavMeshAgent Component
        //      on this GameObject, and store it in a variable named "agent".
        agent = this.GetComponent<NavMeshAgent>();
        // This is how we use the NavMeshAgent to tell the GameObject where to
        //      move towards.
        // Notice how we get the "position" variable of _destination;
        //      that's because _destination is a Transform, which contains 3
        //      variables: position, rotation, and scale.
    }
    void Update()
    {
        agent.SetDestination(_destination.position);

    }
}