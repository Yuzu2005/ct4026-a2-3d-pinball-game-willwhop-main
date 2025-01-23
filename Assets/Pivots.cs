using UnityEngine;

public class Pivots : MonoBehaviour {
    //note been trying to make it so if lefthitter is set to nothing then it will set to left hitter2 and add 1 to float for each left hitter2
    bool hit =false;
    bool hit2 = false;
    private void Start() {
        hit = false;
        hit2 = false;
    }
    //function sets hit to true
    public void LeftHitter() {
        hit = true;
    }

    public void RightHitter() {
        hit2 = true;
    }

    void Update() {
        Hitters();      
    }

    public void Hitters() {
        //if hit true then get object with hitter1 tag
        if (hit == true) {         
            if (transform.CompareTag("Hitter1")) {
                //if tag is correct play animation and return hit as false afterwards
                Debug.Log("compares tag of hitter1");
                transform.GetComponent<Animator>().SetTrigger("Hitter");
                hit = false;
            }
        }
        if (hit2 == true) {
            if (transform.CompareTag("Hitter2")) {
                transform.GetComponent<Animator>().SetTrigger("Hitter2");
                hit2 = false;
            }
        }
    }
}
