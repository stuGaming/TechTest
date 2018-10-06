using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class ParticleController : MonoBehaviour
{
    public float strength=1f;
    public float maxSpeed = 1f;
    public Rigidbody thisRigid;
    public MeshRenderer thisMaterial;
    public List<Color> colors;
    private void Start()
    {
        
        AddRandomForce();
    }

    private void AddRandomForce()
    {
        float x = UnityEngine.Random.Range(-strength, strength);
        float y = UnityEngine.Random.Range(-strength, strength);
        float z = UnityEngine.Random.Range(-strength, strength);

        thisRigid.AddForce(x, y, z,ForceMode.VelocityChange);

        x = UnityEngine.Random.Range(-strength, strength);
        y = UnityEngine.Random.Range(-strength, strength);
        z = UnityEngine.Random.Range(-strength, strength);
        thisRigid.AddTorque(x, y, z,ForceMode.VelocityChange);
        thisMaterial.material.SetColor("_EmissionColor", colors[UnityEngine.Random.Range(0,colors.Count)]);
    }


    private void OnCollisionEnter(Collision collision)
    {
        AddRandomForce();
    }
}
