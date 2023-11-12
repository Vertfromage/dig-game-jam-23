using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public Sprite BrokenSprite;
    private bool broken;
    // Start is called before the first frame update
    void Start()
    {
        broken = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (broken)
        {
            GetComponent<Thrower>().ThrowObject();
            broken = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "TeaBoy" && !broken)
        {
            broken = true;
            GetComponent<SpriteRenderer>().sprite = BrokenSprite;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.tag+" left jar");
    }
}
