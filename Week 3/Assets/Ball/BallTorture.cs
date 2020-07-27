using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTorture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        GameObject[] pegList = GameObject.FindGameObjectsWithTag("peg");
        foreach(GameObject peg in pegList)
        {
            PeggingScript pegScript = peg.GetComponent<PeggingScript>();
            if(pegScript.markedForDeath)
            {
                pegScript.timer = 0.5f;
            }
        }
        Destroy(this.gameObject);
    }
}
