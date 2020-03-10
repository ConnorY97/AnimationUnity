using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;



public class ButtonMananger : MonoBehaviour
{
    public ParticleSystem m_particalSystem;

    private bool m_buttonClicked = false;

    public GameObject m_zombie;

    public void onButtonClick()
    {
        if (!m_buttonClicked)
            m_buttonClicked = true;
        else
            m_buttonClicked = false; 
    }

    public void Attack()
    {
        //if (!m_zombie.GetComponent<Animator>().GetBool("Attack"))
        //m_zombie.GetComponent<Animator>().SetBool("Attack", true);
        //else 
        //    m_zombie.GetComponent<Animator>().SetBool("Attack", false); 
        m_zombie.GetComponent<Animator>().SetTrigger("Attack2");

    }

    // Start is called before the first frame update
    void Start()
    {
        m_particalSystem.Play();
    }


    // Update is called once per frame
    void Update()
    {
        if (m_buttonClicked && !m_particalSystem.isPlaying)
            m_particalSystem.Play();
        else if (!m_buttonClicked)
            m_particalSystem.GetComponent<ParticleSystem>().Stop(false, ParticleSystemStopBehavior.StopEmitting);
    }



}
