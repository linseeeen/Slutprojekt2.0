using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 3;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float controlX = Input.GetAxisRaw("Horizontal");
        float controlY = Input.GetAxisRaw("Vertical");


        Vector3 movementX = Vector3.right * Time.deltaTime * speed * controlX;
        Vector3 movementY = Vector3.up * Time.deltaTime * speed * controlY;


        transform.Translate(movementX + movementY);
        if (Mathf.Abs(transform.position.x) > 8.5)
        {
            transform.Translate(-movementX);
        }

        if (Mathf.Abs(transform.position.y) > 4.5)
        {
            transform.Translate(-movementY);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int wateringCan = 0;
        int wheelbarrow = 0;
        if (collision.tag == "watering can")
        {
            print("Vattenkanna!!!");
            if (wateringCan == 0)
            {
                wateringCan++;
                wheelbarrow = 0;
                print(wateringCan);
            }
        }
        else if (collision.tag == "wheelbarrow")
        {
            print("skottkärra");
            if (wheelbarrow == 0)
            {
                wheelbarrow++;
                wateringCan = 0;
                print(wheelbarrow);
            }
        }

    }
}

