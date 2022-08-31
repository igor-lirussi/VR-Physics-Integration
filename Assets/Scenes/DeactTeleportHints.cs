using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class DeactTeleportHints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Teleport.instance.CancelTeleportHint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
