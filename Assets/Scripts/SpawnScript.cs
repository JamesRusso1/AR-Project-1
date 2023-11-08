using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class SpawnScript : MonoBehaviour
{
    public GameObject Projectile;

    ARGestureInteractor ARGI;

    private void OnEnable()
    {
        ARGI = GetComponent<ARGestureInteractor>();
        ARGI.tapGestureRecognizer.onGestureStarted += Tap;
    }
    private void Tap(TapGesture obj)
    {

    }

    void Start()
    {
        GameObject newProjectile = Instantiate(Projectile);
        newProjectile.transform.position = transform.position;
        newProjectile.GetComponent<Rigidbody>().velocity = transform.forward * 4f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
