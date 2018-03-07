using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIASalotti
{
    class NodeLaby : GenericNode
    {
        // de la forme LETTREchiffe ex : C4
        string Position;
        public NodeLaby(string newpostion) : base() 
        {
            Position = newpostion ;
        }

        public override bool IsEqual(GenericNode N2)
        {
            NodeLaby NL = (NodeLaby)(N2);
            return (NL.Position == Position);
        }

        public override bool EndState()
        {
            return (this.Position == Form1.finalPosition);
        }

        // A PARTIR DE LA, CE N'EST PAS JUSTE
        public override double GetArcCost(GenericNode N2)
        {
            // =1 si haut bas droite gauche
            // =sqt(2) si diagonale (car distance euclidienne)
            // à calculer en fonction du string Position : 1er char = colonne et reste = ligne
            return (1);
        }
        public override List<GenericNode> GetListSucc()
        {
            ;
        }
        public override double CalculeHCost()
        {
            // Calcul de l'heuristique cad distance euclidienne entre point initial et point final
            return 12;
        }
    }
}
