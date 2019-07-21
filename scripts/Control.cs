using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    public Animator Anim;
    public float WalkSpeed;
	
	// Update is called once per frame
	void Update () {

        if ( Input.GetKey( KeyCode.W ) || Input.GetKey( KeyCode.UpArrow ) )
        {

            Anim.SetBool( "Walk", true );
            transform.Translate( Vector3.forward * WalkSpeed * Time.deltaTime );

        }
        else {

            Anim.SetBool( "Walk", false );

        }

	}
}
