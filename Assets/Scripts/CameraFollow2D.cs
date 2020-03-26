using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Kameran flyttas med spelaren, spelaren är centrerad
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y);
        if (player.transform.position.x > 9)
        {
            transform.position = new Vector3(18, 0, -10);
        }
        else if (player.transform.position.x > 27)
        {
            transform.position = new Vector3(36, 0, -10);
        }
        if (player.transform.position.x < 9)
        {
            transform.position = new Vector3(0, 0, -10);
        }
        else if (player.transform.position.x > 27)
        {
            transform.position = new Vector3(18, 0, -10);
        }
    }
}
