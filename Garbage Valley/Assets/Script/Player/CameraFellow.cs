using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;//相机位置
    public float smooting;
    void Start()
    {
        
    }
    private void LateUpdate()
    {
        if(target != null)
        {
            if(transform.position != target.position)
            {
                Vector3 targetPos = target.position;
                transform.position = Vector3.Lerp(transform.position, targetPos, smooting);

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
