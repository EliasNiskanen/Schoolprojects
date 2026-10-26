function kysynimi() {

    var nimi = prompt("Kerro sinun nimesi? ");
    console.log("Otsikoksi muutettiin: " + nimi);
    let h1 = document.getElementsByTagName('h1')[0];
    h1.innerHTML = nimi.toUpperCase();
}