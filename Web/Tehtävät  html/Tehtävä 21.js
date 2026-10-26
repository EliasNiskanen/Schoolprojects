
function laske(sade) {
    var r; var V;

    r = document.getElementById('sade').value;
    V = (4 / 3) * Math.PI * Math.pow(r, 3);
    console.log(V.toFixed(2) + " tilavuusyksikköä");

}
