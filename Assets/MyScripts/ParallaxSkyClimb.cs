using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tutorial: https://blog.yarsalabs.com/parallax-effect-in-unity-2d/


public class ParallaxSkyClimb : MonoBehaviour
{
    private float _startingPosX; //This is starting X position of the sprites.
    private float _startingPosY; //This is starting Y position of the sprites.
    private float _lengthOfSpriteX;    //This is the length X of the sprites.
    private float _lengthOfSpriteY;    //This is the length Y of the sprites.
    public float AmountOfParallax;  //This is amount of parallax scroll. 
    public Camera MainCamera;   //Reference of the camera.

    // Start is called before the first frame update
    void Start()
    {
        //Getting the starting X position of sprite.
        _startingPosX = transform.position.x;
        //Getting the length of the sprites.
        _lengthOfSpriteX = GetComponent<SpriteRenderer>().bounds.size.x;

        //Getting the starting Y position of sprite.
        _startingPosY = transform.position.y;
        //Getting the length of the sprites.
        _lengthOfSpriteY = _lengthOfSpriteX; //GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 Position = MainCamera.transform.position;
            float TempX = Position.x * (1 - AmountOfParallax);
            float TempY = Position.y * (1 - AmountOfParallax);
            float DistanceX = Position.x * AmountOfParallax;
            float DistanceY = Position.y * AmountOfParallax;


        Vector3 NewPosition = new Vector3(_startingPosX + DistanceX, _startingPosY + DistanceY, transform.position.z);

            transform.position = NewPosition;

            if (TempX > _startingPosX + (_lengthOfSpriteX / 2))
            {
                _startingPosX += _lengthOfSpriteX;
            }
            else if (TempX < _startingPosX - (_lengthOfSpriteX / 2))
            {
                _startingPosX -= _lengthOfSpriteX;
            }

            if (TempY > _startingPosY + (_lengthOfSpriteY/2))
            {
                _startingPosY += _lengthOfSpriteY;
            }
            else if (TempY < _startingPosY - (_lengthOfSpriteY/2))
            {
                _startingPosY -= _lengthOfSpriteY;
            }
    }
}
