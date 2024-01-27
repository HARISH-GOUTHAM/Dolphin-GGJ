using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public GameObject followTarget;
    private Vector3 targetPos;
    [SerializeField] private Vector3 offSet;
    public float moveSpeed;

    void Update()
    {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, followTarget.transform.position.z)+offSet;
        Vector3 velocity = targetPos - transform.position;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, 1.0f, moveSpeed * Time.deltaTime);
    }
}
