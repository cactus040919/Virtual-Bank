using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{
    public static SoundManger instance;

    //캐릭터 이동시 나는 소리
    public AudioClip player_run;
    //버튼 클릭시 나는 소리
    public AudioClip buttton_click;

    //플레이어 효과음 담당 AudioSource
    public AudioSource PlayerEffect;
    //Ui 효과음 담당 AudioSource
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

    //캐릭터 이동시 나는 소리 함수
    public void PlayerRun()
    {
        PlayerEffect.clip = player_run;
        PlayerEffect.Play();
    }

    //버튼 클릭시 나는 소리
    public void BuuttonClick()
    {
        UiEffect.clip = buttton_click;
        UiEffect.Play();
    }

    
}
