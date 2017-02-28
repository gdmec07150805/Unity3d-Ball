using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBall : MonoBehaviour {

    public GameObject ball;
	
	// Update is called once per frame
	void Update () {
        Vector3 ball_position = ball.GetComponent<Transform>().position;
        this.GetComponent<Transform>().position =new Vector3(ball_position.x - 4.47f, ball_position.y+ 1.69f, ball_position.z-4.36f);
    }
}
