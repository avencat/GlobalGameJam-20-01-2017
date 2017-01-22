using System;
using UnityEngine;
using System.Collections;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 0f, 0f);
		public float max = 0f;
		public float speed = 0.4f;

        private void LateUpdate()
        {
			if ((Input.GetKey ("space") || Input.touchCount > 0) && target.position.y < 19f) {
				offset.y = speed;
				max = 0f;
			} else if (target.position.y > -(max) && max != 0f && !Input.GetKey ("space") && Input.touchCount == 0) {
				offset.y = -speed;
			} else if (target.position.y < 0f) {
				if (target.position.y + speed > 0f) {
					offset.y = -target.position.y;
				} else {
					offset.y = speed;
				}
			} else {
				offset.y = 0f;
			}  
            transform.position = target.position + offset;
			if (target.position.y > 0f && target.position.y > max) {
				max = target.position.y;
			} else if (max > 0f && target.position.y <= -(max)) {
				max = 0f;
			}
        }
    }
}
