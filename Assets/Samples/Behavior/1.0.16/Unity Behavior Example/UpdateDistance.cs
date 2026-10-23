using UnityEngine;
using Unity.Behavior;

public class UpdateDistance : MonoBehaviour
{
    private BehaviorGraphAgent agent;
    public Transform playerTransform;

    void Start()
    {
        agent = GetComponent<BehaviorGraphAgent>();
    }

    void Update()
    {
        if (playerTransform != null && agent != null)
        {
            // Calculates the 3D distance between Rabbit and Player
            float distance = Vector3.Distance(transform.position, playerTransform.position);
            
            // Updates the Blackboard variable so the graph can read it
            agent.SetVariableValue("DistanceToPlayer", distance);
        }
    }
}