using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject world;
    [SerializeField] GameObject market;
    AudioSource au;
    private int SoundSetting;
    void Start()
    {
        au = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jump()
    {
        PlayerMovement.jumpPower = PlayerMovement.jumpPower + 300;
        Coin.coinCounter = Coin.coinCounter - 200;

    }
    public void Speed()
    {
        PlayerMovement.speed = PlayerMovement.speed + 3;
        Coin.coinCounter = Coin.coinCounter - 300;

    }
    public void NextLevel(){
        SceneManager.LoadScene("Cave");
    }
    public void Back()
    {
        world.SetActive(true);
        market.SetActive(false);
        Cursor.visible = false;


    }
    public void Play()
    {
        SceneManager.LoadScene("Tutorial");

    }
    
    public void Exit()
    {
        Application.Quit();
    }
    public void Sound()
    {
        
            au.mute = !au.mute;
        
    }
    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

}
