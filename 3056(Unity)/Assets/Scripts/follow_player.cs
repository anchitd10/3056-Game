using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    [SerializeField] float Speed;
    void Start()
    {
        
    }


    void Update()
    {
        Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Player.transform.position, Speed);
    }
}
