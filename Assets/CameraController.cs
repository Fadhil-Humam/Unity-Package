using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player; // untuk mengakses game object Player
    private Vector3 offset; // membuat variabel bertipe Vector3 bernama offset
                            // private karena cuma ingin dipakai di skrip ini
                            // Use this for initialization
    void Start()
    { // Offset value: selisih/jarak antara object Player & kamera.
      //  berarti offset = posisi kamera saat ini - posisi player.
        offset = transform.position - Player.transform.position;
    }
    // LateUpdate is called after all Update functions have been called
    void LateUpdate()
    { // mengeset posisi kamera sejauh offset dari object Player
        transform.position = Player.transform.position + offset;
    }
}
