using System;
using System.Collections;
using System.Collections.Generic;
using Planet;
using UnityEngine;

namespace CelestialBody
{
    public class PlanetPlacer : MonoBehaviour
    {
        [SerializeField] private PlanetStats planet;

        private void Awake()
        {
            var position = this.transform.position;
            
            PlacePlanet(position);
            PlaceGravityField(position);
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
            var gravityShape = gravityFieldTemp.GetComponent<ParticleSystem>().shape;
            gravityShape.radius *= planet.GravityFieldScale;
        }
    }    
}

