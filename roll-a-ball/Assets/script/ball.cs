using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    private int i=0;
	// Update is called once per frame
	void Update () {
        float horizontal_move = Input.GetAxis("Horizontal");
        float vertical_move = Input.GetAxis("Vertical");
        this.GetComponent<Rigidbody>().AddForce(new Vector3(horizontal_move, 0, vertical_move)*100f);
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.name=="food"){
            GameObject.Destroy(other.gameObject);
            i++;
            Debug.Log("Eat a food");
            if (i == 10){
                Debug.Log("game over");
            }
        }
    }
}
