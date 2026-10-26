function fibonacci(parametri) {
    let luku1 = 0, luku2 = 1, rivi, summa;
    rivi = parametri;
    console.log(rivi);
    while (rivi > 0) {
        summa = luku1 + luku2;
        console.log(luku1 + " + " + luku2 + " = " + summa);
        luku1 = luku2;
        luku2 = summa;
        rivi--;
    }
}