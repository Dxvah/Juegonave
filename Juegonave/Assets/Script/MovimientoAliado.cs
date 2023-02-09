using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAliado : MonoBehaviour
{
   
   [SerializeField]
      float speed = 0f;
   [SerializeField]
       float speedRotationVertical = 10f;
   [SerializeField]
       float speedRotationHorizontal = 10f;




   void Update()
   {
       float rotationx = Input.GetAxis("Vertical") * speedRotationVertical * Time.deltaTime;
       float rotationz = Input.GetAxis("Horizontal") * speedRotationHorizontal * Time.deltaTime;

       transform.Rotate(rotationz, 0f, rotationx, Space.Self);

       transform.position += transform.localPosition * Time.deltaTime * speed;

   }
   
}
