using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenü : MonoBehaviour {


    public static float Aziz = 0;
    public static float Thrust = 0;
    public static float Height = 0;
    public static float Diameter = 0;
    public static float Rate = 0;
    public static float Velocity = 0;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
    }

    public void MotorSec(Dropdown drop)
    {
        if (drop.value == 1)
        {
            Aziz = 10;
            Debug.Log("100");
        }
        if (drop.value == 2)
        {
            Aziz = 20;
            Debug.Log("200");
        }
        if (drop.value == 3)
        {
            Aziz = 15;
            Debug.Log("300");
        }

    }


    public void ThrustSec(Dropdown drop2)
    {
        if (drop2.value == 1)
        {
            Thrust = 987;
            Debug.Log("100");
        }
        if (drop2.value == 2)
        {
            Thrust = 1262;
            Debug.Log("200");
        }
        if (drop2.value == 3)
        {
            Thrust = 2554;
            Debug.Log("300");
        }
        if (drop2.value == 4)
        {
            Thrust = 3678;
            Debug.Log("400");
        }
        if (drop2.value == 5)
        {
            Thrust = 5897;
            Debug.Log("500");
        }
        if (drop2.value == 6)
        {
            Thrust = 6254;
            Debug.Log("600");
        }
        if (drop2.value == 7)
        {
            Thrust = 7835;
            Debug.Log("700");
        }
    }


    public void DiameterSec(Dropdown drop3)
    {
        if (drop3.value == 1)
        {
            Diameter = 142;
            Debug.Log("100");
        }
        if (drop3.value == 2)
        {
            Diameter = 200;
            Debug.Log("200");
        }
        if (drop3.value == 3)
        {
            Diameter = 254;
            Debug.Log("300");
        }
        if (drop3.value == 4)
        {
            Diameter = 366;
            Debug.Log("400");
        }
        
    }


    public void VelocitySec(Dropdown drop4)
    {
        if (drop4.value == 1)
        {
            Velocity = 20;
            Debug.Log("100");
        }
        if (drop4.value == 2)
        {
            Velocity = 30;
            Debug.Log("200");
        }
        if (drop4.value == 3)
        {
            Velocity = 100;
            Debug.Log("300");
        }
        if (drop4.value == 4)
        {
            Velocity = 150;
            Debug.Log("400");
        }
        if (drop4.value == 5)
        {
            Velocity = 300;
            Debug.Log("500");
        }
        if (drop4.value == 6)
        {
            Velocity = 500;
            Debug.Log("600");
        }
        if (drop4.value == 7)
        {
            Velocity = 1000;
            Debug.Log("700");
        }
    }

    public void HeightSec(Dropdown drop5)
    {
        if (drop5.value == 1)
        {
            Height = 300;
            Debug.Log("100");
        }
        if (drop5.value == 2)
        {
            Height = 1500;
            Debug.Log("200");
        }
        if (drop5.value == 3)
        {
            Height = 3000;
            Debug.Log("300");
        }
        if (drop5.value == 4)
        {
            Height = 5000;
            Debug.Log("400");
        }
        if (drop5.value == 5)
        {
            Height = 7000;
            Debug.Log("500");
        }
        
    }


    public void RateSec(Dropdown drop6)
    {
        if (drop6.value == 1)
        {
            Rate = 100;
            Debug.Log("100");
        }
        if (drop6.value == 2)
        {
            Rate = 200;
            Debug.Log("200");
        }
        if (drop6.value == 3)
        {
            Rate = 300;
            Debug.Log("300");
        }
        if (drop6.value == 4)
        {
            Rate = 500;
            Debug.Log("400");
        }
        if (drop6.value == 5)
        {
            Rate = 1000;
            Debug.Log("500");
        }
        if (drop6.value == 6)
        {
            Rate = 2000;
            Debug.Log("600");
        }
        if (drop6.value == 7)
        {
            Rate = 5000;
            Debug.Log("700");
        }
        if (drop6.value == 8)
        {
            Rate = 10000;
            Debug.Log("800");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
