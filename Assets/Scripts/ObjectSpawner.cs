using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Prefab;
    public Transform theDest;

    // Start is called before the first frame update
    public void SpawnObject()
    {
        Instantiate(Prefab, theDest.position, Quaternion.identity);
    }
}
