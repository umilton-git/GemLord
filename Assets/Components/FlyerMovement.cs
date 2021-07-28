using UnityEngine;
using UnityEngine.AI;
public class FlyerMovement : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent Flyer;
    void Update()
    {
        Flyer.SetDestination(Player.position);
        transform.LookAt(Player);
    }
}
