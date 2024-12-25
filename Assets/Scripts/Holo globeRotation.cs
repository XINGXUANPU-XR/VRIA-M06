using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HologlobeRotation : MonoBehaviour
{
    [SerializeField]
    public int Rotation;

    [SerializeField]
    public int Speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ñ≥å¿âÒì]Çê›íË
        transform.DOLocalRotate(new Vector3(0, 0, Rotation), Speed, RotateMode.FastBeyond360)
                 .SetRelative(true)
                 .SetLoops(-1, LoopType.Restart);
    }
}
