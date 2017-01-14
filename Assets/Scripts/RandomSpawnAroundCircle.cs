using UnityEngine;
using System.Collections;

public class RandomSpawnAroundCircle : MonoBehaviour
{

    public GameObject spawnObject;
    public float radius = 50.0f;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 1.0f;


    void Start()
    {
        Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
    }

    void SpawnNow()
    {
        Vector3 center = transform.position;
        Vector3 pos = RandomCircle(center, radius);
        Quaternion rot = Quaternion.FromToRotation(Vector3.down, center - pos);
        Instantiate(spawnObject, pos, rot);


        Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }


}



