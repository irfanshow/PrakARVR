using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float HorizontalInput;
    float VerticalInput;
    bool NyentuhLantai = true;

    void Update()
    {

        //Input untuk player bergerak dengan WASD dengan variable antara 0,1
        //Horizontal kanan kiri
        HorizontalInput = Input.GetAxis("Horizontal");
        //Vertikal maju mundur
        VerticalInput = Input.GetAxis("Vertical");

        //menggerakkan player ke arah kanan kiri (sumbu X)
        transform.Translate(Vector3.right * HorizontalInput * 5 * Time.deltaTime);
        //menggerakkan player ke depan belakang (sumbu Z)
        transform.Translate(Vector3.forward * VerticalInput * 5 * Time.deltaTime);

        //Untuk player supaya dapat melompat ke udara dengan menekan tombol spasi
        if (NyentuhLantai == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Menambahkan force agar player dapat melomat keatas (Sumbu Y)
                GetComponent<Rigidbody>().AddForce(Vector3.up * 15, ForceMode.Impulse);
                NyentuhLantai = false;
            }
            
        }
        else
        {
            Debug.Log("Sedang diudara");
        }


    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Lantai"))
        {
            Debug.Log("Ini object lantai");
            NyentuhLantai = true;
        }
        else
        {
            Debug.Log("Ini bukan lantai");
            
        }
    }
}
