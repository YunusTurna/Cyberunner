using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thorn : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private Transform _targetWaypoint;
    private int _currentWaypointIndex = 0;
    [SerializeField] private float _checkDistance = 0.05f;

    void Start()
    {
        _targetWaypoint = _waypoints[0];

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = (Vector3)Vector2.MoveTowards(

            current: (Vector2)transform.position,
            (Vector2)_targetWaypoint.position,
            maxDistanceDelta: _speed * Time.deltaTime

      );
       
       
        if (Vector2.Distance(a: transform.position, b: _targetWaypoint.transform.position) < _checkDistance)
        {

            _targetWaypoint = GetNextWaypoint();
        }
      

    }


    private Transform GetNextWaypoint()
    {
        _currentWaypointIndex++;
        if (_currentWaypointIndex >= _waypoints.Length)
        {
            
            _currentWaypointIndex = 0;
        }

        return _waypoints[_currentWaypointIndex];
    }


}
