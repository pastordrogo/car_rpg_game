using System.Collections.Generic;
using UnityEngine;

public class CarStats : MonoBehaviour{

    public string nameCar;
    public int velocity;
    public int agarre;
    public int aceleracion;
    public int frenos;
    public int nitroso;
    public int integrity;

    void Start()
    {
          
    }

    public void SetCarStats(string nameCar, int velocity, int agarre, int aceleracion, int frenos, int nitroso, int integrity)
    {
        this.nameCar = nameCar;
        this.velocity = velocity;
        this.agarre = agarre;
        this.aceleracion = aceleracion;
        this.frenos = frenos;
        this.nitroso = nitroso;
        this.integrity = integrity;
    }
}
