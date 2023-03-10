using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject world;
    [SerializeField] GameObject market;
    [SerializeField] GameObject deadScene;
    [SerializeField] GameObject spawnPosition;
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
        if(Coin.coinCounter >= 300){
        PlayerMovement.jumpPower = PlayerMovement.jumpPower + 300;
        Coin.coinCounter = Coin.coinCounter - 200;
        }

    }
    public void Speed()
    {
        if(Coin.coinCounter >= 300){
        PlayerMovement.speed = PlayerMovement.speed + 3;
        Coin.coinCounter = Coin.coinCounter - 300;
        }

    }
    
    public void Shrouiken()
    {
        if(Shuriken_Script.shurikenwait > 0)
        {
            
            Shuriken_Script.shurikenwait -= 1;
            Coin.coinCounter = Coin.coinCounter - 400;

        }
        

    }
    public void NextLevel(){
        SceneManager.LoadScene("Cave");
    }
    public void Back()
    {
        world.SetActive(true);
        market.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;

    }
    public void Play()
    {
        SceneManager.LoadScene("Tutorial");
        Time.timeScale = 1;
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
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    
    public void Revive()
    {
        
        if (Coin.coinCounter >= 300)
        {
            deadScene.SetActive(false);
        world.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        PlayerAnim.destroy = false;
            Coin.coinCounter = Coin.coinCounter - 300;
        }
       
    }
    public void Resume()
    {
        Time.timeScale = 1;

    }

}
