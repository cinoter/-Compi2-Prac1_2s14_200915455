using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;
using System.Windows.Forms;


namespace _Compi2_Prac1_2s14_200915455
{
    class AccionesCalcu : Accion
    {
        public Object do_action(ParseTreeNode pt_node) {
            return action(pt_node);
        }

        public Object action(ParseTreeNode node) {
            Object result = null;
            switch(node.Term.Name.ToString()){
                case "s0": {
                    if (node.ChildNodes.Count == 1)
                    {
                        result = action(node.ChildNodes[0]);
                    }
                    break;
                }
                case "l": {
                    if (node.ChildNodes.Count == 1)
                    {
                        result = action(node.ChildNodes[0]);
                    }
                    else if (node.ChildNodes.Count == 3)
                    {
                        String op1 = action(node.ChildNodes[0]).ToString();
                        String op2 = action(node.ChildNodes[2]).ToString();
                        
                            result = op1.ToString() + "==" + op2.ToString();
                       
                        
                    }
                    
                    break;
                }
               
                case "e": {
                    
                    if (node.ChildNodes.Count == 1) {
                        result = action(node.ChildNodes[0]);
                    }
                    
                    break;
                }
                case "num": {
                    Form1.ListaNumeros.Add(Convert.ToInt32(node.Token.Value));
                    Form1.Total_Num++;
                    result = node.Token.ValueString;
                    break;
                }
                case "id":
                    {
                        Form1.ListaPalabras.Add(node.Token.ValueString);
                        Form1.Total_Palab++;
                        result = node.Token.ValueString;
                        break;
                    }
                case "texto":
                    {
                        Form1.ListaPalabras.Add(node.Token.ValueString);
                        Form1.Total_Palab++;
                        result = node.Token.ValueString;
                        break;
                    }
            }
            return result;
        }
    }
}
