using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;

    //Paper Mario Flipping
    private bool facingFlipped = false;
    private bool shouldRotate = false;
    private Quaternion forwardRotation;
    private float rotateStart;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float horizontalSpeed = horizontal * speed * Time.deltaTime;
        transform.position += new Vector3(horizontalSpeed, 0f, 0f);
        if (horizontalSpeed < 0)
            facingFlipped = true;
        else if (horizontalSpeed > 0)
            facingFlipped = false;

    }

    // Update is called once per frame
    void Update()
    {
        //Paper Mario Flipping
        if (facingFlipped != shouldRotate)
        {
            forwardRotation = Quaternion.Euler(0, facingFlipped ? 180 : 0, 0);
            rotateStart = Time.time;
            shouldRotate = facingFlipped;
        }

        this.gameObject.transform.localRotation = Quaternion.Slerp(this.gameObject.transform.rotation, forwardRotation, (Time.time - rotateStart) * 2f);
    }
}
