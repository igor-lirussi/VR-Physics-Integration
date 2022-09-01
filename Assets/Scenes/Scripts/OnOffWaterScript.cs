using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NVIDIA.Flex;

public class OnOffWaterScript : MonoBehaviour
{
    public bool waterOn;
    public GameObject sourceActor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) 
    {
        Debug.Log($"********* Collision started with {collision.gameObject.tag}"); 
        sourceActor.GetComponent<FlexSourceActor>().isActive=waterOn;

    }
}
