using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


[RequireComponent(requiredComponent:typeof(MoveTo))]
public class Vision : MonoBehaviour
{
    public Transform playerTransform;
    Transform enemyTransform;
    public GameObject advertencia;
    public float counter;
    float viewed;
    //private EnemyMove enemyMove;
    private MoveTo enemyMove;

    [SerializeField]
    float rangoDeVision = 10f;

    private void Awake()
    {
        enemyTransform = transform;
        enemyMove = gameObject.GetComponent<MoveTo>();
    }


    // Update is called once per frame
    private void Update()
    {
        bool JugadorALaVista = VisionDeJugador();
        advertencia.SetActive(JugadorALaVista);
        if (JugadorALaVista==true)
        {
            viewed+=Time.deltaTime;
            
            if (viewed >2f)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        else
        {
            viewed = 0;
            enemyMove.Move();
        }
    }

    private bool VisionDeJugador()
    {
        Vector3 desplazJugador = playerTransform.position - enemyTransform.position;
        float distanciaDelJugador = desplazJugador.magnitude;
        if (distanciaDelJugador < rangoDeVision)
        {
            float productoPunto = Vector3.Dot(enemyTransform.forward, desplazJugador.normalized);
            if (productoPunto>=0.5f)
            {
                RaycastHit hit;
                if (Physics.Raycast(enemyTransform.position + desplazJugador.normalized * 1.01f, desplazJugador.normalized, out hit, Mathf.Infinity))
                {
                    Debug.DrawRay(enemyTransform.position + desplazJugador.normalized * 1.01f, desplazJugador.normalized * hit.distance, Color.red);
                    //playerTransform.position -= desplazJugador.normalized * 0.2f;
                    if (hit.collider.gameObject.name == "Kid")
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}