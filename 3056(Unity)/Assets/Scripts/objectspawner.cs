using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UIElements;

public class objectspawner : MonoBehaviour
{
    [SerializeField] GameObject[] Spawn;
    [SerializeField] Vector3 spawnValues;
    [SerializeField] float spawnWait;
    [SerializeField] float startWait;

    int randobj;


    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            randobj = Random.Range(0, Spawn.Length);
            Vector3 spawnposition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z);
            Instantiate(Spawn[randobj], spawnposition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            //Instantiate(Spawn[randobj], spawnposition + transform.TransformPoint(0, 0, 0), Quaternion.identity);

            yield return new WaitForSeconds(spawnWait);
        }
    }

}
