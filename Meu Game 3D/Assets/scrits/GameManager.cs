using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int restantes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }


    public void subtrairmoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
        if (restantes <= 0)
        {
            MsgVitoria.text = "parabéns";
        }
}
}
