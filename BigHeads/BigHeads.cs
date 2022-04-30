using OWML.Common;
using OWML.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BigHeads
{
    public class BigHeads : ModBehaviour
    {
        float headScale = 3f;
        Vector3 headScaleVector;

        Transform[] headTransforms;

        #region OWML Methods

        public override void Configure(IModConfig config)
        {
            Single.TryParse(config.GetSettingsValue<string>("headMultiplier"), out headScale);
            ModHelper.Console.WriteLine("Applying settings...", MessageType.Info);
            BigifyHeads();
        }

        #endregion

        #region Unity Methods

        private void Start()
        {
            LoadManager.OnCompleteSceneLoad += (scene, loadscene) => BigifyHeads();
        }

        #endregion

        private void BigifyHeads()
        {
            headScaleVector = new(headScale, headScale, headScale);

            ModHelper.Console.WriteLine($"Searching for heads in scene: '{LoadManager.s_currentScene.ToString()}'", MessageType.Info);
            headTransforms = GetHeads();
            ModHelper.Console.WriteLine($"Found {headTransforms.Length} heads.", MessageType.Info);

            foreach (Transform transform in headTransforms)
            {
                try
                {
                    transform.localScale = headScaleVector;
                }
                catch (UnityException)
                {
                    ModHelper.Console.WriteLine($"Failed to set scale for head with bone: '{transform.name}'");
                }
            }
        }

        private Transform[] GetHeads()
        {
            // This could be pretty intensive, so best to only call it sparingly.

            List<Transform> ANIMs = new List<Transform>();
            List<Transform> heads = new List<Transform>();

            GameObject[] gameObjects = Resources.FindObjectsOfTypeAll<GameObject>();

            // Search for objects that have an ANIM child
            foreach (GameObject gameObject in gameObjects)
            {
                int numChildren = gameObject.transform.childCount;
                for (int i = 0; i < numChildren; i++)
                {
                    Transform child = gameObject.transform.GetChild(i);
                    if (child.name.Contains("_ANIM")) ANIMs.Add(child);
                }
            }

            foreach (Transform ANIM in ANIMs)
            {
                Transform head = FindHead(ANIM);

                if (head is not null)
                    heads.Add(head);
            }

            return heads.ToArray();

            //Recursive method
            Transform FindHead(Transform origin)
            {
                for (int i = 0; i < origin.childCount; i++)
                {
                    Transform child = origin.GetChild(i);
                    Transform head = FindHead(child);
                    if (head is not null) return head;
                    else if (child.name.ToLower().Contains("neck")) return child;
                }

                return null;
            }
        }
    }
}
