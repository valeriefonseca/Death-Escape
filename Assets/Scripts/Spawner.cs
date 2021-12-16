using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() //This will help with disabling the spawner for example when the player loses
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject Pencils = Instantiate(prefab, transform.position, Quaternion.identity); //Creates a new object by cloning the pencil prefab and getting a new set
        Pencils.transform.position += Vector3.up * Random.Range(minHeight, maxHeight); //Adjusts the postion of the pencils either up or down based on a random variable 
    }

}
