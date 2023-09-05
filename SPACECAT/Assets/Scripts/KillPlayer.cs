using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject Restart;
    public static bool killPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        killPlayer = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {  
        if (other.gameObject.tag == "Enemy")
        {
            killPlayer = true;
            Restart.SetActive(true); 
        }
    }
}
