using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += transform.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;
    }
}
