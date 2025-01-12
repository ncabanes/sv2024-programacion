/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 132. Implementación aproximada Juego Ghost Goblins.
 * 
 * Implementa las clases que has diseñado en tu diagrama.
 * 
 * Todavía no habrá detalles avanzados que veremos más adelante, como herencias
 * o agregaciones. Aparecerán los nombres de los métodos, pero éstos estarán
 * vacíos.
 * 
 * Deberás entregar, comprimido en ZIP, todo el proyecto de Visual Studio (un
 * fichero para cada clase), que debe compilar correctamente aunque "no haga
 * nada útil". */
 
using System;

class Juego {

    static void Main() {


    }
}

// ----------------------------

class Bienvenida {

    public void Iniciar() { 
    
        
    }

}

// ----------------------------

class Partida {

    public void IniciarEscenario() { 
        
    
    }
}

// ----------------------------

class Sprite {


}

// ----------------------------

class Personaje {

    private int x, y;
    public void MoverIzquierda() {
        x--;
    }

    public void MoverDerecha() {
        x++;
    }

    public void Saltar() {

    }

    public void MoverArriba() {
        y++;
    }

    public void MoverAbajo() {
        y--;
    }

    public void Disparar() { 
    
    }

    public void PerderArmadura() { 
    
    }

    public void PerderVida() { 
    
    }

}

// ----------------------------

class Enemigo {

    private int x;
    private bool eliminado = false;

    public void MoverIzquierda() {
        x--;
    }

    public void MoverDerecha() {
        x++;
    }

    public void Disparar() { 
    
    }

    public void Eliminar() {
        eliminado = true;
    }

}

// ----------------------------

class Disparo {

    public void Disparar() { 
        

    
    }

}

// ----------------------------

class Marcador {

    public void IniciarMarcador() { 

    
    }

}

// ----------------------------
