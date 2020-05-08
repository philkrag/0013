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

public class Camera_Control : MonoBehaviour {
    
    public float Adjustment_Speed = 2.0f;
    public float Adjustment_Speed_2 = 0.5f;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (General_Events.Camera_Control_Enabled)
        {
            if (Input.GetMouseButton(1))
            {

                if (Input.GetKey("w"))
                {
                    transform.position = transform.position + Camera.main.transform.forward * Adjustment_Speed * Time.deltaTime;
                }

                if (Input.GetKey("s"))
                {
                    transform.position = transform.position + -(Camera.main.transform.forward) * Adjustment_Speed * Time.deltaTime;
                }

                if (Input.GetKey("a"))
                {
                    transform.position = transform.position + -(Camera.main.transform.right) * Adjustment_Speed * Time.deltaTime;
                }

                if (Input.GetKey("d"))
                {
                    transform.position = transform.position + Camera.main.transform.right * Adjustment_Speed * Time.deltaTime;
                }

            }
        }


    }
}
