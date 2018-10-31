using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public delegate void PlayerEvents();
    public static event PlayerEvents CambioLuz;
    public static event PlayerEvents AumentoPoder;
    public static event PlayerEvents ReduccionPoder;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            CambioLuz();
        }            
    }

    public static void AumentarPoder()
    {
        if (AumentoPoder != null)
        {
            AumentoPoder();
        }
    }

    public static void ReducirPoder()
    {
        if (ReduccionPoder != null)
        {
            ReduccionPoder();
        }
    }
}
