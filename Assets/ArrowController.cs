using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        // fall in by same speed per frame
        transform.Translate(0, -0.1f, 0);

        // if move out of the display, discord object
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 	collision detection
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d < r1 + r2)
        {
            Destroy(gameObject);

            // tell Director collision to Plyaer
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
        }
    }
}
