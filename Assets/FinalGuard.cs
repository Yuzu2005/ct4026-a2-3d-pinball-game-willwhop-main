using System.Collections;
using UnityEngine;

public class FinalGuard : MonoBehaviour {
    public float ExForce;
    public float FieldOfInpact;
    public float fuse = 2.2f;
    //on collision compare tag if its ball then call explode
    void OnCollisionEnter(Collision collision) {
        if (collision.transform.CompareTag("Ball")) {
            StartCoroutine(Explode(fuse));
        }
    }
    private IEnumerator Explode(float fuse) {
        float countdown = 0f;
        //while countdown is less than fuse it will keep adding to the time until it gets to 2.2 seconds
        while (countdown < fuse) {
            countdown += Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        //sets collider to have a box collider
        Collider[] collider = Physics.OverlapBox(transform.position, new Vector3(FieldOfInpact, FieldOfInpact, FieldOfInpact)); ;
        foreach (Collider target in collider) {
            //gets rigidbody
            Rigidbody rb = target.GetComponent<Rigidbody>();

            //if there is a rigidbody add force
            if (rb != null) {
                rb.AddExplosionForce(ExForce, transform.position, FieldOfInpact, 5.2f);
            }
        }
        Destroy(gameObject);
        yield return null;
    }
}
