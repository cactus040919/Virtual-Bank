using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{
    public static SoundManger instance;

    //ĳ���� �̵��� ���� �Ҹ�
    public AudioClip player_run;
    //��ư Ŭ���� ���� �Ҹ�
    public AudioClip buttton_click;

    //�÷��̾� ȿ���� ��� AudioSource
    public AudioSource PlayerEffect;
    //Ui ȿ���� ��� AudioSource
    public AudioSource UiEffect;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //ĳ���� �̵��� ���� �Ҹ� �Լ�
    public void PlayerRun()
    {
        PlayerEffect.clip = player_run;
        PlayerEffect.Play();
    }

    //��ư Ŭ���� ���� �Ҹ�
    public void BuuttonClick()
    {
        UiEffect.clip = buttton_click;
        UiEffect.Play();
    }

    
}
