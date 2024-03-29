﻿/*======= (c) Blueprint Reality Inc., 2017. All rights reserved =======*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueprintReality.MixCast
{
    public class SetActiveChildFromCameraMode : CameraComponent
    {
        private MixCastData.CameraMode lastMode;

        protected override void OnEnable()
        {
            base.OnEnable();
            HandleDataChanged();
        }
        private void Update()
        {
            if (context.Data != null && context.Data.cameraMode != lastMode)
                HandleDataChanged();
        }
        protected override void HandleDataChanged()
        {
            base.HandleDataChanged();

            MixCastData.CameraMode newMode = MixCastData.CameraMode.Immediate;
            if (context.Data != null)
                newMode = context.Data.cameraMode;

            foreach (Transform child in transform)
                child.gameObject.SetActive(false);

            foreach (Transform child in transform)
                if( child.gameObject.name == newMode.ToString() )
                    child.gameObject.SetActive(true);

            lastMode = newMode;
        }
    }
}