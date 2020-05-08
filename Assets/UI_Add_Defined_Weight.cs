/*
// /////////////////////////////////////////////////////////////////////// COPYRIGHT NOTICE
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with Pip-Project.  If not, see <http://www.gnu.org/licenses/>.
// /////////////////////////////////////////////////////////////////////// COPYRIGHT NOTICE
// /////////////////////////////////////////////////////////////////////// VERSION CONTROL
// PAGE CREATED BY: Phillip Kraguljac
// PAGE CREATED DATE: 2019-07-20
// DATE         || NAME                 || MODIFICATION
// 2020-05-08   || Phillip Kraguljac    || Created.
// /////////////////////////////////////////////////////////////////////// VERSION CONTROL
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Add_Defined_Weight : MonoBehaviour {


    public Button yourButton;
    public GameObject Subject_Object;
    public GameObject Display_Object;
    public bool Reduce_Mass = false;
    public float Sum_Amount = 1f;


    // Use this for initialization
    void Start () {

        Button btn = yourButton.GetComponent<Button>();
        Text txt = Display_Object.GetComponent<Text>();
        btn.onClick.AddListener(TaskOnClick);

    }
	
	// Update is called once per frame
	void Update () {
		



	}

    void TaskOnClick()
    {
        if (yourButton.GetComponent<Image>().color == Color.yellow)
        {
            Subject_Object.GetComponent<Rigidbody>().WakeUp();
            Subject_Object.GetComponent<Rigidbody>().mass = Subject_Object.GetComponent<Rigidbody>().mass - Sum_Amount;
            Display_Object.GetComponent<Text>().text = Mathf.Round(Subject_Object.GetComponent<Rigidbody>().mass).ToString() + "kg";
            yourButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            Subject_Object.GetComponent<Rigidbody>().WakeUp();
            Subject_Object.GetComponent<Rigidbody>().mass = Subject_Object.GetComponent<Rigidbody>().mass + Sum_Amount;
            Display_Object.GetComponent<Text>().text = Mathf.Round(Subject_Object.GetComponent<Rigidbody>().mass).ToString() + "kg";
            yourButton.GetComponent<Image>().color = Color.yellow;
        }
    }


}
