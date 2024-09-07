using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioAmbiente : MonoBehaviour
{
    void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex; //0,1,2,3 

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(escena_actual);
            if (escena_actual == 0)
            {
                PracticasP(1);
            }
            else if (escena_actual == 1)
            {
                PracticasP(2);
            }
            else
            {
                PracticasP(0);
            }
        }
    }

    public void PracticasP(int index_escena_ir)
    {
        SceneManager.LoadScene(index_escena_ir);
    }
}