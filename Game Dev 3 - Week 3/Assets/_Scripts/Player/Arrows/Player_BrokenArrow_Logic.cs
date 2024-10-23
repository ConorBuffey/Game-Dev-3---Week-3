using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace GameDevWithMarco.Player
{
    public class Player_BrokenArrow_Logic : MonoBehaviour
    {
        SpriteRenderer spriteRenderer;
        [SerializeField] float arrowShakeTime
        [SerializeField] float arrowShakeStrength;
        [SerializeField] float arrowFadeTime;
        // Start is called before the first frame update
        void Start()
        {
        spriteRenderer = GetComponent<SpriteRenderer>();

            StartCouroutine(ShakeTheSrrowOnCreation());
        }

        private IEnumerator ShakeTheArrowOnCreation()
        {
            if (spriteRenderer != null)
        }
    }
}
