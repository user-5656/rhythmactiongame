using System.Threading;
using System.Timers;
using UnityEngine;
using UnityEngine.InputSystem;

public class TimeKeeper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    System.Timers.Timer timer = new System.Timers.Timer(1);
    private bool OnGame_path;

    private bool OutGame_path;

    private int elapsedCOunt = 0;

    private int Notes_timingNumber = 0;
    private bool isListUpdateTarget = false;

    private InputAction StopTimer;

    private NotesManager_M NotesManagerObject;

    
    void Awake()
    {
        StopTimer = InputSystem.actions.FindActionMap("TImer_stop_key").FindAction("Stop") ;
    }

    void OnEnable()
    {
        StopTimer.started += OnMove;
    }
    void Start()
    {   
        
        timer.AutoReset = true;
      
        timer.Start();
        

        timer.Elapsed += (System.Object source, ElapsedEventArgs e) =>
        {
            elapsedCOunt++;
            if(elapsedCOunt == 10000)
            {
                Debug.Log("0.1秒");
                isListUpdateTarget = true;
            }
            Debug.Log("この前に0.1がくるよ");
        };

        OnGame_path = GameManager.instance.OnGame;
        if (OnGame_path == true)
        {
            timer.Start();
        }
        

 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
          timer.Stop();
          timer.Dispose();
          timer = null;
          Debug.Log("タイマー消したよ");
        }
        if(isListUpdateTarget == true)
        {
            isListUpdateTarget = false;
            NotesManager_M notesManager_MScript= NotesManagerObject.GetComponent<NotesManager_M>();
            notesManager_MScript.Notes_timing[Notes_timingNumber] = true;
            Notes_timingNumber++;
        }
    }

    // Update is called once per frame



    void OnMove(InputAction.CallbackContext context)
    {

    }

   /*   if (OutGame_path == true)
        {
            timer.Stop();
            timer.Dispose();
            timer = null;
        }
    */
}