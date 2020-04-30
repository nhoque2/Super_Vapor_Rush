using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //BEGIN code from (Single Sapling Games)
    //https://www.youtube.com/watch?v=o0j7PdU88a4
    //Begin edits by me (Ashton Sims)
    public double totalTime = 15; 
    public static double current = 0;
    public Text countText;
    public Text finalText;
public bool timeStop=false;
    //END Edits by me (Ashton Sims)
    // Start is called before the first frame update
    void Start()
    {
        current = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        TimeFormat();  
    }

    void TimeFormat()
    {
	if(!timeStop){
        current -= 1 * Time.deltaTime;
	}
	double finalTime=totalTime-current;
	finalText.text="Total Time: \n"+finalTime.ToString("0.0")+" seconds";
        //changed seconds to decimals
        countText.text = current.ToString("0.0")+" seconds";
        if (current <= 10.0)
        {
            countText.color = Color.red;
        } //BEGIN CODE BY ME (Ashton Sims)
        if (current <= 0.0)
        {
            current = 0.0;
            GetComponent<Rigidbody>().drag = 100;
        }
    }//END code by me (Ashton Sims)
    // END code from (Single Sapling Games)
    //https://www.youtube.com/watch?v=o0j7PdU88a4
}
