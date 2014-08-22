/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Core;

/**
 *
 * @author CINOTER
 */
public class Variable {
    
    protected String Id;
    protected String Tipo;
    protected Object Valor;

    public Variable(String Id, String Tipo, String Valor) {
        this.Id = Id;
        this.Tipo = Tipo;
        this.Valor = Valor;
    }

    public String getId() {
        return Id;
    }

    public String getTipo() {
        return Tipo;
    }

    public Object getValor() {
        return Valor;
    }

    public void setId(String Id) {
        this.Id = Id;
    }

    public void setTipo(String Tipo) {
        this.Tipo = Tipo;
    }

    public void setValor(Object Valor) {
        this.Valor = Valor;
    }
    
    
    
    
}
