using UnityEngine;

public class cameranitotgekirusumitame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
        private Vector3 _startPosition =new Vector3(0, 0, 30);
        private Vector3 _goalPosition = new Vector3(0, 0, -1);
        private float v = 2.0f;
        private float _progress = 0.0f;
        private readonly float nibunnnoiti = 1/2f;

        private NotesManager_M NotesManagerObject;
        

  
    // Update is called once per frame  
    void Update()
    {
        NotesManager_M notesManager_MScript = NotesManagerObject.GetComponent<NotesManager_M>();
        for(int i = 0;i < 2;i++){
         if(notesManager_MScript.Notes_timing[i] == true)
             {
                  _progress = _progress + v * Time.deltaTime * nibunnnoiti; //x=1/2*a*t^2=v*t*1/2という理論
                  transform.position = Vector3.Lerp(_startPosition, _goalPosition, _progress);
             }
        }
    }
}
