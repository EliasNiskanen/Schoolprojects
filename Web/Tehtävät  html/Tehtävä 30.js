var a = [];
var score = 0;

$(document).ready(function () {
    raffle();
});
//Numbers to divs
function raffle() {
    while (a.length < 15) {
        var i = Math.floor(Math.random() * 15) + 1;
        if (a.indexOf(i) === -1) a.push(i);
    }
    var i = 0; var y = 1;
    while (i < 15) {
        var number = a[i];
        var div = document.getElementById('div' + y);
        div.innerHTML = number;
        i++; y++;
    }
    colors();
}
//Evry other row to red / white
function colors() {
    var i = 1;
    while (i < 17) {
        if (
            document.getElementById('div' + i).innerHTML == "1" ||
            document.getElementById('div' + i).innerHTML == "2" ||
            document.getElementById('div' + i).innerHTML == "3" ||
            document.getElementById('div' + i).innerHTML == "4" ||
            document.getElementById('div' + i).innerHTML == "9" ||
            document.getElementById('div' + i).innerHTML == "10" ||
            document.getElementById('div' + i).innerHTML == "11" ||
            document.getElementById('div' + i).innerHTML == "12"
        ) {
            document.getElementById('div' + i).style.backgroundColor = "red";
            document.getElementById('div' + i).style.color = "white";
        }
        else {
            document.getElementById('div' + i).style.backgroundColor = "white";
            document.getElementById('div' + i).style.color = "black";
        }
        i++;
    }
}
//is the game done?
function endgame() {
    if (document.getElementById('div1').innerHTML == "1"
        && document.getElementById('div2').innerHTML == "2"
        && document.getElementById('div3').innerHTML == "3"
        && document.getElementById('div4').innerHTML == "4"
        && document.getElementById('div5').innerHTML == "5"
        && document.getElementById('div6').innerHTML == "6"
        && document.getElementById('div7').innerHTML == "7"
        && document.getElementById('div8').innerHTML == "8"
        && document.getElementById('div9').innerHTML == "9"
        && document.getElementById('div10').innerHTML == "10"
        && document.getElementById('div11').innerHTML == "11"
        && document.getElementById('div12').innerHTML == "12"
        && document.getElementById('div13').innerHTML == "13"
        && document.getElementById('div14').innerHTML == "14"
        && document.getElementById('div15').innerHTML == "15"
        && document.getElementById('div16').innerHTML == "") {
        alert("it took " + score + " moves to solve the puzzle, click ok to play again");
        location.reload();
    }
}
//Suffel the divs (reload the page)
$(function () {
    $(document).on('click', '#suffel', function () {
        location.reload();
    });
});
//if wrong div is clicked
function error() {
    alert("Et voi valita tätä numeroa, koitappa uudelleen!");
}
//Counts how may moves have been made
function counter() {
    score++;
    console.log("Moves: " + score);
    document.getElementById('moves').innerHTML = score + " moves";
}
//Div clicks.
$(document).on('click', '#div1', function () {
    if (document.getElementById('div2').innerHTML === "") {
        document.getElementById('div2').innerHTML = document.getElementById('div1').innerHTML;
        document.getElementById('div1').innerHTML = ""
        counter();

    }
    else if (document.getElementById('div5').innerHTML === "") {
        document.getElementById('div5').innerHTML = document.getElementById('div1').innerHTML;
        document.getElementById('div1').innerHTML = ""
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div2', function () {
    if (document.getElementById('div1').innerHTML === "") {
        document.getElementById('div1').innerHTML = document.getElementById('div2').innerHTML;
        document.getElementById('div2').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div3').innerHTML === "") {
        document.getElementById('div3').innerHTML = document.getElementById('div2').innerHTML;
        document.getElementById('div2').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div6').innerHTML === "") {
        document.getElementById('div6').innerHTML = document.getElementById('div2').innerHTML;
        document.getElementById('div2').innerHTML = ""
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div3', function () {
    if (document.getElementById('div2').innerHTML === "") {
        document.getElementById('div2').innerHTML = document.getElementById('div3').innerHTML;
        document.getElementById('div3').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div4').innerHTML === "") {
        document.getElementById('div4').innerHTML = document.getElementById('div3').innerHTML;
        document.getElementById('div3').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div7').innerHTML === "") {
        document.getElementById('div7').innerHTML = document.getElementById('div3').innerHTML;
        document.getElementById('div3').innerHTML = ""
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div4', function () {
    if (document.getElementById('div3').innerHTML === "") {
        document.getElementById('div3').innerHTML = document.getElementById('div4').innerHTML;
        document.getElementById('div4').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div8').innerHTML === "") {
        document.getElementById('div8').innerHTML = document.getElementById('div4').innerHTML;
        document.getElementById('div4').innerHTML = ""
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div5', function () {
    if (document.getElementById('div1').innerHTML === "") {
        document.getElementById('div1').innerHTML = document.getElementById('div5').innerHTML;
        document.getElementById('div5').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div6').innerHTML === "") {
        document.getElementById('div6').innerHTML = document.getElementById('div5').innerHTML;
        document.getElementById('div5').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div9').innerHTML === "") {
        document.getElementById('div9').innerHTML = document.getElementById('div5').innerHTML;
        document.getElementById('div5').innerHTML = ""
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div6', function () {
    if (document.getElementById('div2').innerHTML === "") {
        document.getElementById('div2').innerHTML = document.getElementById('div6').innerHTML;
        document.getElementById('div6').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div5').innerHTML === "") {
        document.getElementById('div5').innerHTML = document.getElementById('div6').innerHTML;
        document.getElementById('div6').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div7').innerHTML === "") {
        document.getElementById('div7').innerHTML = document.getElementById('div6').innerHTML;
        document.getElementById('div6').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div10').innerHTML === "") {
        document.getElementById('div10').innerHTML = document.getElementById('div6').innerHTML;
        document.getElementById('div6').innerHTML = ""
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div7', function () {
    if (document.getElementById('div3').innerHTML === "") {
        document.getElementById('div3').innerHTML = document.getElementById('div7').innerHTML;
        document.getElementById('div7').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div6').innerHTML === "") {
        document.getElementById('div6').innerHTML = document.getElementById('div7').innerHTML;
        document.getElementById('div7').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div8').innerHTML === "") {
        document.getElementById('div8').innerHTML = document.getElementById('div7').innerHTML;
        document.getElementById('div7').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div11').innerHTML === "") {
        document.getElementById('div11').innerHTML = document.getElementById('div7').innerHTML;
        document.getElementById('div7').innerHTML = ""
        counter();
    }
    else {
        error();

    }
    colors(); endgame();
});
$(document).on('click', '#div8', function () {
    if (document.getElementById('div4').innerHTML === "") {
        document.getElementById('div4').innerHTML = document.getElementById('div8').innerHTML;
        document.getElementById('div8').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div7').innerHTML === "") {
        document.getElementById('div7').innerHTML = document.getElementById('div8').innerHTML;
        document.getElementById('div8').innerHTML = ""
        counter();
    }
    else if (document.getElementById('div12').innerHTML === "") {
        document.getElementById('div12').innerHTML = document.getElementById('div8').innerHTML;
        document.getElementById('div8').innerHTML = ""
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div9', function () {
    if (document.getElementById('div5').innerHTML === "") {
        document.getElementById('div5').innerHTML = document.getElementById('div9').innerHTML;
        document.getElementById('div9').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div10').innerHTML === "") {
        document.getElementById('div10').innerHTML = document.getElementById('div9').innerHTML;
        document.getElementById('div9').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div13').innerHTML === "") {
        document.getElementById('div13').innerHTML = document.getElementById('div9').innerHTML;
        document.getElementById('div9').innerHTML = "";
        counter();
    }
    else {
        error();
        counter();
    }
    colors(); endgame();
});
$(document).on('click', '#div10', function () {
    if (document.getElementById('div6').innerHTML === "") {
        document.getElementById('div6').innerHTML = document.getElementById('div10').innerHTML;
        document.getElementById('div10').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div9').innerHTML === "") {
        document.getElementById('div9').innerHTML = document.getElementById('div10').innerHTML;
        document.getElementById('div10').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div11').innerHTML === "") {
        document.getElementById('div11').innerHTML = document.getElementById('div10').innerHTML;
        document.getElementById('div10').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div14').innerHTML === "") {
        document.getElementById('div14').innerHTML = document.getElementById('div10').innerHTML;
        document.getElementById('div10').innerHTML = "";
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div11', function () {
    if (document.getElementById('div7').innerHTML === "") {
        document.getElementById('div7').innerHTML = document.getElementById('div11').innerHTML;
        document.getElementById('div11').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div10').innerHTML === "") {
        document.getElementById('div10').innerHTML = document.getElementById('div11').innerHTML;
        document.getElementById('div11').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div12').innerHTML === "") {
        document.getElementById('div12').innerHTML = document.getElementById('div11').innerHTML;
        document.getElementById('div11').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div15').innerHTML === "") {
        document.getElementById('div15').innerHTML = document.getElementById('div11').innerHTML;
        document.getElementById('div11').innerHTML = "";
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div12', function () {
    if (document.getElementById('div8').innerHTML === "") {
        document.getElementById('div8').innerHTML = document.getElementById('div12').innerHTML;
        document.getElementById('div12').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div11').innerHTML === "") {
        document.getElementById('div11').innerHTML = document.getElementById('div12').innerHTML;
        document.getElementById('div12').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div16').innerHTML === "") {
        document.getElementById('div16').innerHTML = document.getElementById('div12').innerHTML;
        document.getElementById('div12').innerHTML = "";
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div13', function () {
    if (document.getElementById('div9').innerHTML === "") {
        document.getElementById('div9').innerHTML = document.getElementById('div13').innerHTML;
        document.getElementById('div13').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div14').innerHTML === "") {
        document.getElementById('div14').innerHTML = document.getElementById('div13').innerHTML;
        document.getElementById('div13').innerHTML = "";
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div14', function () {
    if (document.getElementById('div10').innerHTML === "") {
        document.getElementById('div10').innerHTML = document.getElementById('div14').innerHTML;
        document.getElementById('div14').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div13').innerHTML === "") {
        document.getElementById('div13').innerHTML = document.getElementById('div14').innerHTML;
        document.getElementById('div14').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div15').innerHTML === "") {
        document.getElementById('div15').innerHTML = document.getElementById('div14').innerHTML;
        document.getElementById('div14').innerHTML = "";
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div15', function () {
    if (document.getElementById('div16').innerHTML === "") {
        document.getElementById('div16').innerHTML = document.getElementById('div15').innerHTML;
        document.getElementById('div15').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div14').innerHTML === "") {
        document.getElementById('div14').innerHTML = document.getElementById('div15').innerHTML;
        document.getElementById('div15').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div11').innerHTML === "") {
        document.getElementById('div11').innerHTML = document.getElementById('div15').innerHTML;
        document.getElementById('div15').innerHTML = "";
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});
$(document).on('click', '#div16', function () {

    if (document.getElementById('div15').innerHTML === "") {
        document.getElementById('div15').innerHTML = document.getElementById('div16').innerHTML;
        document.getElementById('div16').innerHTML = "";
        counter();
    }
    else if (document.getElementById('div12').innerHTML === "") {
        document.getElementById('div12').innerHTML = document.getElementById('div16').innerHTML;
        document.getElementById('div16').innerHTML = "";
        counter();
    }
    else {
        error();
    }
    colors(); endgame();
});