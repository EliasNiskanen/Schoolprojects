
function aloitus() {
    document.getElementsByClassName('toka')[0].style.visibility = 'hidden';
    document.getElementsByClassName('kolmas')[0].style.visibility = 'hidden';
    document.getElementsByClassName('neljas')[0].style.visibility = 'hidden';
}
function eka() {

    if (document.getElementsByClassName('eka')[0].style.visibility = 'visible') {
        document.getElementsByClassName('eka')[0].style.visibility = 'hidden';
        document.getElementsByClassName('toka')[0].style.visibility = 'visible';
    }

}
function toka() {
    if (document.getElementsByClassName('toka')[0].style.visibility = 'visible') {
        document.getElementsByClassName('toka')[0].style.visibility = 'hidden';
        document.getElementsByClassName('kolmas')[0].style.visibility = 'visible';
    }

}
function kolmas() {
    if (document.getElementsByClassName('kolmas')[0].style.visibility = 'visible') {
        document.getElementsByClassName('kolmas')[0].style.visibility = 'hidden';
        document.getElementsByClassName('neljas')[0].style.visibility = 'visible';

    }
}
function neljas() {
    if (document.getElementsByClassName('neljas')[0].style.visibility = 'hidden') {
        document.getElementsByClassName('eka')[0].style.visibility = 'visible';
        document.getElementsByClassName('neljas')[0].style.visibility = 'hidden'
        
        return aloitus;

    }
}