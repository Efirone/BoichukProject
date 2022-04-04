using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehaviour : MonoBehaviour
{
       public GameObject sun;
       public GameObject cloud;
       public Slider slider;
    public RawImage SmilingFace;
    public RawImage NormalFace;
    public RawImage SadFace;
    public ParticleSystem rain;
    public GameObject cloudblack;
    public Animation cloudappear;
    public Animation cloudblackappear;
    public Animation sunappear;
    public void Awake()
    {
        rain.Stop(true);
        cloudappear.Play("cloud");
        sunappear.Play("sun");
    }
    public void SceneChanges()
    {
        if (slider.value == 3)
        {
            sun.SetActive(true);
            cloud.SetActive(false);
            SmilingFace.enabled=true;
            NormalFace.enabled = false;
            SadFace.enabled = false;
            rain.Stop(true);
            cloudblack.SetActive(false);
            sunappear.Play("sun");

        }
        if(slider.value == 2)
        {
            sun.SetActive(true);
            cloud.SetActive(true);
            SmilingFace.enabled = false;
            NormalFace.enabled = true;
            SadFace.enabled = false;
            rain.Stop(true);
            cloudblack.SetActive(false);
            cloudappear.Play("cloud");
            sunappear.Play("sun");
        }
        if(slider.value == 1)
        {
            sun.SetActive(false);
            cloud.SetActive(false);
            SmilingFace.enabled = false;
            NormalFace.enabled = false;
            SadFace.enabled = true;
            rain.Play(true);
            cloudblack.SetActive(true);
            cloudblackappear.Play("cloudblack");
        }
    }
}
