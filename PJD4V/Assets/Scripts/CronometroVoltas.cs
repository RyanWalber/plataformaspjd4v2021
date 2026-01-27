using UnityEngine;
using TMPro;

public class CronometroVoltas : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoVoltas;

    public GameObject objetoParte1;
    public GameObject objetoParte2;
    public GameObject objetoParte3;

    private float tempoAtual = 0f;
    private int numeroVoltas = 0;

    void Update()
    {
        tempoAtual += Time.deltaTime;
        if(textoCronometro != null) textoCronometro.text = "Tempo: " + tempoAtual.ToString("F2");
    }

    public void RegistrarVolta()
    {
        numeroVoltas++;
        string tempoFormatado = tempoAtual.ToString("F2");

        if (numeroVoltas == 1) DefinirTexto(objetoParte1, "P1: " + tempoFormatado);
        else if (numeroVoltas == 2) DefinirTexto(objetoParte2, "P2: " + tempoFormatado);
        else if (numeroVoltas == 3) DefinirTexto(objetoParte3, "P3: " + tempoFormatado);

        if(textoVoltas != null) textoVoltas.text = "Voltas: " + numeroVoltas;
        tempoAtual = 0f;
    }

    void DefinirTexto(GameObject obj, string valor) {
        if (obj == null) return;
        var t = obj.GetComponentInChildren<TextMeshProUGUI>();
        if (t != null) t.text = valor;
    }
}