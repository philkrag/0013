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

public class General_Events : MonoBehaviour
{

    public int Internal_Storyline_Index = 0;

    public GameObject Display_Object;

    public GameObject Label_1;
    public GameObject Label_2;
    public GameObject Label_3;
    public GameObject Object_1;
    public GameObject Object_2;
    public GameObject Object_3;


    public static string Current_Control_Group = "";
    public static bool Camera_Look_Enabled = true;
    public static bool Camera_Control_Enabled = true;

    Rigidbody temp;

    
    void Start()
    {

        Label_1.GetComponent<Text>().text = Mathf.Round(Object_1.GetComponent<Rigidbody>().mass).ToString() + "kg";
        Label_2.GetComponent<Text>().text = Mathf.Round(Object_2.GetComponent<Rigidbody>().mass).ToString() + "kg";
        Label_3.GetComponent<Text>().text = Mathf.Round(Object_3.GetComponent<Rigidbody>().mass).ToString() + "kg";
    }


    void Update()
    {
        switch (Internal_Storyline_Index)
        {
            case 0:
                Internal_Storyline_Index = 1;
                break;
        }
        
    }

}






