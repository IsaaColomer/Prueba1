using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject pipeSpawner;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(maxTime < 0)
        {
            Instantiate(pipePrefab, pipeSpawner.transform.position, Quaternion.identity);
            maxTime = 5f;
        }
        else
        {
            maxTime -= Time.deltaTime;
        }
    }
}
