using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x <= 10)
        {
            transform.position = new Vector3(0, 0, -10);
        }
        else if(player.transform.position.x >= 10 && player.transform.position.x <= 30)
        {
            transform.position = new Vector3(20, 0, -10);
        }
        else if (player.transform.position.x >= 30 && player.transform.position.x <= 50)
        {
            transform.position = new Vector3(40, 0, -10);
        }
    }
}
