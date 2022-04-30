using OWML.Common;
using OWML.ModHelper;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace BigHeads
{
    public class BigHeads : ModBehaviour
    {
        float headScale = 3f;
        Vector3 headScaleVector;

        #region Unity Methods

        private void Start()
        {
            LoadManager.OnCompleteSceneLoad += (scene, loadscene) =>
            {
                if (loadscene is OWScene.SolarSystem) Initialise();
            };
        }

        #endregion

        private void Initialise()
        {
            headScaleVector = new Vector3(headScale, headScale, headScale);

            if (Character.modHelper is null)
                Character.modHelper = ModHelper;

            foreach (Character character in Character.All)
            {
                var transform = character.GetTransform();
                if (transform is null)
                {
                    ModHelper.Console.WriteLine($"Failed to patch headsize for {character.name}", MessageType.Error);
                    continue;
                }
                transform.localScale = headScaleVector;
                //ModHelper.Console.WriteLine($"Successfully patched headsize for {character.name}", MessageType.Success);
                //Don't want to spam the console
            }
        }
    }
}
