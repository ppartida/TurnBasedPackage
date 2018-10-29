﻿using UnityEngine;

namespace TurnBasedPackage
{
    public class ColorComponent : MonoBehaviour
    {
        [SerializeField]
        public ColorThreshHold[] colorThreshHoldList;
        private SpriteRenderer SpriteRenderer;
        private Vector3 originalSize;
        private void Start()
        {
            SpriteRenderer = GetComponent<SpriteRenderer>();
            originalSize = transform.localScale;
        }
        public void UpdateValue(float percentValue)
        {
            foreach (ColorThreshHold colorThreshHold in colorThreshHoldList)
            {
                if (percentValue >= colorThreshHold.threshhold/100f)
                {
                    SpriteRenderer.color = colorThreshHold.color;
                    break;
                }
            }
            //TODO: Slow animate.
            transform.localScale = new Vector3(percentValue * originalSize.x, originalSize.y, originalSize.z);
        }
    }
}
