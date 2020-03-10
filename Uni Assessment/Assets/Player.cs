using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI; 

public class Player : MonoBehaviour
{
    public GameObject m_zombie;

    public float m_movementSpeed = 10f;
    public float m_rotationSpeed = 100f; 

    private Animator m_zombieAnimator = null; 


    // Start is called before the first frame update
    void Start()
    {
        m_zombieAnimator = m_zombie.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate((Input.GetAxis("Vertical") * Time.deltaTime) * m_movementSpeed, 0f, 0f);
        //transform.forward.Set((Input.GetAxis("Vertical") * Time.deltaTime), 0f, 0f); 
        transform.Translate(Vector3.forward * (Input.GetAxis("Vertical") * Time.deltaTime) * m_movementSpeed);
        transform.Rotate(0f, (Input.GetAxis("Horizontal") * Time.deltaTime) * m_rotationSpeed, 0f); 

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            m_zombieAnimator.SetBool("Walking", true);
        }
        else
            m_zombieAnimator.SetBool("Walking", false);
    }
}
