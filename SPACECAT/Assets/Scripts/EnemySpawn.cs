using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (!KillPlayer.killPlayer)
        {
            Instantiate(Enemy, new Vector2(Random.Range(-1.9f, 1.8f), 7f), Quaternion.identity);
            yield return new WaitForSeconds(2f); 
        }
    }
}