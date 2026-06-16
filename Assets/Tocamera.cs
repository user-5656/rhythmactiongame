using UnityEngine;

public class cameranitotgekirusumitame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
        private Vector3 _startPosition =new Vector3(0, 0, 30);
        private Vector3 _goalPosition = new Vector3(0, 0, -1);
        private float v = 2.0f;
        private float _progress = 0.0f;
        private readonly float nibunnnoiti = 1/2f;
        

  
    // Update is called once per frame  
    void Update()
    {
        
        _progress = _progress + v * Time.deltaTime * nibunnnoiti; //x=1/2*a*t^2=v*t*1/2という理論
        transform.position = Vector3.Lerp(_startPosition, _goalPosition, _progress);
    }
}
