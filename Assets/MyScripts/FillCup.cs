using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillCup : MonoBehaviour
{
    public Sprite filledSprite;
    public Sprite waterSprite;
    public Sprite teaSprite;

    public SpriteRenderer teaBoyRenderer;
    public SpriteRenderer waterGirlRenderer;

    private bool waterIn;
    private bool teaIn;

    // Start is called before the first frame update
    void Start()
    {
        waterIn = false;
        teaIn = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (teaMade)
        {
            GetComponent<SpriteRenderer>().sprite = filledSprite;
        }
        // go to new scene after timer
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WaterGirl" && !waterIn)
        {
            waterIn = true;
            waterGirlRenderer.enabled = false;
            updateSprite();
        }
        if(other.tag == "TeaBoy" && !teaIn)
        {
            teaIn = true;
            teaBoyRenderer.enabled = false;
            updateSprite();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "WaterGirl" && !waterIn)
        {
            waterIn = false;
            waterGirlRenderer.enabled = true;
            updateSprite();
        }
        if (other.tag == "TeaBoy" && !teaIn)
        {
            teaIn = false;
            teaBoyRenderer.enabled = true;
            updateSprite();
        }
    }

    void updateSprite()
    {
        if (teaIn && waterIn)
        {
            GetComponent<SpriteRenderer>().sprite = filledSprite;
        }
        else if (waterIn)
        {
            GetComponent<SpriteRenderer>().sprite = waterSprite;
        }
        else if (teaIn)
        {
            GetComponent<SpriteRenderer>().sprite = teaSprite;
        }
    }
}
