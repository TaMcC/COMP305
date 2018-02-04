using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenbtn : MonoBehaviour {

    public GameObject guy;
    private SpriteRenderer guyRend;
    public Sprite newImage;

    // Use this for initialization
    void Start()
    {
        guyRend = guy.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        guyRend.sprite = newImage;
    }
}
