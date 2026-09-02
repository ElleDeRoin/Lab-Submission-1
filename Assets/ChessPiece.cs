using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChessPiece : MonoBehaviour
{
    public enum options { Pawn, Rook, Knight, Bishop, Queen, King };
    public options currentOption = options.Pawn;



    private void OnDrawGizmos()
    {
        switch (currentOption)
        {
            case options.Pawn:
                Gizmos.DrawIcon(transform.position, "Chess_pawn.png");
                break;
            case options.Rook:
                Gizmos.DrawIcon(transform.position, "Chess_rook.png");
                break;
            case options.Knight:
                Gizmos.DrawIcon(transform.position, "Chess_knight.png");
                break;
            case options.Bishop:
                Gizmos.DrawIcon(transform.position, "Chess_bishop.png");
                break;
            case options.Queen:
                Gizmos.DrawIcon(transform.position, "Chess_queen.png");
                break;
            case options.King:
                Gizmos.DrawIcon(transform.position, "Chess_king.png");
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
                Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 1));
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


    }



    private void OnDrawGizmos()
    {
        ChangePieceType(pieceType);

        Gizmos.color = Color.yellow;
        Vector3 forwardDirection = Vector3.up * gizmoSize;
        Vector3 rightDirection = Vector3.right * gizmoSize;
        Vector3 leftDirection = Vector3.left * gizmoSize;
        Vector3 backDirection = Vector3.down * gizmoSize;


        Gizmos.DrawLine(transform.position, forwardDirection);
        Gizmos.DrawLine(transform.position, rightDirection);
        Gizmos.DrawLine(transform.position, leftDirection);
        Gizmos.DrawLine(transform.position, backDirection);

        // cam do diagonals


    }

    
}
