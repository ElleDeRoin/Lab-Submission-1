using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChessPiece : MonoBehaviour
{
    public enum options { Pawn, Rook, Knight, Bishop, Queen, King };
    public options currentOption = options.Pawn;

    int gizmoSize = 1;

    private void OnDrawGizmos()
    {

        switch (currentOption)
        {
            case options.Pawn:
                Gizmos.DrawIcon(transform.position, "Chess_pawn.png");
                gizmoSize = 2;
                break;
            case options.Rook:
                Gizmos.DrawIcon(transform.position, "Chess_rook.png");
                gizmoSize = 8;
                break;
            case options.Knight:
                Gizmos.DrawIcon(transform.position, "Chess_knight.png");
                gizmoSize = 4;
                break;
            case options.Bishop:
                Gizmos.DrawIcon(transform.position, "Chess_bishop.png");
                gizmoSize = 8;
                break;
            case options.Queen:
                Gizmos.DrawIcon(transform.position, "Chess_queen.png");
                gizmoSize = 8;
                break;
            case options.King:
                Gizmos.DrawIcon(transform.position, "Chess_king.png");
                gizmoSize = 1;
                break;
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;

        switch (currentOption)
        {
            case options.Pawn:
                Gizmos.DrawWireSphere(transform.position, 0.5f);
                break;
            case options.Rook:
                Gizmos.DrawWireSphere(transform.position, 0.5f);
                break;
            case options.Knight:
                Gizmos.DrawWireSphere(transform.position, 0.5f);
                break;
            case options.Bishop:
                Gizmos.DrawWireSphere(transform.position, 0.5f);
                break;
            case options.Queen:
                Gizmos.DrawWireSphere(transform.position, 0.5f);
                break;
            case options.King:
                Gizmos.DrawWireSphere(transform.position, 0.5f);
                break;
        }

        Gizmos.color = Color.yellow;
        Vector3 forwardDirection = Vector3.up * gizmoSize;
        Vector3 rightDirection = Vector3.right * gizmoSize;
        Vector3 leftDirection = Vector3.left * gizmoSize;
        Vector3 backDirection = Vector3.down * gizmoSize;


        Gizmos.DrawLine(transform.position, forwardDirection);
        Gizmos.DrawLine(transform.position, rightDirection);
        Gizmos.DrawLine(transform.position, leftDirection);
        Gizmos.DrawLine(transform.position, backDirection);

    }

    
}
