using UnityEngine;
public class Bumpers : MonoBehaviour {
    public AudioSource bumpsource;
    public AudioClip bumpclip;
    void OnCollisionEnter(Collision collision) {
        //on collision if game objects tag is Ball then set trigger for bumper1 and add sound 
        //https://pixabay.com/sound-effects/retro-game-sfx-jump-bumpwav-14853/
        if (collision.gameObject.CompareTag("Ball")) {
            transform.GetComponent<Animator>().SetTrigger("bumper1");
            bumpsource.PlayOneShot(bumpclip);
        }
    }
}
