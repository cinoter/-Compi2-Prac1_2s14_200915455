/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Analizador;

/**
 *
 * @author CINOTER
 */
public class Errores {
     protected int Linea;
    protected int Columna;
    protected String Descripcion;

    public Errores(int Linea, int Columna, String Descripcion) {
        this.Linea = Linea;
        this.Columna = Columna;
        this.Descripcion = Descripcion;
    }
    
    

    public int getLinea() {
        return Linea;
    }

    public int getColumna() {
        return Columna;
    }

    public String getDescripcion() {
        return Descripcion;
    }

    public void setLinea(int Linea) {
        this.Linea = Linea;
    }

    public void setColumna(int Columna) {
        this.Columna = Columna;
    }

    public void setDescripcion(String Descripcion) {
        this.Descripcion = Descripcion;
    }

}
