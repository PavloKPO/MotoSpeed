using UnityEngine;

public class MotorController : MonoBehaviour
{
    [SerializeField] private WheelJoint2D _backWheel;
    [SerializeField] private float _carTorque;
    
    private JointMotor2D _backMotor;
    private float _movement;

    private void Update()
    {
        _movement = Input.GetAxis("Horizontal");
        MovementBike();
    }



    private void MovementBike()
    {
        if (_movement > 0)
        {
            _backMotor.motorSpeed -= 1f;
            _backMotor.maxMotorTorque = _carTorque;

            _backWheel.motor = _backMotor;
        }
        else if (_movement < 0)
        {
            _backMotor.motorSpeed += 1f;
            _backMotor.maxMotorTorque = _carTorque;

            _backWheel.motor = _backMotor;

        }
        else
        {
            _backMotor.motorSpeed = 0;
            _backMotor.maxMotorTorque = 0;

            _backWheel.motor = _backMotor;
        }
    }


}




    
       

