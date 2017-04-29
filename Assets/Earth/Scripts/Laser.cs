using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour
{

    private LineRenderer lr;
    public ParticleSystem DestructionEffect;
    // Use this for initialization
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Laser2();
        }else
        {
            //LaserOff()
            lr.SetPosition(0,new Vector3(0,0,0));
        }
    }

    public void Laser2()
    {
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                Debug.Log("Laser: " + hit.collider.name);
                lr.SetPosition(1, hit.point);
                Destroyer.instance.Explode(hit.collider.gameObject, DestructionEffect);
            }
        }
        else lr.SetPosition(1, transform.forward * 5000);
    }

    public void LaserOff()
    {
        
    }
}