/*using UnityEngine;

// Visualises the minimum translation vectors required to separate apart from other colliders found in a given radius
// Attach to a GameObject that has a Collider attached.
[ExecuteInEditMode()]
public class enemycollider : MonoBehaviour
{
    public float radius = 3f; // show penetration into the colliders located inside a sphere of this radius
    public int maxNeighbours = 16; // maximum amount of neighbours visualised

    private Collider[] neighbours;

    public void Start()
    {
        neighbours = new Collider[maxNeighbours];
    }

    public void OnDrawGizmos()
    {
        var thisCollider = GetComponent<Collider>();

        if (!thisCollider)
            return; // nothing to do without a Collider attached

        int count = Physics.OverlapSphereNonAlloc(transform.position, radius, neighbours);

        for (int i = 0; i < count; ++i)
        {
            var collider = neighbours[i];

            if (collider == thisCollider)
                continue; // skip ourself

            Vector3 otherPosition = collider.gameObject.transform.position;
            Quaternion otherRotation = collider.gameObject.transform.rotation;

            Vector3 direction;
            float distance;

            bool overlapped = Physics.ComputePenetration(
                thisCollider, transform.position, transform.rotation,
                collider, otherPosition, otherRotation,
                out direction, out distance
            );

            // draw a line showing the depenetration direction if overlapped
            if (overlapped)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawRay(otherPosition, direction * distance);
            }
        }
    }
}

*/




































/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemycollider : MonoBehaviour
{
public Collider Col;
public float DamageAmt = 0.1f;
public bool EmitFX = false;
public ParticleSystem Particles;
public float PauseSpeed = 0.6f;
public string ParticleType = "P11";
public bool Player2 = true;
private GameObject ChosenParticles;
private void Start()
{
ChosenParticles = GameObject.Find(ParticleType);
Particles = ChosenParticles.gameObject.GetComponent<ParticleSystem>();
}
// Update is called once per frame
void Update()
{
if (Player2 == true)
{
if (Player2ActionsAI.HitsAI == false)
{
Col.enabled = true;
}
else

{
Col.enabled = false;
}
}
else
{
if (Player1Actions.Hits == false)
{
Col.enabled = true;
}
else
{
Col.enabled = false;
}
}
}
private void OnTriggerEnter(Collider other)
{
if (SaveScript.P1Reacting == false)
{
if (Player2 == true)
{
if (other.gameObject.CompareTag("neel"))
{
if (EmitFX == true)
{
Particles.Play();
Time.timeScale = PauseSpeed;
}
enemyattackAI.HitsAI = true;
SaveScript.Player1Health -= DamageAmt;
if (SaveScript.Player1Timer < 2.0f)
{
SaveScript.Player1Timer += 2.0f;

}
}
}
}
if (SaveScript.P2Reacting == false)
{
if (Player2 == false)
{
if (other.gameObject.CompareTag("Player2"))
{
if (EmitFX == true)
{
Particles.Play();
Time.timeScale = PauseSpeed;
}
Player1Actions.Hits = true;
SaveScript.Player2Health -= DamageAmt;
if (SaveScript.Player2Timer < 2.0f)
{
SaveScript.Player2Timer += 2.0f;
}
}
}
}
}
}*/
