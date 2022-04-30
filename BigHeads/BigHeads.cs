using OWML.Common;
using OWML.ModHelper;
using System;
using UnityEngine;

namespace BigHeads
{
    public class BigHeads : ModBehaviour
    {
        Vector3 headScale = new(4, 4, 4);

        #region Unity Methods

        private void Start()
        {
            Character.modHelper = ModHelper;

            LoadManager.OnCompleteSceneLoad += (scene, loadscene) =>
            {
                if (loadscene is not OWScene.SolarSystem)
                    return;

                foreach (Character character in Character.All)
                {
                    var transform = character.GetTransform();
                    if (transform is null)
                    {
                        ModHelper.Console.WriteLine($"Failed the change headsize for {character.name}", MessageType.Error);
                        continue;
                    }
                    transform.localScale = headScale;
                }

            };
        }

        #endregion
    }
}
