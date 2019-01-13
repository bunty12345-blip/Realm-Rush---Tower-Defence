using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] List<Waypoint> path;
	// Use this for initialization
	void Start () {
        
        StartCoroutine(FollowPath());
        print("I am back at start!");

    }

    IEnumerator FollowPath()
    {
        print("Starting Patrol!");
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            print("Visiting Block : " + waypoint);
            yield return new WaitForSeconds(1f);
        }
        print("Ending Patrol!");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
