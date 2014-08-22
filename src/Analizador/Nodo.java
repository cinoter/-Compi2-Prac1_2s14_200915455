/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Analizador;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author CINOTER
 */
public class Nodo {
     public String valor;
    public List<Nodo> hijos;

    public Nodo(String valor) {
        this.valor = valor;
        hijos = new ArrayList<Nodo>();
    }
}
