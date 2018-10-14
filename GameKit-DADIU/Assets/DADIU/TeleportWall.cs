using Gamekit3D;
using UnityEngine;

namespace DADIU
{
	public class TeleportWall : MonoBehaviour
	{
		public Vector3 TeleportLandOffset;
	
		private void OnCollisionEnter(Collision other)
		{
			if (other.transform.GetComponent<TeleportBullet>() != null)
			{
				GameObjectTeleporter.Teleport(PlayerController.instance.gameObject, transform.TransformPoint( TeleportLandOffset));
				//PlayerController.instance.transform.position = transform.TransformPoint( TeleportLandOffset);
			}
		}

		private void OnDrawGizmosSelected()
		{
			Gizmos.DrawWireCube(transform.TransformPoint( TeleportLandOffset), new Vector3(1,0.1f,1));
		}
	}
}
