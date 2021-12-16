using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencils : MonoBehaviour
{
    public float speed = 5f; //Changing the speed can change the games difficulty 
    public float leftEdge; 

    // Start is called before the first frame update
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //Time.deltaTime makes it frame rate independent

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }

    }



}
