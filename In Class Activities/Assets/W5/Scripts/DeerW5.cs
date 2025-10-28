using UnityEditor.AI;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5 : MonoBehaviour
{
    //member variables that will be used: target, movement speed, position

    [SerializeField] private float _movespeed = 1.0f;
    [SerializeField] private Transform _deerPosition;
    [SerializeField] private NavMeshAgent _target;
    private bool _hitTarget;

    //make an updat function 
    void Start()
    {
        NavMeshAgent agent = 
        Vector3 Target = new Vector3(31.533f, 1.05f, 20.966f);
        _target.SetDestination(Target);
    }
    

}