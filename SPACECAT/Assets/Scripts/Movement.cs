using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform character;
    public float speed; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        if (!KillPlayer.killPlayer)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x <-1.9f? -1.9f: mousePos.x;
            mousePos.x = mousePos.x> 1.8f? 1.8f: mousePos.x;
            character.position = Vector2.MoveTowards(character.position, new Vector2(mousePos.x, character.position.y),speed*Time.deltaTime);
        }
    }
}
