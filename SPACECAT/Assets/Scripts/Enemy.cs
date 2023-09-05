using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] 
    public float speed; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!KillPlayer.killPlayer)
        {
            if (transform.position.y < -7f)
            {
                Destroy(gameObject);
            }

            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
    }
}
