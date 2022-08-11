using UnityEngine;

public class Scrolling : MonoBehaviour
{
    [SerializeField] private float _backgroundSize;
    [SerializeField] private float _viewZone;

    private Transform _cameraTransform;
    private Transform[] _layers;

    private int _leftIndex;
    private int _rightIndex;
    private void Start()
    {
        _cameraTransform = Camera.main.transform;
        _layers = new Transform[transform.childCount];
        
        for(int i = 0; i < transform.childCount; i++)
        {
            _layers[i] = transform.GetChild(i);
        }
        _leftIndex = 0;
        _rightIndex = _layers.Length - 1;
    }

    private void Update()
    {
        if(_cameraTransform.position.x < (_layers[_leftIndex].transform.position.x + _viewZone))
            ScrollLeft();
        
        if (_cameraTransform.position.x > (_layers[_rightIndex].transform.position.x - _viewZone))
            ScrollRight();
    }
    private void ScrollLeft()
    {
        int lastRight = _rightIndex;
        _layers[lastRight].position = Vector3.right * (_layers[_leftIndex].position.x - _backgroundSize);
        _leftIndex = _rightIndex;
        _rightIndex--;

        if(_rightIndex < 0)
            _rightIndex = _layers.Length - 1;
    }
    private void ScrollRight()
    {
        int lastLeft = _leftIndex;
        _layers[lastLeft].position = Vector3.right * (_layers[_rightIndex].position.x + _backgroundSize);
        _rightIndex = _leftIndex;
        _leftIndex++;

        if (_leftIndex == _layers.Length)
            _leftIndex = 0;
    }
}
