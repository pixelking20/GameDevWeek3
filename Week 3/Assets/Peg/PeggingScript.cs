using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeggingScript : MonoBehaviour
{
    public bool ImportantPeg;
    public bool MarkedForDeath;
    public float timer = 10f;
    public Material hitMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MarkedForDeath)
            timer -= Time.deltaTime;

        if(timer < 0)
            Destroy(this.gameObject);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            MarkedForDeath = true;
            gameObject.GetComponent<Renderer>().material = hitMat;
        }
    }
}
