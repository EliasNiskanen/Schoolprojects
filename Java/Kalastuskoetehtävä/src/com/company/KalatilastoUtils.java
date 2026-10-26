package com.company;

import java.util.ArrayList;

public class KalatilastoUtils {



    public static ArrayList<Kalastaja> palautaKalastajat (String Alue, ArrayList<Kalastaja> lista){
        ArrayList<Kalastaja> Kalaalue = new ArrayList<>();
        for (Kalastaja kalastaja: lista){
            if (kalastaja.getAlue().toLowerCase().contains(Alue.toLowerCase())) {Kalaalue.add(kalastaja); }
        }

        return Kalaalue;
    }
    public static int saalisYht(ArrayList<Kalastaja> lista){
        int summa = 0;
        for (Kalastaja kalastaja : lista) {summa = kalastaja.getHaukiSaalis() + kalastaja.getKuhaSaalis();}
        return summa;
    }
}
