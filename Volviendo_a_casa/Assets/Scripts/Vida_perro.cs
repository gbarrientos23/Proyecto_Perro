using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida_perro : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;

    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer <= 0)
        {
            Debug.Log("Game Over");
        }
        if (vidaPlayer <= 0)
        {
            Time.timeScale = 0f;
            Respawn.gameOverManager.CallGameOver();
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
