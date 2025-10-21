using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PointsCounting : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI contadorCirculo;
    [SerializeField] TextMeshProUGUI contadorQuadrado;
    int pontosCirculo = 0;
    int pontosQuadrado = 0;

         private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Circulos"))
        {
            pontosCirculo++;
            contadorCirculo.text = "Círculos coletados:" + pontosCirculo.ToString("000");
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Quadrados"))
        {
            pontosQuadrado++;
            contadorQuadrado.text = "Quadrados coletados:" + pontosQuadrado.ToString("000");
            Destroy(collision.gameObject);
        }
    }
}
