using UnityEngine;
using UnityEngine.AI;
public class CrabMovement : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent Enemy;
    void Update()
    {
        Enemy.SetDestination(Player.position);
    }
}
