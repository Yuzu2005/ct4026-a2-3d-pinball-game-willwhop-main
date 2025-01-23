using UnityEngine;
using UnityEngine.SceneManagement;

public class Goals : MonoBehaviour {
    public GameObject bg;
    void OnCollisionEnter(Collision collision) {
        
        //if colliders tag is goal1 then the second level will load
        if (collision.collider.CompareTag("Goal1")) {
            SceneManager.LoadScene("GoToLevel2");
        }
        //else if its goal2 the the secret level will load
        else if (collision.collider.CompareTag("Goal2")) {
            SceneManager.LoadScene("GoToSecretLevel2");
        }
        //if the tag is called end game 1 then it will go to the OnStay function
        else if (collision.collider.CompareTag("EndGame1")) {
            //set bg on scene to true to show up on screen
            bg.SetActive(true);
        }
        
    }
}
