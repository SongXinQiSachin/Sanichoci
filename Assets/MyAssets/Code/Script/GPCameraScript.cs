using Sanichoci.Kits;
using Sanichoci.Logic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPCameraScript : MonoBehaviour
{
    public Transform lookAt;
    public float distanceToTarget = 10;
    public float distanceInZ = 3.82f;
    public float angle = 66f;

    public float cameraMoveSpeed = 6.18f;

    private new Transform transform;

    // Use this for initialization
    void Start () {
        transform = base.transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 curPosition = transform.position;
        Vector3 targetPosition = lookAt.position;

        targetPosition.y += distanceToTarget;
        targetPosition.z -= distanceInZ;
        curPosition.y = targetPosition.y;

        curPosition = Vector3.MoveTowards(curPosition, targetPosition, cameraMoveSpeed * TimeKits.deltaTime());

        transform.SetPositionAndRotation(curPosition, Quaternion.Euler(angle, 0, 0));
	}

    private void FixedUpdate()
    {
    }
}
