using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesion11Corutinas : MonoBehaviour
{
    //threadss
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(ShowMessagesByTime());
        /// StartCoroutine(WhileAdd());
         StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        int CurrentCount = 3;
        Debug.Log(" Beep +" + CurrentCount);
        yield return new WaitForSeconds(1);
        CurrentCount--;
        Debug.Log(" Beep +" + CurrentCount);
        yield return new WaitForSeconds(1);
        CurrentCount--;
        Debug.Log(" Beep +" + CurrentCount);
        yield return new WaitForSeconds(1);
        Debug.Log(" GO ");
        //Lanzo evento OnGameStateChange?.Invoke(GameBegin);
        //tweens
    }
    void LoadStall()
    {
        float temp=0;
        while(temp<10001)
        {
            temp++;
        }
    }

    IEnumerator ShowMessagesByTime()
    {

        Debug.Log("First Message");
        yield return new WaitForSeconds(1);
        Debug.Log("this is after 1 second");
        yield return new WaitForSeconds(1);
        Debug.Log("this is after 2 seconds");

    }

    IEnumerator LoadWhileAsync()
    {
        while(true)
        {
            float waitTime = Random.Range(0.1f, .4f);
            yield return new WaitForSeconds(waitTime);
            Debug.Log("{wait times is "+ waitTime);

        }
    }
    IEnumerator WhileAdd()
    {
        float waitTime = 0;
        while (true)
        {
            waitTime += Time.deltaTime;
              yield return new WaitForEndOfFrame();

            Debug.Log("WhileAdd is " + waitTime);
            if (waitTime>3)
            {
                yield break;
            }

        }
    }
    
}
