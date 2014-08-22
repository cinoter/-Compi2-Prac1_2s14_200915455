using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace _Compi2_Prac1_2s14_200915455
{
    interface Accion
    {
        Object do_action(ParseTreeNode pt_node);
        Object action(ParseTreeNode pt_node);
    }
}
