using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{

    public Vector3 openPosition; // ドアが開いたときの位置
    public Vector3 closedPosition; // ドアが閉じたときの位置

    public Transform door; // ドアのTransform
    public float openSpeed = 2.0f; // ドアが開く速度
    
    private bool isOpening = false;
    private bool isClosing = false;

    void Start()
    {
        closedPosition = door.position;
    }

    void Update()
    {
        if (isOpening)
        {
            door.position = Vector3.Lerp(door.position, openPosition, Time.deltaTime * openSpeed);
        }
        else if (isClosing)
        {
            door.position = Vector3.Lerp(door.position, closedPosition, Time.deltaTime * openSpeed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpening = true;
            isClosing = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpening = false;
            isClosing = true;
        }
    }
}
