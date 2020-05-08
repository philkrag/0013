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

public class UI_Adjust_Rotation : MonoBehaviour {


    public Button yourButton;
    public GameObject Subject_Object;
    public GameObject Display_Object;
    public bool Reduce_Mass = false;
    public float Increment_Amount = 1f;

    
    void Start () {

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);




    }


    void Update()
    {

    }


    void TaskOnClick()
    {
        if (Reduce_Mass)
        {
            Subject_Object.GetComponent<Rigidbody>().WakeUp();
            Subject_Object.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
        }
        else
        {
            Subject_Object.GetComponent<Rigidbody>().WakeUp();
            Subject_Object.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
        }

    }

}
