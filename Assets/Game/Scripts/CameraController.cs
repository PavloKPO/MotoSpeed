using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _biker;
    [SerializeField] private Vector3 _cameraStartPos;

    private void Update()
    {
        Vector3 tempBikePos = _biker.position;
        transform.position = new Vector3(tempBikePos.x, _cameraStartPos.y, _cameraStartPos.z);
    }

}
