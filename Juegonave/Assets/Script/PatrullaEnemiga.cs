using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaEnemiga : MonoBehaviour
{
    [SerializeField]
    bool isInPatrol;
    Transform[] waypoints;
    [SerializeField]
    int currentWaypoint = 0;
    [SerializeField]
    float mSpeed;

    void Start()
    {
        
        mSpeed = mSpeed * Time.deltaTime;
    }
    void Update()
    {
       if(isInPatrol)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints(currentWaypoint).position_mSpeed * Time.deltaTime);
            if(transform.position == waypoints(currentWaypoint).position)
            {

                currentWaypoint = (currentWaypoint + 1) % waypoints.Length;

            }
            if (currentWaypoint == waypoints.Length)
            {
                currentWaypoint = 0;
            
            }


        }
        


    }
}
