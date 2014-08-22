using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Parsing;
using Irony.Ast;

namespace _Compi2_Prac1_2s14_200915455
{
    public class Sintactic: Grammar
    {
        public Sintactic()
        {
            //terminales

          RegexBasedTerminal num = new RegexBasedTerminal("num", "[0-9]+");
            //CommentTerminal comm = new CommentTerminal("comm", "\n", "\r");

            //base.NonGrammarTerminals.Add(comm);
            RegexBasedTerminal texto = new RegexBasedTerminal("texto", "[0-9]+([0-9]|[a-z]|[A-Z])*");

            IdentifierTerminal id = new IdentifierTerminal("id");

                //StringLiteral id = new StringLiteral("id");
           


            //no terminales

            NonTerminal s0 = new NonTerminal("s0"),
                        l = new NonTerminal("l"),
                       
                        e = new NonTerminal("e");

            s0.Rule = l;

            l.Rule = l + "-" + e
               
                | e;


            e.Rule = texto
                
               | id
                |   num           ;

            this.Root = s0;

           // MarkPunctuation("-");
        }
    }
}
