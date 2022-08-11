using UnityEngine;

public class MotorController : MonoBehaviour
{
    [SerializeField] private WheelJoint2D _backWheel;
    [SerializeField] private float _motorTorque;
    
    private JointMotor2D _backMotor;
    private float _movement;       

    private void Update()
    {
        _movement = Input.GetAxis("Horizontal");
        MovementBike();
        
    } 
    private void MovementBike()
    {
        _backMotor.maxMotorTorque = _motorTorque;
        _backMotor.motorSpeed -= _movement;

        if (_movement == 0)
        {
            _backMotor.motorSpeed = 0;
            _backMotor.maxMotorTorque = 0;

        }
        _backWheel.motor = _backMotor;
    }


}




    
       

