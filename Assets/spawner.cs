using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public int spawnRate;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("ZombieSpawn", spawnRate,spawnRate); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ZombieSpawn()
    {
        float randX = Random.Range(-3f,3f);
        float randZ = Random.Range(-3f,3f);
        Vector3 pos = transform.position;
        Instantiate(zombiePrefab,new Vector3(pos.x + randX, pos.y, pos.z + randZ), Quaternion.identity);

    }   


}
