using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaprogramacion_1
{
    class Vector
    {
        private Punto origen;
        private Punto fin;
        private double magnitud;

        public Vector()
        {
            origen = new Punto(0, 0);
            fin = new Punto(1, 1);
            calcular_magnitud();
        }
        public Vector(Punto _origen, Punto _fin)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }

        public Vector(float x_origen, float y_origen, float x_fin, float y_fin)
        {
            origen = new Punto(x_origen, y_origen);
            fin = new Punto(x_fin, y_fin);
            calcular_magnitud();
        }

        private void calcular_magnitud()
        {
            magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()), 2) + Math.Pow((fin.GetY() - origen.GetY()), 2));
        }
        public double get_magnitud()
        {
            return magnitud;
        }


        public void set_origen(Punto _origen)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            calcular_magnitud();
        }

        public void set_origen(double x, double y)
        {
            origen = new Punto(x, y);
            calcular_magnitud();
        }

        public void set_fin(Punto _fin)
        {
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }



        public void set_fin(double x, double y)
        {
            fin = new Punto(x, y);
            calcular_magnitud();
        } 


        public static Vector operator +(Vector sumando1, Vector sumando2)
        {
            Punto nuevo_origen = new Punto(sumando1.origen.GetX() + sumando2.origen.GetX(), sumando1.origen.GetY() + sumando2.origen.GetY());

            Punto nuevo_fin = new Punto(sumando1.fin.GetX() + sumando2.fin.GetX(), sumando1.fin.GetY() + sumando2.fin.GetY());


            return new Vector(nuevo_origen, nuevo_fin);
        }

        public static Vector operator -(Vector restando1, Vector restando2)
        {
            Punto nuevo_origen = new Punto(restando1.origen.GetX() - restando2.origen.GetX(), restando1.origen.GetY() - restando2.origen.GetY());

            Punto nuevo_fin = new Punto(restando1.fin.GetX() - restando2.fin.GetX(), restando1.fin.GetY() - restando2.fin.GetY());


            return new Vector(nuevo_origen, nuevo_fin);
        }

        public static double operator *(Vector producto1, Vector producto2)
        {
            double suma_final;
            double x_1 = producto1.fin.GetX() - producto1.origen.GetX();
            double x_2 = producto2.fin.GetX() - producto2.origen.GetX();
            double producto_x = x_1 * x_2;

            double y_1 = producto1.fin.GetY() - producto1.origen.GetY();
            double y_2 = producto2.fin.GetY() - producto2.origen.GetY();
            double producto_y = y_1 * y_2;

            suma_final = producto_x + producto_y;

            return suma_final;

        }

        public static Vector operator *(Vector producto, double valor)
        {

            Punto origen = new Punto(producto.origen.GetX() * valor, producto.origen.GetY() * valor);
            Punto fin = new Punto(producto.fin.GetX() * valor, producto.fin.GetY() * valor);


            return new Vector(origen, fin);
        }
    }
}
