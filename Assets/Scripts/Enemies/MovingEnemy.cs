using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovingEnemy : BaseEnemy
{
    public const float DetectionRange = 1.6f;
    public const float DetectionRangeSq = DetectionRange * DetectionRange;

    // Set this from Enemy Spawner
    public GameObject EnemyPlayer;

    private void Update()
    {
        if(PlayerWithinDetectionRange())
        {

        }
    }

    bool PlayerWithinDetectionRange()
    {
        if (!EnemyPlayer)
        {
            Debug.Log("MovingEnemy: WithinDetectionRange: EnemyPlayer is not set");
            return false;
        }

        float DistSq = (EnemyPlayer.transform.position - transform.position).sqrMagnitude;
        bool bIsWithinDetectionRange = DistSq < DetectionRangeSq;

        if(Constants.DRAW_AI_DEBUG)
        {
            Debug.DrawLine(transform.position, EnemyPlayer.transform.position, (bIsWithinDetectionRange ? Color.green : Color.red), Time.deltaTime, false);
        }

        return bIsWithinDetectionRange;
    }
}
