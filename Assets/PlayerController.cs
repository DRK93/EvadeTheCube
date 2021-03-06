using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public HudManager hudManager;
    public float speed;
    public Transform leftWall;
    public Transform rightWall;
    private Stats m_Stats;

    private void Awake()
    {
        m_Stats = GetComponent<Stats>();
        hudManager.UpdateHealthText(m_Stats.health);
    }
    private void Update()
    {
        if(m_Stats.health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float horizontalPosition = transform.position.x + horizontalInput * speed * Time.deltaTime;
        float playerSizeX = transform.localScale.x / 2;
        float leftWallSizeX = leftWall.localScale.x / 2;
        float rightWallSizeX = rightWall.localScale.x / 2;

        if (horizontalPosition - playerSizeX <= leftWall.position.x + leftWallSizeX)
        {
            return;
        }
        if (horizontalPosition + playerSizeX >= rightWall.position.x - rightWallSizeX)
        {
            return;
        }
        transform.position = new Vector3(
            horizontalPosition,
            1,
            transform.position.z);

        if (Input.GetKeyDown(KeyCode.Escape))
            ExitGame();
    }
    public void ReceiveDamage()
    {
        Debug.Log("Ouch");
        m_Stats.UpdateHealth(10);
        hudManager.UpdateHealthText(m_Stats.health);
    }
    
    public void ExitGame()
    {
        
            Application.Quit();
    }
}

