using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class pauseMenu : MonoBehaviour
{
    private PlayerControls menu;
    public void Awake()
    {
        menu = new PlayerControls();
       
    }
    private void OnEnable()
    {
        menu.Menu.Enable();
    }
    private void OnDisable()
    {
        menu.Menu.Disable();
    }
    public void Resume(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            pauseManager.instance.canvas.SetActive(false);
            menu.Menu.Disable();
            pauseManager.instance.resumeGame();
        }
    }
    public void ResumeClick()
    {
        pauseManager.instance.canvas.SetActive(false );
        menu.Menu.Disable();
        pauseManager.instance.resumeGame();
    }
    public void quitwithoutSave()
    {
        Application.Quit();
    }
    public void quitwithSave()
    {
        SaveSystem.SavePlayer(pauseManager.instance.movement.gameObject.GetComponent<Movement>(), pauseManager.instance.settings, pauseManager.instance.inventar,pauseManager.instance.camera,pauseManager.instance.gameState);
        Application.Quit();
    }
    public void SavePlayer()
    {
        Debug.Log("saving");
        SaveSystem.SavePlayer(pauseManager.instance.movement.gameObject.GetComponent<Movement>(),pauseManager.instance.settings,pauseManager.instance.inventar,pauseManager.instance.camera,pauseManager.instance.gameState);
        Debug.Log(pauseManager.instance.camera.playerbody.eulerAngles);
    }
    public void LoadPlayer()
    {
      


    }
}
