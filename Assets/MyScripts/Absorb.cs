using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorb : MonoBehaviour
{
    private bool absorbed;
    // Start is called before the first frame update
    void Start()
    {
        absorbed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "WaterGirl" && !absorbed)
        {
            absorbed = true;
            other.gameObject.GetComponent<Pocket>().sugar++;
            Destroy(this);            
        }
    }
}
