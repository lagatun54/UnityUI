using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interface : MonoBehaviour
{
    public event Action<float> OnPlayerHealthValueChangedEvent; 

    [SerializeField] private int _healthDefault = 100;

    public int health { get; set; }
    public float healthNormalized => (float) this.health / this._healthDefault;

    private void Awake()
    {
        this.health = this._healthDefault;
        this.OnPlayerHealthValueChangedEvent?.Invoke(this.healthNormalized);

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            this.HitPlayer();
    }

    private void HitPlayer()
    {
        this.health -= 5;
        if(this.health <= 0 )
            Destroy(this.gameObject);
        
        this.OnPlayerHealthValueChangedEvent?.Invoke(this.healthNormalized);
    }
}
