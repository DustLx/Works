package com.example.lab11;
import java.lang.Math;

public class Model {
    public long calculation(long a, long b, String oper) {
        return switch (oper) {
            case "+" -> a + b;
            case "-" -> a - b;
            case "×" -> a * b;
            case "÷" -> {
                if (b == 0) yield 0;
                yield Math.round((double) a/b);
            }
            case "√" -> {
                if (a < 0) yield 0;
                yield Math.round(Math.pow(a, (double) 1/b));
            }
            default -> 0;
        };
    }
}

