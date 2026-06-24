using System.Threading;
using System.Timers;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    System.Timers.Timer timer = new System.Timers.Timer(0.01);
    private bool OnGame_path;

    private bool OutGame_path;

    private int elapsedCOunt = 0;

    private int Notes_timingNumber = 0;
    private bool isListUpdateTarget = false;

    private NotesManager_M NotesManagerObject;

    
    void Awake()
    {
        
    }
    
    void Start()
    {   
        
        timer.AutoReset = true;
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
        timer.Start();
 
    }
    
      

    // Update is called once per frame
    
    void Update()
    {
        OnGame_path = GameManager.instance.OnGame;
        if (OnGame_path == true)
        {
            timer.Start();
        }
        if(isListUpdateTarget == true)
        {
            isListUpdateTarget = false;
            NotesManager_M notesManager_MScript= NotesManagerObject.GetComponent<NotesManager_M>();
            notesManager_MScript.Notes_timing[Notes_timingNumber] = true;
            Notes_timingNumber++;
        }
    }   

    void Dispose()
    {
        if (OutGame_path == true)
        {
            timer.Stop();
            timer.Dispose();
            timer = null;
        }
    }

    void testDispose()
    {
        timer.Stop();
        timer.Dispose();
        timer = null;
        Debug.Log("タイマー消したよ");
    }
    
}