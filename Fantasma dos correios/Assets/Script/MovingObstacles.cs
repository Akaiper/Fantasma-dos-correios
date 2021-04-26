using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _playerStats.Letters--;
    }
}
