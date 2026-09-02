using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChessPiece : MonoBehaviour
{
    private float gizmoSize = 0f;


    // idek
    public static string[] options = new string[] { "Pawn", "Rook", "Knight", "Bishop", "Queen", "King" };


    public void ChangePieceType(string type)
    {
        switch (type)
        {
            case "pawn":
                // Change the piece to a pawn
                gizmoSize = 2f;
                break;
            case "rook":
                gizmoSize = 8f;
                break;
            case "knight":
                // Change the piece to a knight
                gizmoSize = 4f;
                break;
            case "bishop":
                // Change the piece to a bishop
                gizmoSize = 8f;
                break;
            case "queen":
                // Change the piece to a queen
                gizmoSize = 8f;
                break;
            case "king":
                // Change the piece to a kings
                gizmoSize = 1f;
                break;
            default:
                gizmoSize = 0f;
                break;
        }
        return;
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


