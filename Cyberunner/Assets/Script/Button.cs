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
    bool isMute;
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
        if(Coin.coinCounter >= 300)
        {
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

        isMute = !isMute;
     AudioListener.volume = isMute ? 0 : 1;

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
    public void volkan()
    {
        SceneManager.LoadScene("cr1");
        
    }
    public void cave()
    {
        SceneManager.LoadScene("cr2");
        
    }
    public void cyber()
    {
        SceneManager.LoadScene("cr3");
        
    }
}
