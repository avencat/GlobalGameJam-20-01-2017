using System;
using UnityEngine;
using System.Collections;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        Vector3 offset = new Vector3(0f, 0f, 0f);
		float speed = 0.4f;
		float max = 0f;
		float min = 0f;
		bool up = false;
		bool down = false;

        private void LateUpdate()
        {
			for (var i = 0; i < Input.touchCount; ++i) {
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began) {
					if (touch.position.y > (Screen.height / 2)) {
						print ("up");
						up = true;
					} else if (touch.position.y < (Screen.height / 2)) {
						print ("down");
						down = true;
					}
				} else if (touch.phase == TouchPhase.Ended) {
					if (touch.position.y > (Screen.height / 2)) {
						print ("!up");
						up = false;
					} else if (touch.position.y < (Screen.height / 2)) {
						print ("!down");
						down = false;
					}
				}
			}
			if (((Input.GetKey ("space") || Input.GetKey("up") || (up))) || (min != 0f && target.position.y < -(min) && !Input.GetKey("down") && !down)) {
				if (target.position.y < 19f)
					offset.y = speed;
				else
					offset.y = 0f;
				max = 0f;
			} else if ((target.position.y > -(max) && max != 0f) || (Input.GetKey("down") || down)) {
				if (target.position.y > -19f)
					offset.y = -speed;
				else
					offset.y = 0f;
				min = 0f;
			} else if (target.position.y < 0f) {
				if (target.position.y + speed > 0f) {
					offset.y = -target.position.y;
				} else {
					offset.y = speed;
				}
			} else if (target.position.y > 0f) {
				if (target.position.y + speed < 0f) {
					offset.y = target.position.y;
				} else {
					offset.y = -speed;
				}
			} else {
				offset.y = 0f;
			}  
            transform.position = target.position + offset;
			if (target.position.y > 0f && target.position.y > max && (Input.GetKey ("space") || Input.GetKey("up") || up)) {
				max = target.position.y;
			} else if (max > 0f && target.position.y <= -(max - (speed - 0.1f))) {
				max = 0f;
			} else if (target.position.y < 0f && target.position.y < min && (Input.GetKey("down") || down)) {
				min = target.position.y;
			} else if (min < 0f && target.position.y >= -(min + (speed - 0.1f))) {
				min = 0f;
			}
        }
    }
}
