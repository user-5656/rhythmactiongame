using System.Threading;
using System.Timers;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    System.Timers.Timer timer = new System.Timers.Timer(0.01);
    private bool OnGame_path;

    private bool OutGame_path;
    void Awake()
    {
        
    }
    
    void Start()
    {   
        
        timer.AutoReset = false;
        timer.Elapsed += (System.Object source, ElapsedEventArgs e) =>
        {
            Debug.Log("これはログだよ。");
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
}