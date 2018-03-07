using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIASalotti
{
    class NodeLaby : GenericNode
    {
        string Name;
        public NodeLaby(string newname) : base() 
        {
            Name = newname;
        }

        public override bool IsEqual(GenericNode N2)
        {return true ; }
        public override double GetArcCost(GenericNode N2)
        { return 12; }
        public override bool EndState()
        {return true; }
        //public override List<GenericNode> GetListSucc()
        //{ ; }
        public override double CalculeHCost()
        {return 12; }
    }
}
