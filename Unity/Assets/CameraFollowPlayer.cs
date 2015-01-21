using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform target;
    public float smooth = 5.0f;

    private Vector2 cameraFollow;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cameraFollow = Vector2.Lerp(transform.position, target.position, Time.deltaTime * smooth);
        transform.position = new Vector3(cameraFollow.x, cameraFollow.y, -10f);
    }
}