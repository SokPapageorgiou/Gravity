using System;
using System.Collections;
using System.Collections.Generic;
using GravityField;
using Planet;
using UnityEngine;

namespace CelestialBody
{
    [RequireComponent(typeof(MeshRenderer))]
    public class PlanetPlacer : MonoBehaviour
    {
        [SerializeField] private PlanetStats planet;

        private void Awake()
        {
            DisableMeshRenderer();
            
            var position = this.transform.position;
            
            PlacePlanet(position);
            PlaceGravityField(position);
        }

        private void DisableMeshRenderer()
        {
            GetComponent<MeshRenderer>().enabled = false;
        }

        private void PlacePlanet(Vector3 position)
        {
            var planetTemp = Instantiate(planet.planet);
            planetTemp.transform.position = position;
            planetTemp.transform.localScale *= planet.Scale;
        }

        private void PlaceGravityField(Vector3 position)
        {
            var gravityFieldTemp = Instantiate(planet.gravityField);
            gravityFieldTemp.transform.position = position;
            gravityFieldTemp.GetComponent<SphereCollider>().radius *= planet.GravityFieldScale;
            gravityFieldTemp.GetComponent<Puller>().Mass = planet.Mass;
            var gravityShape = gravityFieldTemp.GetComponent<ParticleSystem>().shape;
            gravityShape.radius *= planet.GravityFieldScale;
        }
    }    
}

