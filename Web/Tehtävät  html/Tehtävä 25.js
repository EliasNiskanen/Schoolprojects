
function Laskeika() {

    var ika;
    var syntyma = new Date();
    var tanaan = new Date();
    var spv;
    var tpv;
    if (document.getElementById('pv').value > 31 || document.getElementById('pv').value < 1) {
        document.getElementById('pv').value = 31;
    }
    if (document.getElementById('kk').value > 12 || document.getElementById('kk').value < 1) {
        document.getElementById('kk').value = 12;
    }
    if (document.getElementById('vuosi').value > tanaan.getFullYear() || document.getElementById('vuosi').value < 1900) {
        document.getElementById('vuosi').value = tanaan.getFullYear();
    }

    var nimi = document.getElementById('nimi').value;
    var spv = document.getElementById('pv').value;
    var skk = document.getElementById('kk').value;
    var svuosi = document.getElementById('vuosi').value;
    syntyma = spv + '/' + skk + '/' + svuosi;

    var tpv = String(tanaan.getDate()).padStart(2, '0');
    var tkk = String(tanaan.getMonth() + 1).padStart(2, '0');
    var tvuosi = tanaan.getFullYear();
    tanaan = tpv + '/' + tkk + '/' + tvuosi;

    var today = syntyma;
    today = new Date(today.split('/')[2], today.split('/')[1] - 1, today.split('/')[0]);
    var date2 = tanaan;
    date2 = new Date(date2.split('/')[2], date2.split('/')[1] - 1, date2.split('/')[0]);
    var timeDiff = Math.abs(date2.getTime() - today.getTime());
    ika = Math.ceil(timeDiff / (1000 * 3600 * 24)) / 365;

    let h1 = document.getElementsByTagName('h1')[0];
    h1.innerHTML = "Hei " + nimi + ", olet " + Math.trunc(ika) + " vuotta vanha";
}