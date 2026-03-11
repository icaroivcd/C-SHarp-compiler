using System;

public struct Ponto {
    public int x;
    public int y;
}

public struct Triangulo {
    public Ponto a, b, c;
    public int cor;
}

public class Programa {
    public static double Func(Ponto[] v, int n, Triangulo T) {
        if (n <= 0) {
            return 1.0; 
        } else if (n == 1) {
            return 1.01 + v[0].x / 1.0e2 + v[0].y / 0.1e-2 - T.a.x * T.a.x + T.b.y * T.c.x;
        }
        double res = 0.25e-13;
        for (int i = n - 1; i >= 0 && v[i].x > 0; --i) {
            double temp = v[i].y * v[i].x % 123;
            if (temp < 0.0) {
                res -= res * 2.0e-2 + Func(v, n - 1, T) * temp - T.a.y * T.cor;
            } else {
                res += res * 0.3e3 + Func(v, n - 2, T) * temp + T.c.x * T.cor;
                Console.WriteLine("Estranho, ne?");
            }
        }
        return res;
    }

    public static int F2(Triangulo T) {
        int A = 0;
        double[] soma = new double[10];
        if ((T.a.x >= 10 || T.b.y > 20 || T.a.y < 30 || T.b.x <= 50) && !(T.c.x != 90 || T.c.y == 0)) {
            return 10 % 3;
        } else {
            A = 1;
        }
        while (A < 10) {
            int total = 0;
            total += T.c.x * T.c.y;
            total += T.b.x * T.a.y;
            total += T.a.x * T.b.y;
            soma[A] = total % 100;
            A = A + 1;
        }
        return 0;
    }
}