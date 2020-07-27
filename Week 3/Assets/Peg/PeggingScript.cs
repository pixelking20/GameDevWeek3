using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeggingScript : MonoBehaviour
{
    public bool importantPeg;
    public bool markedForDeath;
    public float timer = 10f;
    public Material hitMat;
    public int importantRate = 25;
    public Material importantMat;

    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0,100) < importantRate)
        {
            importantPeg = true;
            gameObject.GetComponent<Renderer>().material = importantMat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(markedForDeath)
            timer -= Time.deltaTime;

        if(timer < 0)
            Destroy(this.gameObject);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            markedForDeath = true;
            gameObject.GetComponent<Renderer>().material = hitMat;
        }
    }
}
