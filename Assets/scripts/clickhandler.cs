using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickhandler : MonoBehaviour {


    public int someNumber = 20;

    public GameObject great;
    public Sprite newImage;
    private Rigidbody2D gbody;

    //GameObject greatObj = GameObject.Find("great");

    /*
    // Guarenteed to run at a specific interval (as Update isn't guarenteed).
    // Physics (ie. things that are time-dependant)
    private void FixedUpdate()
    {
        
    }
    */

    // Use this for initialization
    void Start()
    {
        gbody = great.GetComponent<Rigidbody2D>();
        gbody.velocity = new Vector2(5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Executes when a mouse down event occurs
    private void OnMouseDown()
    {
        //dont do this normally. it will look through EVERY object. pls optimize to make it not look through everything
        GameObject greatObj = GameObject.Find("great");

        //log so I can see stuffs
        Debug.Log(greatObj.name);
        Debug.Log(someNumber);

        SpriteRenderer grend = great.GetComponent<SpriteRenderer>();
        grend.sprite = newImage;

        gbody.velocity = new Vector2(-5, 0);
    }

}
