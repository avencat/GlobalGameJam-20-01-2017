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

        private void LateUpdate()
        {
			if (Input.GetKey ("space") && target.position.y < 20f) {
				offset.y = 1f;
				max = 0f;
			} else if (target.position.y > -max && max != 0f) {
				print ("max" +  max);
				offset.y = -1f;
			} else if (target.position.y < 0f) {
				offset.y = 1f;
			} else {
				offset.y = 0f;
			}  
            transform.position = target.position + offset;
			if (target.position.y > 0f && target.position.y > max) {
				max = target.position.y;
			} else if (max > 0f && target.position.y == -max) {
				max = 0f;
			}
        }
    }
}
