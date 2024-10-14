using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float Walk_speed;
    Collider player_Collider;
    Grapple grapple;
    public Camera Main_Camera;
    private bool is_Zoomed_In;

    private void Start()
    {
        grapple = GetComponent<Grapple>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            grapple.Destroy_Hook();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (player_Collider == null)
        {
            player_Collider = GetComponent<Collider>();
        }
    }
    public void Zoom()
    {
      is_Zoomed_In = !is_Zoomed_In;
       Zooms(is_Zoomed_In);
    }
    public void Zooms(bool zoomed)
    {
       Main_Camera.fieldOfView = zoomed ? 30 : 80;

    }
}
