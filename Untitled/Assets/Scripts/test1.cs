using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class test1 : MonoBehaviour {
public Button btn1;
public Button btn2;
public Button btn3;
public Button btn4;
public static bool isShow = false;
public static bool isClose = false;

	
	/// <summary>
	/// OnGUI is called for rendering and handling GUI events.
	/// This function can be called multiple times per frame (one call per event).
	/// </summary>
	void OnGUI()
	{
		
		if (isShow)
		{
			if (btn1.transform.position.y < this.gameObject.transform.position.y + 60)
			{
			 btn1.transform.position = new Vector3(btn1.transform.position.x,btn1.transform.position.y + Time.deltaTime *500,0);

			   
			}

			if (btn2.transform.position.y < this.gameObject.transform.position.y + 120)
			{
			 btn2.transform.position = new Vector3(btn2.transform.position.x,btn2.transform.position.y + Time.deltaTime *500,0);

			   
			}

			if (btn3.transform.position.y < this.gameObject.transform.position.y + 180)
			{
			 btn3.transform.position = new Vector3(btn3.transform.position.x,btn3.transform.position.y + Time.deltaTime *500,0);

			   
			}

			if (btn4.transform.position.y < this.gameObject.transform.position.y + 240)
			{
			 btn4.transform.position = new Vector3(btn4.transform.position.x,btn4.transform.position.y + Time.deltaTime *500,0);

			   
			}else
			{
				
				isShow = false;
				Debug.Log(isShow.ToString());
			}

			
		}

		if (isClose)
		{
			if (btn1.transform.position.y  > this.gameObject.transform.position.y)
			{
			 btn1.transform.position = new Vector3(btn1.transform.position.x,btn1.transform.position.y - Time.deltaTime *500,0);

			   
			}else
			{
				 btn1.transform.position = this.gameObject.transform.position;
			}

			if (btn2.transform.position.y > this.gameObject.transform.position.y)
			{
			 btn2.transform.position = new Vector3(btn2.transform.position.x,btn2.transform.position.y - Time.deltaTime *500,0);

			   
			}
			else
			{
				 btn2.transform.position = this.gameObject.transform.position;
			}

			if (btn3.transform.position.y > this.gameObject.transform.position.y)
			{
			 btn3.transform.position = new Vector3(btn3.transform.position.x,btn3.transform.position.y - Time.deltaTime *500,0);

			   
			}else
			{
				 btn3.transform.position = this.gameObject.transform.position;
			}

			if (btn4.transform.position.y  > this.gameObject.transform.position.y)
			{
			 btn4.transform.position = new Vector3(btn4.transform.position.x,btn4.transform.position.y - Time.deltaTime *500,0);

			   
			}else
			{
				 btn4.transform.position = this.gameObject.transform.position;
					isClose = false;
			}
			
		}


	}	
}
