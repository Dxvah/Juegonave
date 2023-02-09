using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAliado : MonoBehaviour
{ 
    [SerializeField]
    bool throttle => Input.GetKey(KeyCode.Space);
    [SerializeField]
    float pitchPower, rollPower, yawPower, enginePower;
    [SerializeField]
    float activeRoll, activePitch, activeYaw;

    void Update()
      {
        if (throttle)
        {
            transform.position += transform.forward * enginePower * Time.deltaTime;

            activePitch = Input.GetAxisRaw("Vertical") * pitchPower * Time.deltaTime;
            activeRoll = Input.GetAxisRaw("Horizontal") * rollPower * Time.deltaTime;
            activeYaw = Input.GetAxisRaw("Yaw") * yawPower * Time.deltaTime;

            transform.Rotate(activePitch * pitchPower * Time.deltaTime,
                activeYaw * yawPower * Time.deltaTime,
                -activeRoll * rollPower * Time.deltaTime,
                Space.Self);
        }
        else
        {
            activePitch = Input.GetAxisRaw("Vertical") * (pitchPower / 2) * Time.deltaTime;
            activeRoll = Input.GetAxisRaw("Horizontal") * (rollPower / 2) * Time.deltaTime;
            activeYaw = Input.GetAxisRaw("Yaw") * (yawPower / 2) * Time.deltaTime;

            transform.Rotate(activePitch * pitchPower * Time.deltaTime,
                activeYaw * yawPower * Time.deltaTime,
                -activeRoll * rollPower * Time.deltaTime,
                Space.Self);
        }
    }
}