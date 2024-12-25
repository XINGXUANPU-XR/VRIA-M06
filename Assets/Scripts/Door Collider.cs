using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{

    public Vector3 openPosition; // �h�A���J�����Ƃ��̈ʒu
    public Vector3 closedPosition; // �h�A�������Ƃ��̈ʒu

    public Transform door; // �h�A��Transform
    public float openSpeed = 2.0f; // �h�A���J�����x
    
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
