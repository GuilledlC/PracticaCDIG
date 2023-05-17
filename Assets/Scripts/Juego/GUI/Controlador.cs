using UnityEngine;
using UnityEngine.Serialization;

public class Controlador : MonoBehaviour
{
    public TowerStats towerStats;
    public GameObject menuJuego;
    public GameObject menuGanar;
    public GameObject rectangulo;
    public GameObject cuadrado;
    
    public AudioClip musicaGanar;
    public AudioClip musicaAmbiente;
    private AudioSource audioSource;
    
    private int resultado = 0;
    private bool ganado = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.PlayOneShot(musicaAmbiente);
    }

    // Update is called once per frame
    void Update()
    {
        if (rectangulo.GetComponent<MeshRenderer>().enabled)
        {
            resultado = Mathf.RoundToInt((towerStats.destruidos / (float) towerStats.totalR) * 100);
        }
        else if (cuadrado.GetComponent<MeshRenderer>().enabled)
        {
            resultado = Mathf.RoundToInt((towerStats.destruidos / (float) towerStats.totalC) * 100);
        }
        
        if (!ganado && towerStats.getPorcentajeDestuccion() <= resultado)
        {
            ganado = true;
            audioSource.Stop();
            audioSource.PlayOneShot(musicaGanar);
            menuJuego.SetActive(false);
            menuGanar.SetActive(true);
        }
    }
}
